namespace Session02
{
    partial class FrmListViewTreeView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("C1610M");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("C1710M");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Hệ thống đào tạo CNTT BKAP", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListViewTreeView));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvClass = new System.Windows.Forms.TreeView();
            this.lstStudent = new System.Windows.Forms.ListView();
            this.imgIcon = new System.Windows.Forms.ImageList(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rdoLarge = new System.Windows.Forms.RadioButton();
            this.rdoDetail = new System.Windows.Forms.RadioButton();
            this.rdoList = new System.Windows.Forms.RadioButton();
            this.rdoSmall = new System.Windows.Forms.RadioButton();
            this.rdoTile = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvClass);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rdoTile);
            this.splitContainer1.Panel2.Controls.Add(this.rdoSmall);
            this.splitContainer1.Panel2.Controls.Add(this.rdoList);
            this.splitContainer1.Panel2.Controls.Add(this.rdoDetail);
            this.splitContainer1.Panel2.Controls.Add(this.rdoLarge);
            this.splitContainer1.Panel2.Controls.Add(this.lstStudent);
            this.splitContainer1.Size = new System.Drawing.Size(801, 391);
            this.splitContainer1.SplitterDistance = 224;
            this.splitContainer1.TabIndex = 0;
            // 
            // trvClass
            // 
            this.trvClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvClass.ImageIndex = 0;
            this.trvClass.ImageList = this.imgIcon;
            this.trvClass.Location = new System.Drawing.Point(0, 0);
            this.trvClass.Name = "trvClass";
            treeNode1.ImageKey = "group_32.png";
            treeNode1.Name = "Node2";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Tag = "1";
            treeNode1.Text = "C1610M";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "Node3";
            treeNode2.SelectedImageKey = "group_32.png";
            treeNode2.Tag = "2";
            treeNode2.Text = "C1710M";
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "Node0";
            treeNode3.SelectedImageIndex = 0;
            treeNode3.Tag = "0";
            treeNode3.Text = "Hệ thống đào tạo CNTT BKAP";
            this.trvClass.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.trvClass.SelectedImageIndex = 0;
            this.trvClass.Size = new System.Drawing.Size(224, 391);
            this.trvClass.TabIndex = 0;
            this.trvClass.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvClass_AfterSelect);
            // 
            // lstStudent
            // 
            this.lstStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstStudent.FullRowSelect = true;
            this.lstStudent.GridLines = true;
            this.lstStudent.LargeImageList = this.imgIcon;
            this.lstStudent.Location = new System.Drawing.Point(3, 3);
            this.lstStudent.Name = "lstStudent";
            this.lstStudent.Size = new System.Drawing.Size(567, 321);
            this.lstStudent.SmallImageList = this.imgIcon;
            this.lstStudent.TabIndex = 0;
            this.lstStudent.UseCompatibleStateImageBehavior = false;
            this.lstStudent.View = System.Windows.Forms.View.Details;
            this.lstStudent.Click += new System.EventHandler(this.lstStudent_Click);
            // 
            // imgIcon
            // 
            this.imgIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcon.ImageStream")));
            this.imgIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcon.Images.SetKeyName(0, "home.png");
            this.imgIcon.Images.SetKeyName(1, "group_32.png");
            this.imgIcon.Images.SetKeyName(2, "user.png");
            this.imgIcon.Images.SetKeyName(3, "user_female.png");
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã số";
            this.columnHeader1.Width = 103;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ và tên";
            this.columnHeader2.Width = 128;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày sinh";
            this.columnHeader3.Width = 146;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Địa chỉ";
            this.columnHeader4.Width = 136;
            // 
            // rdoLarge
            // 
            this.rdoLarge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoLarge.AutoSize = true;
            this.rdoLarge.Location = new System.Drawing.Point(30, 348);
            this.rdoLarge.Name = "rdoLarge";
            this.rdoLarge.Size = new System.Drawing.Size(52, 17);
            this.rdoLarge.TabIndex = 1;
            this.rdoLarge.TabStop = true;
            this.rdoLarge.Text = "Large";
            this.rdoLarge.UseVisualStyleBackColor = true;
            this.rdoLarge.Click += new System.EventHandler(this.rdoLarge_Click);
            // 
            // rdoDetail
            // 
            this.rdoDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoDetail.AutoSize = true;
            this.rdoDetail.Location = new System.Drawing.Point(121, 348);
            this.rdoDetail.Name = "rdoDetail";
            this.rdoDetail.Size = new System.Drawing.Size(52, 17);
            this.rdoDetail.TabIndex = 2;
            this.rdoDetail.TabStop = true;
            this.rdoDetail.Text = "Detail";
            this.rdoDetail.UseVisualStyleBackColor = true;
            this.rdoDetail.Click += new System.EventHandler(this.rdoDetail_Click);
            // 
            // rdoList
            // 
            this.rdoList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoList.AutoSize = true;
            this.rdoList.Location = new System.Drawing.Point(228, 348);
            this.rdoList.Name = "rdoList";
            this.rdoList.Size = new System.Drawing.Size(41, 17);
            this.rdoList.TabIndex = 3;
            this.rdoList.TabStop = true;
            this.rdoList.Text = "List";
            this.rdoList.UseVisualStyleBackColor = true;
            this.rdoList.Click += new System.EventHandler(this.rdoList_Click);
            // 
            // rdoSmall
            // 
            this.rdoSmall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoSmall.AutoSize = true;
            this.rdoSmall.Location = new System.Drawing.Point(335, 348);
            this.rdoSmall.Name = "rdoSmall";
            this.rdoSmall.Size = new System.Drawing.Size(50, 17);
            this.rdoSmall.TabIndex = 4;
            this.rdoSmall.TabStop = true;
            this.rdoSmall.Text = "Small";
            this.rdoSmall.UseVisualStyleBackColor = true;
            this.rdoSmall.Click += new System.EventHandler(this.rdoSmall_Click);
            // 
            // rdoTile
            // 
            this.rdoTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoTile.AutoSize = true;
            this.rdoTile.Location = new System.Drawing.Point(443, 348);
            this.rdoTile.Name = "rdoTile";
            this.rdoTile.Size = new System.Drawing.Size(42, 17);
            this.rdoTile.TabIndex = 5;
            this.rdoTile.TabStop = true;
            this.rdoTile.Text = "Tile";
            this.rdoTile.UseVisualStyleBackColor = true;
            this.rdoTile.Click += new System.EventHandler(this.rdoTile_Click);
            // 
            // FrmListViewTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 391);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmListViewTreeView";
            this.Text = "FrmListViewTreeView";
            this.Load += new System.EventHandler(this.FrmListViewTreeView_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView trvClass;
        private System.Windows.Forms.ListView lstStudent;
        private System.Windows.Forms.ImageList imgIcon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.RadioButton rdoTile;
        private System.Windows.Forms.RadioButton rdoSmall;
        private System.Windows.Forms.RadioButton rdoList;
        private System.Windows.Forms.RadioButton rdoDetail;
        private System.Windows.Forms.RadioButton rdoLarge;
    }
}