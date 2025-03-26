namespace _0306231316_DoMinhNhat
{
    partial class Form3
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
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("Món khai vị");
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("Món nướng");
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("Món lẩu");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("Món tráng miệng");
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("Món ăn", new System.Windows.Forms.TreeNode[] {
            treeNode91,
            treeNode92,
            treeNode93,
            treeNode94});
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("Bia");
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("Nước ngọt");
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("Khác");
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("Thức uống", new System.Windows.Forms.TreeNode[] {
            treeNode96,
            treeNode97,
            treeNode98});
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("Tất cả", new System.Windows.Forms.TreeNode[] {
            treeNode95,
            treeNode99});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lvwDoAn = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.radDetail = new System.Windows.Forms.RadioButton();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.radList = new System.Windows.Forms.RadioButton();
            this.TenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MoTa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(12, 37);
            this.treeView1.Name = "treeView1";
            treeNode91.Name = "MonKhaiVi";
            treeNode91.Text = "Món khai vị";
            treeNode92.Name = "MonNuong";
            treeNode92.Text = "Món nướng";
            treeNode93.Name = "MonLau";
            treeNode93.Text = "Món lẩu";
            treeNode94.Name = "MonTrangMieng";
            treeNode94.Text = "Món tráng miệng";
            treeNode95.Name = "MonAn";
            treeNode95.Text = "Món ăn";
            treeNode96.Name = "Bia";
            treeNode96.Text = "Bia";
            treeNode97.Name = "NuocNgot";
            treeNode97.Text = "Nước ngọt";
            treeNode98.Name = "Khac";
            treeNode98.Text = "Khác";
            treeNode99.Name = "ThucUong";
            treeNode99.Text = "Thức uống";
            treeNode100.Name = "TatCa";
            treeNode100.Text = "Tất cả";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode100});
            this.treeView1.Size = new System.Drawing.Size(246, 492);
            this.treeView1.TabIndex = 0;
            // 
            // lvwDoAn
            // 
            this.lvwDoAn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TenSP,
            this.Gia,
            this.MoTa});
            this.lvwDoAn.HideSelection = false;
            this.lvwDoAn.Location = new System.Drawing.Point(264, 37);
            this.lvwDoAn.Name = "lvwDoAn";
            this.lvwDoAn.Size = new System.Drawing.Size(536, 492);
            this.lvwDoAn.TabIndex = 1;
            this.lvwDoAn.UseCompatibleStateImageBehavior = false;
            this.lvwDoAn.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblLoai);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(806, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 492);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết sản phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radList);
            this.groupBox2.Controls.Add(this.radSmall);
            this.groupBox2.Controls.Add(this.radLarge);
            this.groupBox2.Controls.Add(this.radDetail);
            this.groupBox2.Location = new System.Drawing.Point(264, 547);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 95);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(821, 547);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 43);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm sản phẩm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(950, 547);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 43);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa sản phẩm";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1079, 547);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(113, 43);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Sửa sản phẩm";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // radDetail
            // 
            this.radDetail.AutoSize = true;
            this.radDetail.Location = new System.Drawing.Point(27, 42);
            this.radDetail.Name = "radDetail";
            this.radDetail.Size = new System.Drawing.Size(63, 20);
            this.radDetail.TabIndex = 0;
            this.radDetail.TabStop = true;
            this.radDetail.Text = "Detail";
            this.radDetail.UseVisualStyleBackColor = true;
            // 
            // radLarge
            // 
            this.radLarge.AutoSize = true;
            this.radLarge.Location = new System.Drawing.Point(120, 41);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(63, 20);
            this.radLarge.TabIndex = 1;
            this.radLarge.TabStop = true;
            this.radLarge.Text = "Large";
            this.radLarge.UseVisualStyleBackColor = true;
            // 
            // radSmall
            // 
            this.radSmall.AutoSize = true;
            this.radSmall.Location = new System.Drawing.Point(217, 42);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(62, 20);
            this.radSmall.TabIndex = 2;
            this.radSmall.TabStop = true;
            this.radSmall.Text = "Small";
            this.radSmall.UseVisualStyleBackColor = true;
            // 
            // radList
            // 
            this.radList.AutoSize = true;
            this.radList.Location = new System.Drawing.Point(315, 42);
            this.radList.Name = "radList";
            this.radList.Size = new System.Drawing.Size(48, 20);
            this.radList.TabIndex = 3;
            this.radList.TabStop = true;
            this.radList.Text = "List";
            this.radList.UseVisualStyleBackColor = true;
            // 
            // TenSP
            // 
            this.TenSP.Text = "Tên sản phẩm";
            this.TenSP.Width = 140;
            // 
            // Gia
            // 
            this.Gia.Text = "Giá (VND)";
            this.Gia.Width = 96;
            // 
            // MoTa
            // 
            this.MoTa.Text = "Mô tả sản phẩm";
            this.MoTa.Width = 292;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(99, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 116);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(22, 219);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(124, 20);
            this.lblLoai.TabIndex = 1;
            this.lblLoai.Text = "Loại sản phẩm:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 27);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(159, 273);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 27);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên món:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(159, 324);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(189, 27);
            this.textBox4.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giá:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(159, 375);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(189, 94);
            this.textBox3.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chi tiết:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 658);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvwDoAn);
            this.Controls.Add(this.treeView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView lvwDoAn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.RadioButton radList;
        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.RadioButton radDetail;
        private System.Windows.Forms.ColumnHeader TenSP;
        private System.Windows.Forms.ColumnHeader Gia;
        private System.Windows.Forms.ColumnHeader MoTa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}