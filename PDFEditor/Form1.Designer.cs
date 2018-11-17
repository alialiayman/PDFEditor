namespace PDFEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ltnSelectPDF = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnMarkForDeletion = new System.Windows.Forms.Button();
            this.btnRemoveUnused = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstSelectedImages = new System.Windows.Forms.ListBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnRemoveObject = new System.Windows.Forms.Button();
            this.dffOpenInputInAdobe = new System.Windows.Forms.CheckBox();
            this.dffOpenOutputInAdobe = new System.Windows.Forms.CheckBox();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.tvDOM = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dfsPdfText = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRemoveunusedObjects = new System.Windows.Forms.Button();
            this.rdUseFieldAlignment = new System.Windows.Forms.RadioButton();
            this.rdCenter = new System.Windows.Forms.RadioButton();
            this.rdRight = new System.Windows.Forms.RadioButton();
            this.rdLeft = new System.Windows.Forms.RadioButton();
            this.btnWriteArabic = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dfsArabicText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dfsFieldName = new System.Windows.Forms.TextBox();
            this.btnTruncateStream = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltnSelectPDF
            // 
            this.ltnSelectPDF.AutoSize = true;
            this.ltnSelectPDF.Location = new System.Drawing.Point(125, 14);
            this.ltnSelectPDF.Name = "ltnSelectPDF";
            this.ltnSelectPDF.Size = new System.Drawing.Size(77, 13);
            this.ltnSelectPDF.TabIndex = 0;
            this.ltnSelectPDF.TabStop = true;
            this.ltnSelectPDF.Text = "Select PDF File";
            this.ltnSelectPDF.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ltnSelectPDF_LinkClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(872, 630);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTruncateStream);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.btnMarkForDeletion);
            this.tabPage1.Controls.Add(this.btnRemoveUnused);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lstSelectedImages);
            this.tabPage1.Controls.Add(this.picImage);
            this.tabPage1.Controls.Add(this.btnRemoveObject);
            this.tabPage1.Controls.Add(this.dffOpenInputInAdobe);
            this.tabPage1.Controls.Add(this.dffOpenOutputInAdobe);
            this.tabPage1.Controls.Add(this.btnRemoveImage);
            this.tabPage1.Controls.Add(this.tvDOM);
            this.tabPage1.Controls.Add(this.dfsPdfText);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.ltnSelectPDF);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(864, 604);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PDF File";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(412, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 19;
            // 
            // btnMarkForDeletion
            // 
            this.btnMarkForDeletion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarkForDeletion.Location = new System.Drawing.Point(716, 183);
            this.btnMarkForDeletion.Name = "btnMarkForDeletion";
            this.btnMarkForDeletion.Size = new System.Drawing.Size(137, 23);
            this.btnMarkForDeletion.TabIndex = 18;
            this.btnMarkForDeletion.Text = "Mark for Deletion";
            this.btnMarkForDeletion.UseVisualStyleBackColor = true;
            this.btnMarkForDeletion.Click += new System.EventHandler(this.btnMarkForDeletion_Click);
            // 
            // btnRemoveUnused
            // 
            this.btnRemoveUnused.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveUnused.Location = new System.Drawing.Point(554, 397);
            this.btnRemoveUnused.Name = "btnRemoveUnused";
            this.btnRemoveUnused.Size = new System.Drawing.Size(166, 23);
            this.btnRemoveUnused.TabIndex = 17;
            this.btnRemoveUnused.Text = "Remove unnecessary things";
            this.btnRemoveUnused.UseVisualStyleBackColor = true;
            this.btnRemoveUnused.Click += new System.EventHandler(this.btnRemoveUnused_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Selected Image";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "All Objects in file [Images displayed in green]";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "All Text in file";
            // 
            // lstSelectedImages
            // 
            this.lstSelectedImages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSelectedImages.FormattingEnabled = true;
            this.lstSelectedImages.Location = new System.Drawing.Point(554, 212);
            this.lstSelectedImages.Name = "lstSelectedImages";
            this.lstSelectedImages.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSelectedImages.Size = new System.Drawing.Size(299, 121);
            this.lstSelectedImages.TabIndex = 13;
            // 
            // picImage
            // 
            this.picImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picImage.BackColor = System.Drawing.Color.Silver;
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImage.Location = new System.Drawing.Point(554, 70);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(299, 110);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 6;
            this.picImage.TabStop = false;
            // 
            // btnRemoveObject
            // 
            this.btnRemoveObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveObject.Location = new System.Drawing.Point(554, 339);
            this.btnRemoveObject.Name = "btnRemoveObject";
            this.btnRemoveObject.Size = new System.Drawing.Size(166, 23);
            this.btnRemoveObject.TabIndex = 12;
            this.btnRemoveObject.Text = "Remove Marked Images";
            this.btnRemoveObject.UseVisualStyleBackColor = true;
            this.btnRemoveObject.Click += new System.EventHandler(this.btnRemoveObject_Click);
            // 
            // dffOpenInputInAdobe
            // 
            this.dffOpenInputInAdobe.AutoSize = true;
            this.dffOpenInputInAdobe.Location = new System.Drawing.Point(8, 13);
            this.dffOpenInputInAdobe.Name = "dffOpenInputInAdobe";
            this.dffOpenInputInAdobe.Size = new System.Drawing.Size(97, 17);
            this.dffOpenInputInAdobe.TabIndex = 10;
            this.dffOpenInputInAdobe.Text = "Show in Adobe";
            this.dffOpenInputInAdobe.UseVisualStyleBackColor = true;
            // 
            // dffOpenOutputInAdobe
            // 
            this.dffOpenOutputInAdobe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dffOpenOutputInAdobe.AutoSize = true;
            this.dffOpenOutputInAdobe.Location = new System.Drawing.Point(756, 368);
            this.dffOpenOutputInAdobe.Name = "dffOpenOutputInAdobe";
            this.dffOpenOutputInAdobe.Size = new System.Drawing.Size(97, 17);
            this.dffOpenOutputInAdobe.TabIndex = 11;
            this.dffOpenOutputInAdobe.Text = "Show in Adobe";
            this.dffOpenOutputInAdobe.UseVisualStyleBackColor = true;
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveImage.Location = new System.Drawing.Point(554, 368);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(166, 23);
            this.btnRemoveImage.TabIndex = 8;
            this.btnRemoveImage.Text = "Remove All Images";
            this.btnRemoveImage.UseVisualStyleBackColor = true;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click_1);
            // 
            // tvDOM
            // 
            this.tvDOM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvDOM.ImageIndex = 0;
            this.tvDOM.ImageList = this.imageList1;
            this.tvDOM.Location = new System.Drawing.Point(3, 54);
            this.tvDOM.Name = "tvDOM";
            this.tvDOM.SelectedImageIndex = 0;
            this.tvDOM.Size = new System.Drawing.Size(545, 369);
            this.tvDOM.TabIndex = 5;
            this.tvDOM.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDOM_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "White.png");
            // 
            // dfsPdfText
            // 
            this.dfsPdfText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dfsPdfText.Location = new System.Drawing.Point(3, 448);
            this.dfsPdfText.Name = "dfsPdfText";
            this.dfsPdfText.Size = new System.Drawing.Size(545, 128);
            this.dfsPdfText.TabIndex = 4;
            this.dfsPdfText.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMessage});
            this.statusStrip1.Location = new System.Drawing.Point(3, 579);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(858, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsMessage
            // 
            this.tsMessage.Name = "tsMessage";
            this.tsMessage.Size = new System.Drawing.Size(843, 17);
            this.tsMessage.Spring = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.btnRemoveunusedObjects);
            this.tabPage4.Controls.Add(this.rdUseFieldAlignment);
            this.tabPage4.Controls.Add(this.rdCenter);
            this.tabPage4.Controls.Add(this.rdRight);
            this.tabPage4.Controls.Add(this.rdLeft);
            this.tabPage4.Controls.Add(this.btnWriteArabic);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.dfsArabicText);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.dfsFieldName);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(864, 604);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Arabic";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Write Vertical Arabic";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Write Vertical English";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnRemoveunusedObjects
            // 
            this.btnRemoveunusedObjects.Location = new System.Drawing.Point(578, 22);
            this.btnRemoveunusedObjects.Name = "btnRemoveunusedObjects";
            this.btnRemoveunusedObjects.Size = new System.Drawing.Size(194, 23);
            this.btnRemoveunusedObjects.TabIndex = 9;
            this.btnRemoveunusedObjects.Text = "Remove unused objects";
            this.btnRemoveunusedObjects.UseVisualStyleBackColor = true;
            this.btnRemoveunusedObjects.Click += new System.EventHandler(this.btnRemoveunusedObjects_Click);
            // 
            // rdUseFieldAlignment
            // 
            this.rdUseFieldAlignment.AutoSize = true;
            this.rdUseFieldAlignment.Location = new System.Drawing.Point(90, 123);
            this.rdUseFieldAlignment.Name = "rdUseFieldAlignment";
            this.rdUseFieldAlignment.Size = new System.Drawing.Size(99, 17);
            this.rdUseFieldAlignment.TabIndex = 8;
            this.rdUseFieldAlignment.Text = "Form Alignment";
            this.rdUseFieldAlignment.UseVisualStyleBackColor = true;
            // 
            // rdCenter
            // 
            this.rdCenter.AutoSize = true;
            this.rdCenter.Location = new System.Drawing.Point(162, 90);
            this.rdCenter.Name = "rdCenter";
            this.rdCenter.Size = new System.Drawing.Size(58, 17);
            this.rdCenter.TabIndex = 7;
            this.rdCenter.Text = "Center";
            this.rdCenter.UseVisualStyleBackColor = true;
            // 
            // rdRight
            // 
            this.rdRight.AutoSize = true;
            this.rdRight.Checked = true;
            this.rdRight.Location = new System.Drawing.Point(240, 90);
            this.rdRight.Name = "rdRight";
            this.rdRight.Size = new System.Drawing.Size(50, 17);
            this.rdRight.TabIndex = 6;
            this.rdRight.TabStop = true;
            this.rdRight.Text = "Right";
            this.rdRight.UseVisualStyleBackColor = true;
            // 
            // rdLeft
            // 
            this.rdLeft.AutoSize = true;
            this.rdLeft.Location = new System.Drawing.Point(90, 90);
            this.rdLeft.Name = "rdLeft";
            this.rdLeft.Size = new System.Drawing.Size(44, 17);
            this.rdLeft.TabIndex = 5;
            this.rdLeft.Text = "Left";
            this.rdLeft.UseVisualStyleBackColor = true;
            // 
            // btnWriteArabic
            // 
            this.btnWriteArabic.Location = new System.Drawing.Point(90, 159);
            this.btnWriteArabic.Name = "btnWriteArabic";
            this.btnWriteArabic.Size = new System.Drawing.Size(194, 23);
            this.btnWriteArabic.TabIndex = 4;
            this.btnWriteArabic.Text = "Write";
            this.btnWriteArabic.UseVisualStyleBackColor = true;
            this.btnWriteArabic.Click += new System.EventHandler(this.btnWriteArabic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arabic Text";
            // 
            // dfsArabicText
            // 
            this.dfsArabicText.Location = new System.Drawing.Point(90, 55);
            this.dfsArabicText.Name = "dfsArabicText";
            this.dfsArabicText.Size = new System.Drawing.Size(194, 20);
            this.dfsArabicText.TabIndex = 2;
            this.dfsArabicText.Text = "السلام عليكم";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Field Name";
            // 
            // dfsFieldName
            // 
            this.dfsFieldName.Location = new System.Drawing.Point(90, 29);
            this.dfsFieldName.Name = "dfsFieldName";
            this.dfsFieldName.Size = new System.Drawing.Size(194, 20);
            this.dfsFieldName.TabIndex = 0;
            this.dfsFieldName.Text = "fullnamearabic";
            // 
            // btnTruncateStream
            // 
            this.btnTruncateStream.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTruncateStream.Location = new System.Drawing.Point(554, 183);
            this.btnTruncateStream.Name = "btnTruncateStream";
            this.btnTruncateStream.Size = new System.Drawing.Size(137, 23);
            this.btnTruncateStream.TabIndex = 21;
            this.btnTruncateStream.Text = "Truncate Stream";
            this.btnTruncateStream.UseVisualStyleBackColor = true;
            this.btnTruncateStream.Click += new System.EventHandler(this.btnTruncateStream_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 630);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "PDF Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel ltnSelectPDF;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RadioButton rdCenter;
        private System.Windows.Forms.RadioButton rdRight;
        private System.Windows.Forms.RadioButton rdLeft;
        private System.Windows.Forms.Button btnWriteArabic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dfsArabicText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dfsFieldName;
        private System.Windows.Forms.TreeView tvDOM;
        private System.Windows.Forms.RichTextBox dfsPdfText;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RadioButton rdUseFieldAlignment;
        private System.Windows.Forms.Button btnRemoveunusedObjects;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsMessage;
        private System.Windows.Forms.CheckBox dffOpenInputInAdobe;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.CheckBox dffOpenOutputInAdobe;
        private System.Windows.Forms.Button btnRemoveObject;
        private System.Windows.Forms.ListBox lstSelectedImages;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRemoveUnused;
        private System.Windows.Forms.Button btnMarkForDeletion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTruncateStream;
    }
}

