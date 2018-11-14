using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Path = System.IO.Path;

namespace PDFEditor
{
    public partial class Form1 : Form
    {
        private static PdfStamper _pdfStamper;

        private static AcroFields pdfFormFields;

        //https://simpledotnetsolutions.wordpress.com/2012/04/08/itextsharp-few-c-examples/
        private PdfReader _reader;
        private string fileName;

        public Form1()
        {
            InitializeComponent();
        }

        private void ltnSelectPDF_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var ofd = new OpenFileDialog
                {Filter = "PDF Files|*.pdf", Multiselect = false, Title = "Select PDF File"})
            {
                ofd.ShowDialog();
                if (string.IsNullOrEmpty(ofd.FileName)) return;
                fileName = ofd.FileName;
                _reader = new PdfReader(ofd.FileName);
                var sb = new StringBuilder();
                for (var i = 1; i <= _reader.NumberOfPages; i++)
                    sb.Append(PdfTextExtractor.GetTextFromPage(_reader, i));
                dfsPdfText.Text = sb.ToString();

                ShowObjects();
                if (dffOpenInputInAdobe.Checked)
                Process.Start(ofd.FileName);
            }
        }

        private void ShowObjects()
        {
            for (var i = 1; i <= _reader.XrefSize; i++)
            {
                var obj = _reader.GetPdfObject(i);
                if (obj == null) continue;
                var node = PrintObject(tvDOM.Nodes, obj, i.ToString());
                node.Tag = obj;
            }
        }

        private TreeNode PrintObject(TreeNodeCollection tvDomNodes, PdfObject obj, string objectNumber)
        {
            var streamType = GetStreamType(obj);
            var node = tvDomNodes.Add($"{objectNumber} - Type {obj.GetType()} {streamType}");
            node.Tag = obj;
            if (streamType.StartsWith("Image"))
                node.BackColor = System.Drawing.Color.Olive;
            if (obj.IsDictionary())
            {
                var dict = obj as PdfDictionary;
                foreach (var dictKey in dict.Keys)
                {
                    var dictObj = dict.GetDirectObject(dictKey);
                    var newNode = PrintObject(node.Nodes, dictObj, dictObj.ToString());
                    //return node.Nodes[0];
                }
            }
                return node;
            
        }

        private void btnWriteArabic_Click(object sender, EventArgs e)
        {
            SetEvisaArabicFieldValue(dfsFieldName.Text, dfsArabicText.Text);
        }

        public void SetEvisaArabicFieldValue(string fieldName, string fieldValue)
        {
            try
            {
                _reader = new PdfReader(fileName);
                pdfFormFields = _reader.AcroFields;
                var field = pdfFormFields.GetFieldItem(fieldName).GetValue(0);
                Console.WriteLine(field.ToString());
                var outfileName = fileName.Replace(".pdf", DateTime.Now.Ticks + ".pdf");
                _pdfStamper = new PdfStamper(_reader, new FileStream(outfileName, FileMode.Create));

                var ARIALUNI_TFF =
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "trado.TTF");
                var bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                var f = new Font(bf);

                var overContent = _pdfStamper.GetOverContent(1); //1 means page 1
                var fieldPosition = pdfFormFields.GetFieldPositions(fieldName)[0].position;

                var ct = new ColumnText(overContent) {RunDirection = PdfWriter.RUN_DIRECTION_RTL, YLine = 5};
                if (rdCenter.Checked)
                    ct.SetSimpleColumn(fieldPosition.Left, fieldPosition.Bottom - fieldPosition.Height / 2,
                        fieldPosition.Right, fieldPosition.Top - fieldPosition.Height / 2, 0, Element.ALIGN_CENTER);
                else if (rdRight.Checked)
                    ct.SetSimpleColumn(fieldPosition.Left, fieldPosition.Bottom - fieldPosition.Height / 2,
                        fieldPosition.Right, fieldPosition.Top - fieldPosition.Height / 2, 0, Element.ALIGN_RIGHT);
                if (rdLeft.Checked)
                    ct.SetSimpleColumn(fieldPosition.Left, fieldPosition.Bottom - fieldPosition.Height / 2,
                        fieldPosition.Right, fieldPosition.Top - fieldPosition.Height / 2, 0, Element.ALIGN_LEFT);
                if (rdUseFieldAlignment.Checked)
                    ct.SetSimpleColumn(fieldPosition.Left, fieldPosition.Bottom - fieldPosition.Height / 2,
                        fieldPosition.Right, fieldPosition.Top - fieldPosition.Height / 2, 0, Element.ALIGN_LEFT);

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

        public float[] GetFieldPositions(string fieldName)
        {
            var output = new float[5];
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
                var outfileName = fileName.Replace(".pdf", DateTime.Now.Ticks + ".pdf");
                _pdfStamper = new PdfStamper(_reader, new FileStream(outfileName, FileMode.Create));


                var numPages = _reader.NumberOfPages;
                var pgNumber = 1;

                var page = _reader.GetPageN(pgNumber);
                var contentarray = page.GetAsArray(PdfName.CONTENTS);
                PRStream stream;
                string content;
                if (contentarray != null)
                    for (var j = 0; j < contentarray.Size; j++)
                    {
                        stream = (PRStream) contentarray.GetAsStream(j);
                        content = Encoding.ASCII.GetString(PdfReader.GetStreamBytes(stream));
                        var tokens = content.Split('\n');
                        for (var i = 0; i < tokens.Length; i++)
                            if (tokens[i].Contains("/QuickPDF"))
                                tokens[i] = string.Empty;

                        var outstr = string.Join("\n", tokens.Select(p => p).ToArray());
                        var outbytes = Encoding.ASCII.GetBytes(outstr);
                        stream.SetData(outbytes);
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

        private void tvDOM_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var obj = e.Node.Tag as PdfObject;

            if (obj != null && obj.IsStream())
            {
                var stream = (PRStream) obj;
                byte[] b;
                try
                {
                    b = PdfReader.GetStreamBytes(stream);
                }
                catch (Exception ex1)
                {
                    b = PdfReader.GetStreamBytesRaw(stream);
                }

                var bytes = b;
                try
                {
                    var pdfImage = new PdfImageObject(stream);
                    picImage.Image = pdfImage.GetDrawingImage();
                }
                catch (Exception ex)
                {
                    tsMessage.Text = ex.Message;
                }
            }
        }

        private string GetStreamType(PdfObject obj)
        {
            if (obj == null) return "unknown";

            if (obj.IsStream())
            {
                var stream = (PRStream) obj;
                try
                {
                    var pdfImage = new PdfImageObject(stream);
                    if (pdfImage != null) return $"Image {pdfImage.GetFileType()}";
                }
                catch (Exception ex)
                {
                    tsMessage.Text = ex.Message;
                    return "not image";
                }
            }
            else if (obj.IsArray())
            {
                return "arrary";
            }
            else if (obj.IsBoolean())
            {
                return "bool";
            }
            else if (obj.IsDictionary())
            {
                return "dictionary";
            }
            else if (obj.IsIndirect())
            {
                return "indirect";
            }
            else if (obj.IsName())
            {
                return "name";
            }
            else if (obj.IsNumber())
            {
                return "number";
            }
            else if (obj.IsString())
            {
                return "string";
            }

            return "unknown";
        }



        private void btnRemoveImage_Click_1(object sender, EventArgs e)
        {

            var obj1 = tvDOM.SelectedNode.Tag as PdfObject;


            try
            {
                var sourceFolder = Path.GetDirectoryName(fileName);
                if (!Directory.Exists(sourceFolder + "\\Output"))
                    Directory.CreateDirectory(sourceFolder + "\\Output");

                var outfileName = sourceFolder + "\\Output\\" + Path.GetFileName(fileName);
                _pdfStamper = new PdfStamper(_reader, new FileStream(outfileName, FileMode.Create));
                PdfWriter writer = _pdfStamper.Writer;
                //Image img = Image.GetInstance("image.png");
                PdfDictionary pg = _reader.GetPageN(1);
                PdfDictionary res =
                  (PdfDictionary)PdfReader.GetPdfObject(pg.Get(PdfName.RESOURCES));
                PdfDictionary xobj =
                  (PdfDictionary)PdfReader.GetPdfObject(res.Get(PdfName.XOBJECT));
                if (xobj != null)
                {
                    foreach (PdfName name in xobj.Keys)
                    {
                        PdfObject obj = xobj.Get(name);
                        if (obj.IsIndirect())
                        {
                            PdfDictionary tg = (PdfDictionary)PdfReader.GetPdfObject(obj);
                            PdfName type =
                              (PdfName)PdfReader.GetPdfObject(tg.Get(PdfName.SUBTYPE));
                            if (PdfName.IMAGE.Equals(type))
                            {
                                PdfReader.KillIndirect(obj);
                                Stream white = File.OpenRead("White.png");
                                iTextSharp.text.Image img2 = iTextSharp.text.Image.GetInstance(white);


                                writer.AddDirectImageSimple(img2, (PRIndirectReference)obj);
                                break;
                            }
                        }
                    }
                }
                
                _reader.RemoveUnusedObjects();
                _pdfStamper.Close();
                if (dffOpenOutputInAdobe.Checked)
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