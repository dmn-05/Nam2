namespace _0306231316_DoMinhNhat_Buoi7
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateNS = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bntEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkHD = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lvwView = new System.Windows.Forms.ListView();
            this.taikhoan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hoten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaysinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gioitinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trangthai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkHD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radNu);
            this.groupBox1.Controls.Add(this.radNam);
            this.groupBox1.Controls.Add(this.btnReload);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.bntEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.dateNS);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTK);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(129, 34);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(217, 22);
            this.txtTK.TabIndex = 1;
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(129, 66);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(217, 22);
            this.txtHT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh";
            // 
            // dateNS
            // 
            this.dateNS.Location = new System.Drawing.Point(129, 98);
            this.dateNS.Name = "dateNS";
            this.dateNS.Size = new System.Drawing.Size(217, 22);
            this.dateNS.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.ImageIndex = 3;
            this.btnAdd.ImageList = this.imageList1;
            this.btnAdd.Location = new System.Drawing.Point(429, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 45);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bntEdit
            // 
            this.bntEdit.ImageIndex = 1;
            this.bntEdit.ImageList = this.imageList1;
            this.bntEdit.Location = new System.Drawing.Point(429, 64);
            this.bntEdit.Name = "bntEdit";
            this.bntEdit.Size = new System.Drawing.Size(45, 45);
            this.bntEdit.TabIndex = 7;
            this.bntEdit.UseVisualStyleBackColor = true;
            this.bntEdit.Click += new System.EventHandler(this.bntEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageIndex = 2;
            this.btnDelete.ImageList = this.imageList1;
            this.btnDelete.Location = new System.Drawing.Point(429, 116);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 45);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReload
            // 
            this.btnReload.ImageIndex = 0;
            this.btnReload.ImageList = this.imageList1;
            this.btnReload.Location = new System.Drawing.Point(429, 167);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(45, 45);
            this.btnReload.TabIndex = 9;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.Location = new System.Drawing.Point(129, 134);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(57, 20);
            this.radNam.TabIndex = 10;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(243, 134);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(45, 20);
            this.radNu.TabIndex = 11;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Trạng thái";
            // 
            // chkHD
            // 
            this.chkHD.AutoSize = true;
            this.chkHD.Checked = true;
            this.chkHD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHD.Location = new System.Drawing.Point(129, 170);
            this.chkHD.Name = "chkHD";
            this.chkHD.Size = new System.Drawing.Size(92, 20);
            this.chkHD.TabIndex = 14;
            this.chkHD.Text = "Hoạt động";
            this.chkHD.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "loading-arrow.png");
            this.imageList1.Images.SetKeyName(1, "edit.png");
            this.imageList1.Images.SetKeyName(2, "delete.png");
            this.imageList1.Images.SetKeyName(3, "plus.png");
            // 
            // lvwView
            // 
            this.lvwView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.taikhoan,
            this.hoten,
            this.ngaysinh,
            this.gioitinh,
            this.trangthai});
            this.lvwView.HideSelection = false;
            this.lvwView.Location = new System.Drawing.Point(25, 296);
            this.lvwView.Name = "lvwView";
            this.lvwView.Size = new System.Drawing.Size(559, 166);
            this.lvwView.TabIndex = 1;
            this.lvwView.UseCompatibleStateImageBehavior = false;
            this.lvwView.View = System.Windows.Forms.View.Details;
            this.lvwView.SelectedIndexChanged += new System.EventHandler(this.lvwView_SelectedIndexChanged);
            // 
            // taikhoan
            // 
            this.taikhoan.Text = "Tài khoản";
            this.taikhoan.Width = 122;
            // 
            // hoten
            // 
            this.hoten.Text = "Họ tên";
            this.hoten.Width = 121;
            // 
            // ngaysinh
            // 
            this.ngaysinh.Text = "Ngày sinh";
            this.ngaysinh.Width = 128;
            // 
            // gioitinh
            // 
            this.gioitinh.Text = "Giới tính";
            // 
            // trangthai
            // 
            this.trangthai.Text = "Trạng thái";
            this.trangthai.Width = 131;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 489);
            this.Controls.Add(this.lvwView);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Quản lý tài khoản";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button bntEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dateNS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkHD;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView lvwView;
        private System.Windows.Forms.ColumnHeader taikhoan;
        private System.Windows.Forms.ColumnHeader hoten;
        private System.Windows.Forms.ColumnHeader ngaysinh;
        private System.Windows.Forms.ColumnHeader gioitinh;
        private System.Windows.Forms.ColumnHeader trangthai;
    }
}

