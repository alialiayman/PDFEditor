
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFEditor
{
    public partial class Form1 : Form
    {
        //https://simpledotnetsolutions.wordpress.com/2012/04/08/itextsharp-few-c-examples/
        PdfReader _reader;
        string fileName;
        public Form1()
        {
            InitializeComponent();
        }

        private void ltnSelectPDF_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var ofd = new OpenFileDialog { Filter = "PDF Files|*.pdf", Multiselect = false, Title = "Select PDF File" })
            {
                ofd.ShowDialog();
                if (string.IsNullOrEmpty( ofd.FileName)) return;
                fileName = ofd.FileName;
                _reader = new PdfReader(ofd.FileName);
                var sb = new StringBuilder();
                for (int i = 1; i <= _reader.NumberOfPages; i++)
                {
                    sb.Append(PdfTextExtractor.GetTextFromPage(_reader, i));
                }
                dfsPdfText.Text = sb.ToString();

                ShowObjects();

                Process.Start(ofd.FileName);
                    
            }

        }

        private void ShowObjects()
        {
            for (int i = 1; i <= _reader.XrefSize; i++)
            {
                PdfObject obj = _reader.GetPdfObject(i);
                if (obj == null) return;
                var node = tvDOM.Nodes.Add($"{i} - Type {obj.GetType().ToString()}");
                if (obj != null && obj.IsStream())
                {
                    PRStream stream = (PRStream)obj;
                    byte[] b;
                    try
                    {
                        b = PdfReader.GetStreamBytes(stream);
                    }
                    catch (Exception e)
                    {
                        b = PdfReader.GetStreamBytesRaw(stream);
                    }
                    var bytes = b;
                    try
                    {
                        iTextSharp.text.pdf.parser.PdfImageObject pdfImage =
                                new iTextSharp.text.pdf.parser.PdfImageObject(stream);
                        System.Drawing.Image img = pdfImage.GetDrawingImage();
                        //img.Save($"c:\\temp\\obj{DateTime.Now.Ticks}.{pdfImage.GetFileType()}");
                        node.Nodes.Add($"{pdfImage.GetFileType()}");
                        var imgNode = new TreeNode();
                        imageList1.Images.Add(i.ToString(),img);
                        imgNode.ImageKey = i.ToString();
                        node.Nodes.Add(imgNode);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
                
            }
        }

        private void btnWriteArabic_Click(object sender, EventArgs e)
        {
            SetEvisaArabicFieldValue(dfsFieldName.Text,  dfsArabicText.Text);
        }

        static PdfStamper _pdfStamper;
        static AcroFields pdfFormFields;

        public  void SetEvisaArabicFieldValue(string fieldName, string fieldValue)
        {
            try
            {
                _reader = new PdfReader(fileName);
                pdfFormFields = _reader.AcroFields;
                var field = pdfFormFields.GetFieldItem(fieldName).GetValue(0);
                Console.WriteLine(field.ToString());
                var outfileName = fileName.Replace(".pdf", DateTime.Now.Ticks.ToString() + ".pdf");
                _pdfStamper = new PdfStamper(_reader, new FileStream(outfileName, FileMode.Create));

                string ARIALUNI_TFF = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "trado.TTF");
                BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font f = new iTextSharp.text.Font(bf);

                PdfContentByte overContent = _pdfStamper.GetOverContent(1); //1 means page 1
                var fieldPosition = pdfFormFields.GetFieldPositions(fieldName)[0].position;

                ColumnText ct = new ColumnText(overContent) { RunDirection = PdfWriter.RUN_DIRECTION_RTL, YLine = 5  };
                if (rdCenter.Checked)
                    ct.SetSimpleColumn(fieldPosition.Left, fieldPosition.Bottom - fieldPosition.Height /2, fieldPosition.Right, fieldPosition.Top - fieldPosition.Height / 2, 0, Element.ALIGN_CENTER);
                else if (rdRight.Checked)
                    ct.SetSimpleColumn(fieldPosition.Left, fieldPosition.Bottom - fieldPosition.Height / 2, fieldPosition.Right, fieldPosition.Top - fieldPosition.Height / 2, 0, Element.ALIGN_RIGHT);
                if (rdLeft.Checked)
                    ct.SetSimpleColumn(fieldPosition.Left, fieldPosition.Bottom - fieldPosition.Height / 2, fieldPosition.Right, fieldPosition.Top - fieldPosition.Height / 2, 0, Element.ALIGN_LEFT);
                if (rdUseFieldAlignment.Checked)
                    ct.SetSimpleColumn(fieldPosition.Left, fieldPosition.Bottom - fieldPosition.Height / 2, fieldPosition.Right, fieldPosition.Top - fieldPosition.Height / 2, 0, Element.ALIGN_LEFT);

                ct.SetText(new Phrase(fieldValue, f));
                ct.Go();

                //uncomment to draw rectangle
                //var rect = new iTextSharp.text.Rectangle(fieldPosition.Left, fieldPosition.Bottom - fieldPosition.Height / 2, fieldPosition.Right, fieldPosition.Top - fieldPosition.Height / 2);
                //rect.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER;
                //rect.BorderWidth = 5;
                //rect.BorderColor = new BaseColor(0, 0, 0);

                //overContent.Rectangle(rect);
                _pdfStamper.Close();
                Process.Start(outfileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }


        }

        public  float[] GetFieldPositions(string fieldName)
        {
            float[] output = new float[5];
            var positions = pdfFormFields.GetFieldPositions(fieldName)[0];



            output[1] = positions.position.Left;
            output[2] = positions.position.Bottom;
            output[3] = positions.position.Right;
            output[4] = positions.position.Top;
            return output;
        }

        private void btnRemoveunusedObjects_Click(object sender, EventArgs e)
        {
            try
            {
                _reader = new PdfReader(fileName);
                var outfileName = fileName.Replace(".pdf", DateTime.Now.Ticks.ToString() + ".pdf");
                _pdfStamper = new PdfStamper(_reader, new FileStream(outfileName, FileMode.Create));


                int numPages = _reader.NumberOfPages;
                int pgNumber = 1;

                PdfDictionary page = _reader.GetPageN(pgNumber);
                PdfArray contentarray = page.GetAsArray(PdfName.CONTENTS);
                PRStream stream;
                string content;
                if (contentarray != null)
                {
                    //Loop through content
                    for (int j = 0; j < contentarray.Size; j++)
                    {
                        stream = (PRStream)contentarray.GetAsStream(j);
                        content = Encoding.ASCII.GetString(PdfReader.GetStreamBytes(stream));
                        string[] tokens = content.Split('\n');
                        for (int i = 0; i < tokens.Length; i++)
                        {
                            if (tokens[i].Contains("/QuickPDF"))
                            {
                                tokens[i] = string.Empty;
                            }
                        }

                        string outstr = string.Join("\n", tokens.Select(p => p).ToArray());
                        byte[] outbytes = Encoding.ASCII.GetBytes(outstr);
                        stream.SetData(outbytes);
                    }
                }




                _pdfStamper.Close();
                Process.Start(outfileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
