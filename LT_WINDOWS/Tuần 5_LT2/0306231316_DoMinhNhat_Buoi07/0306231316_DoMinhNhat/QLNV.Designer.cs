namespace _0306231316_DoMinhNhat
{
    partial class QLNV
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPhong = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbNC = new System.Windows.Forms.ListBox();
            this.lbQL = new System.Windows.Forms.ListBox();
            this.btnR = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnallL = new System.Windows.Forms.Button();
            this.btnallR = new System.Windows.Forms.Button();
            this.cbCV = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(242, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 22);
            this.txtName.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Chức Vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Họ Tên NV";
            // 
            // cbPhong
            // 
            this.cbPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Items.AddRange(new object[] {
            "Nguyên Cứu",
            "Quản Lý"});
            this.cbPhong.Location = new System.Drawing.Point(242, 133);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(170, 24);
            this.cbPhong.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 33);
            this.button1.TabIndex = 19;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(445, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 30);
            this.button2.TabIndex = 20;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbNC);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(48, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 214);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phòng Nguyên Cứu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbQL);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(423, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 214);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phòng Quản Lý";
            // 
            // lbNC
            // 
            this.lbNC.FormattingEnabled = true;
            this.lbNC.ItemHeight = 16;
            this.lbNC.Location = new System.Drawing.Point(19, 35);
            this.lbNC.Name = "lbNC";
            this.lbNC.Size = new System.Drawing.Size(155, 164);
            this.lbNC.TabIndex = 0;
            // 
            // lbQL
            // 
            this.lbQL.FormattingEnabled = true;
            this.lbQL.ItemHeight = 16;
            this.lbQL.Location = new System.Drawing.Point(22, 35);
            this.lbQL.Name = "lbQL";
            this.lbQL.Size = new System.Drawing.Size(155, 164);
            this.lbQL.TabIndex = 1;
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(273, 214);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(59, 30);
            this.btnR.TabIndex = 26;
            this.btnR.Text = ">";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(292, 330);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(88, 33);
            this.btndelete.TabIndex = 25;
            this.btndelete.Text = "Xóa";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(338, 214);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(59, 30);
            this.btnL.TabIndex = 28;
            this.btnL.Text = "<";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnallL
            // 
            this.btnallL.Location = new System.Drawing.Point(338, 271);
            this.btnallL.Name = "btnallL";
            this.btnallL.Size = new System.Drawing.Size(59, 30);
            this.btnallL.TabIndex = 30;
            this.btnallL.Text = "<<";
            this.btnallL.UseVisualStyleBackColor = true;
            this.btnallL.Click += new System.EventHandler(this.btnallL_Click);
            // 
            // btnallR
            // 
            this.btnallR.Location = new System.Drawing.Point(273, 268);
            this.btnallR.Name = "btnallR";
            this.btnallR.Size = new System.Drawing.Size(59, 33);
            this.btnallR.TabIndex = 29;
            this.btnallR.Text = ">>";
            this.btnallR.UseVisualStyleBackColor = true;
            this.btnallR.Click += new System.EventHandler(this.btnallR_Click);
            // 
            // cbCV
            // 
            this.cbCV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCV.FormattingEnabled = true;
            this.cbCV.Items.AddRange(new object[] {
            "Giám Đốc",
            "Thư Kí",
            "Trưởng Phòng",
            "Nhân Viên",
            "Bảo Vệ",
            "Lao Công",
            "Hút Bồn Cầu"});
            this.cbCV.Location = new System.Drawing.Point(242, 84);
            this.cbCV.Name = "cbCV";
            this.cbCV.Size = new System.Drawing.Size(170, 24);
            this.cbCV.TabIndex = 31;
            // 
            // QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.cbCV);
            this.Controls.Add(this.btnallL);
            this.Controls.Add(this.btnallR);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPhong);
            this.Name = "QLNV";
            this.Text = "Quản Lý Thông Tin Nhân VIên";
            this.Load += new System.EventHandler(this.QLNV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbNC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbQL;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnallL;
        private System.Windows.Forms.Button btnallR;
        private System.Windows.Forms.ComboBox cbCV;
    }
}