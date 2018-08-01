namespace Session02
{
    partial class FrmCheckBoxRadio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCheckBoxRadio));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSing = new System.Windows.Forms.CheckBox();
            this.chkSport = new System.Windows.Forms.CheckBox();
            this.chkShopping = new System.Windows.Forms.CheckBox();
            this.chkGame = new System.Windows.Forms.CheckBox();
            this.btnSelectCheckBox = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoText = new System.Windows.Forms.RadioButton();
            this.rdoWord = new System.Windows.Forms.RadioButton();
            this.rdoPdf = new System.Windows.Forms.RadioButton();
            this.rdoExcel = new System.Windows.Forms.RadioButton();
            this.btnRadio = new System.Windows.Forms.Button();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ptAnh = new System.Windows.Forms.PictureBox();
            this.btnChoosePicture = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectCheckBox);
            this.groupBox1.Controls.Add(this.chkSing);
            this.groupBox1.Controls.Add(this.chkSport);
            this.groupBox1.Controls.Add(this.chkShopping);
            this.groupBox1.Controls.Add(this.chkGame);
            this.groupBox1.Location = new System.Drawing.Point(21, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 145);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sở thích";
            // 
            // chkSing
            // 
            this.chkSing.AutoSize = true;
            this.chkSing.Checked = true;
            this.chkSing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSing.Location = new System.Drawing.Point(185, 66);
            this.chkSing.Name = "chkSing";
            this.chkSing.Size = new System.Drawing.Size(47, 17);
            this.chkSing.TabIndex = 7;
            this.chkSing.Text = "Sing";
            this.chkSing.UseVisualStyleBackColor = true;
            // 
            // chkSport
            // 
            this.chkSport.AutoSize = true;
            this.chkSport.Location = new System.Drawing.Point(185, 29);
            this.chkSport.Name = "chkSport";
            this.chkSport.Size = new System.Drawing.Size(51, 17);
            this.chkSport.TabIndex = 6;
            this.chkSport.Text = "Sport";
            this.chkSport.UseVisualStyleBackColor = true;
            // 
            // chkShopping
            // 
            this.chkShopping.AutoSize = true;
            this.chkShopping.Checked = true;
            this.chkShopping.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShopping.Location = new System.Drawing.Point(37, 66);
            this.chkShopping.Name = "chkShopping";
            this.chkShopping.Size = new System.Drawing.Size(71, 17);
            this.chkShopping.TabIndex = 5;
            this.chkShopping.Text = "Shopping";
            this.chkShopping.UseVisualStyleBackColor = true;
            // 
            // chkGame
            // 
            this.chkGame.AutoSize = true;
            this.chkGame.Location = new System.Drawing.Point(37, 29);
            this.chkGame.Name = "chkGame";
            this.chkGame.Size = new System.Drawing.Size(54, 17);
            this.chkGame.TabIndex = 4;
            this.chkGame.Text = "Game";
            this.chkGame.UseVisualStyleBackColor = true;
            // 
            // btnSelectCheckBox
            // 
            this.btnSelectCheckBox.Location = new System.Drawing.Point(185, 105);
            this.btnSelectCheckBox.Name = "btnSelectCheckBox";
            this.btnSelectCheckBox.Size = new System.Drawing.Size(75, 23);
            this.btnSelectCheckBox.TabIndex = 8;
            this.btnSelectCheckBox.Text = "Submit";
            this.btnSelectCheckBox.UseVisualStyleBackColor = true;
            this.btnSelectCheckBox.Click += new System.EventHandler(this.btnSelectCheckBox_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRadio);
            this.groupBox2.Controls.Add(this.rdoExcel);
            this.groupBox2.Controls.Add(this.rdoPdf);
            this.groupBox2.Controls.Add(this.rdoWord);
            this.groupBox2.Controls.Add(this.rdoText);
            this.groupBox2.Location = new System.Drawing.Point(396, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 145);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xuất dữ liệu";
            // 
            // rdoText
            // 
            this.rdoText.AutoSize = true;
            this.rdoText.Location = new System.Drawing.Point(34, 29);
            this.rdoText.Name = "rdoText";
            this.rdoText.Size = new System.Drawing.Size(53, 17);
            this.rdoText.TabIndex = 0;
            this.rdoText.Text = "TEXT";
            this.rdoText.UseVisualStyleBackColor = true;
            // 
            // rdoWord
            // 
            this.rdoWord.AutoSize = true;
            this.rdoWord.Location = new System.Drawing.Point(143, 29);
            this.rdoWord.Name = "rdoWord";
            this.rdoWord.Size = new System.Drawing.Size(60, 17);
            this.rdoWord.TabIndex = 1;
            this.rdoWord.Text = "WORD";
            this.rdoWord.UseVisualStyleBackColor = true;
            // 
            // rdoPdf
            // 
            this.rdoPdf.AutoSize = true;
            this.rdoPdf.Location = new System.Drawing.Point(34, 66);
            this.rdoPdf.Name = "rdoPdf";
            this.rdoPdf.Size = new System.Drawing.Size(46, 17);
            this.rdoPdf.TabIndex = 2;
            this.rdoPdf.Text = "PDF";
            this.rdoPdf.UseVisualStyleBackColor = true;
            // 
            // rdoExcel
            // 
            this.rdoExcel.AutoSize = true;
            this.rdoExcel.Checked = true;
            this.rdoExcel.Location = new System.Drawing.Point(143, 66);
            this.rdoExcel.Name = "rdoExcel";
            this.rdoExcel.Size = new System.Drawing.Size(59, 17);
            this.rdoExcel.TabIndex = 3;
            this.rdoExcel.TabStop = true;
            this.rdoExcel.Text = "EXCEL";
            this.rdoExcel.UseVisualStyleBackColor = true;
            // 
            // btnRadio
            // 
            this.btnRadio.Location = new System.Drawing.Point(199, 105);
            this.btnRadio.Name = "btnRadio";
            this.btnRadio.Size = new System.Drawing.Size(75, 23);
            this.btnRadio.TabIndex = 4;
            this.btnRadio.Text = "Submit";
            this.btnRadio.UseVisualStyleBackColor = true;
            this.btnRadio.Click += new System.EventHandler(this.btnRadio_Click);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("Việt Nam");
            this.domainUpDown1.Items.Add("Thái Lan");
            this.domainUpDown1.Items.Add("Philipin");
            this.domainUpDown1.Items.Add("Mỹ");
            this.domainUpDown1.Items.Add("Trung Quốc");
            this.domainUpDown1.Location = new System.Drawing.Point(21, 193);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown1.TabIndex = 6;
            this.domainUpDown1.Text = "Chọn quốc gia";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(21, 220);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ptAnh
            // 
            this.ptAnh.Image = global::Session02.Properties.Resources.anhnen;
            this.ptAnh.Location = new System.Drawing.Point(396, 193);
            this.ptAnh.Name = "ptAnh";
            this.ptAnh.Size = new System.Drawing.Size(300, 170);
            this.ptAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptAnh.TabIndex = 8;
            this.ptAnh.TabStop = false;
            // 
            // btnChoosePicture
            // 
            this.btnChoosePicture.Location = new System.Drawing.Point(315, 340);
            this.btnChoosePicture.Name = "btnChoosePicture";
            this.btnChoosePicture.Size = new System.Drawing.Size(75, 23);
            this.btnChoosePicture.TabIndex = 9;
            this.btnChoosePicture.Text = "Chọn ảnh";
            this.btnChoosePicture.UseVisualStyleBackColor = true;
            this.btnChoosePicture.Click += new System.EventHandler(this.btnChoosePicture_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "anhnen.jpg");
            this.imageList1.Images.SetKeyName(1, "Bel_groupe_2010_logo-350x350.png");
            this.imageList1.Images.SetKeyName(2, "bretagne_mont_saint_michel_article-620x300.png");
            this.imageList1.Images.SetKeyName(3, "diem-danh-c1702l-27-03-2018.PNG");
            this.imageList1.Images.SetKeyName(4, "download.png");
            // 
            // FrmCheckBoxRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 416);
            this.Controls.Add(this.btnChoosePicture);
            this.Controls.Add(this.ptAnh);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCheckBoxRadio";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelectCheckBox;
        private System.Windows.Forms.CheckBox chkSing;
        private System.Windows.Forms.CheckBox chkSport;
        private System.Windows.Forms.CheckBox chkShopping;
        private System.Windows.Forms.CheckBox chkGame;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRadio;
        private System.Windows.Forms.RadioButton rdoExcel;
        private System.Windows.Forms.RadioButton rdoPdf;
        private System.Windows.Forms.RadioButton rdoWord;
        private System.Windows.Forms.RadioButton rdoText;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox ptAnh;
        private System.Windows.Forms.Button btnChoosePicture;
        private System.Windows.Forms.ImageList imageList1;
    }
}

