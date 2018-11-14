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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dfsPdfText = new System.Windows.Forms.RichTextBox();
            this.tvDOM = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picImage = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
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
            this.dffOpenInputInAdobe = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.dffOpenOutputInAdobe = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dffOpenInputInAdobe);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.ltnSelectPDF);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PDF File";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMessage});
            this.statusStrip1.Location = new System.Drawing.Point(3, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(786, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsMessage
            // 
            this.tsMessage.Name = "tsMessage";
            this.tsMessage.Size = new System.Drawing.Size(771, 17);
            this.tsMessage.Spring = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dfsPdfText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tvDOM, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.picImage, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(783, 383);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // dfsPdfText
            // 
            this.dfsPdfText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dfsPdfText.Location = new System.Drawing.Point(3, 3);
            this.dfsPdfText.Name = "dfsPdfText";
            this.dfsPdfText.Size = new System.Drawing.Size(385, 185);
            this.dfsPdfText.TabIndex = 4;
            this.dfsPdfText.Text = "";
            // 
            // tvDOM
            // 
            this.tvDOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDOM.ImageIndex = 0;
            this.tvDOM.ImageList = this.imageList1;
            this.tvDOM.Location = new System.Drawing.Point(3, 194);
            this.tvDOM.Name = "tvDOM";
            this.tvDOM.SelectedImageIndex = 0;
            this.tvDOM.Size = new System.Drawing.Size(385, 186);
            this.tvDOM.TabIndex = 5;
            this.tvDOM.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDOM_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "White.png");
            // 
            // picImage
            // 
            this.picImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImage.Location = new System.Drawing.Point(394, 194);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(386, 186);
            this.picImage.TabIndex = 6;
            this.picImage.TabStop = false;
            // 
            // tabPage4
            // 
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
            this.tabPage4.Size = new System.Drawing.Size(792, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Arabic";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnRemoveImage, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dffOpenOutputInAdobe, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(394, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(386, 185);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.Location = new System.Drawing.Point(3, 3);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(161, 23);
            this.btnRemoveImage.TabIndex = 8;
            this.btnRemoveImage.Text = "Remove Image";
            this.btnRemoveImage.UseVisualStyleBackColor = true;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click_1);
            // 
            // dffOpenOutputInAdobe
            // 
            this.dffOpenOutputInAdobe.AutoSize = true;
            this.dffOpenOutputInAdobe.Location = new System.Drawing.Point(196, 3);
            this.dffOpenOutputInAdobe.Name = "dffOpenOutputInAdobe";
            this.dffOpenOutputInAdobe.Size = new System.Drawing.Size(97, 17);
            this.dffOpenOutputInAdobe.TabIndex = 11;
            this.dffOpenOutputInAdobe.Text = "Show in Adobe";
            this.dffOpenOutputInAdobe.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "PDF Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsMessage;
        private System.Windows.Forms.CheckBox dffOpenInputInAdobe;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.CheckBox dffOpenOutputInAdobe;
    }
}

