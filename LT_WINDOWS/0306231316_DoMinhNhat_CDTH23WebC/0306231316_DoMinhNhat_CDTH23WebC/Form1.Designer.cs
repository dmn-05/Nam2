namespace _0306231316_DoMinhNhat_CDTH23WebC
{
    partial class FrmQLLH
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
            this.grp_N = new System.Windows.Forms.GroupBox();
            this.lblHT = new System.Windows.Forms.Label();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.txtToan = new System.Windows.Forms.TextBox();
            this.lblToan = new System.Windows.Forms.Label();
            this.txtVan = new System.Windows.Forms.TextBox();
            this.lblVan = new System.Windows.Forms.Label();
            this.txtAnhVan = new System.Windows.Forms.TextBox();
            this.lblAnhVan = new System.Windows.Forms.Label();
            this.lbl_Heading = new System.Windows.Forms.Label();
            this.lbl_DTB = new System.Windows.Forms.Label();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.lbl_XL = new System.Windows.Forms.Label();
            this.txtXL = new System.Windows.Forms.TextBox();
            this.grp_Diem = new System.Windows.Forms.GroupBox();
            this.grp_LH = new System.Windows.Forms.GroupBox();
            this.txtSHSLL = new System.Windows.Forms.TextBox();
            this.lblSHSLL = new System.Windows.Forms.Label();
            this.txtSLHS = new System.Windows.Forms.TextBox();
            this.lblSLHS = new System.Windows.Forms.Label();
            this.btnNHS = new System.Windows.Forms.Button();
            this.btnXDLH = new System.Windows.Forms.Button();
            this.btnXemDSG = new System.Windows.Forms.Button();
            this.btnTLHM = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grp_N.SuspendLayout();
            this.grp_Diem.SuspendLayout();
            this.grp_LH.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_N
            // 
            this.grp_N.Controls.Add(this.txtAnhVan);
            this.grp_N.Controls.Add(this.lblAnhVan);
            this.grp_N.Controls.Add(this.txtVan);
            this.grp_N.Controls.Add(this.lblVan);
            this.grp_N.Controls.Add(this.txtToan);
            this.grp_N.Controls.Add(this.lblToan);
            this.grp_N.Controls.Add(this.txtHT);
            this.grp_N.Controls.Add(this.lblHT);
            this.grp_N.Location = new System.Drawing.Point(34, 58);
            this.grp_N.Name = "grp_N";
            this.grp_N.Size = new System.Drawing.Size(500, 157);
            this.grp_N.TabIndex = 0;
            this.grp_N.TabStop = false;
            this.grp_N.Text = "Nhập thông tin Học Sinh";
            this.grp_N.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblHT
            // 
            this.lblHT.AutoSize = true;
            this.lblHT.Location = new System.Drawing.Point(117, 43);
            this.lblHT.Name = "lblHT";
            this.lblHT.Size = new System.Drawing.Size(42, 13);
            this.lblHT.TabIndex = 0;
            this.lblHT.Text = "Họ tên:";
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(177, 43);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(237, 20);
            this.txtHT.TabIndex = 1;
            // 
            // txtToan
            // 
            this.txtToan.Location = new System.Drawing.Point(177, 69);
            this.txtToan.Name = "txtToan";
            this.txtToan.Size = new System.Drawing.Size(237, 20);
            this.txtToan.TabIndex = 3;
            this.txtToan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToan_KeyPress);
            // 
            // lblToan
            // 
            this.lblToan.AutoSize = true;
            this.lblToan.Location = new System.Drawing.Point(124, 69);
            this.lblToan.Name = "lblToan";
            this.lblToan.Size = new System.Drawing.Size(35, 13);
            this.lblToan.TabIndex = 2;
            this.lblToan.Text = "Toán:";
            // 
            // txtVan
            // 
            this.txtVan.Location = new System.Drawing.Point(177, 97);
            this.txtVan.Name = "txtVan";
            this.txtVan.Size = new System.Drawing.Size(237, 20);
            this.txtVan.TabIndex = 5;
            this.txtVan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVan_KeyPress);
            // 
            // lblVan
            // 
            this.lblVan.AutoSize = true;
            this.lblVan.Location = new System.Drawing.Point(130, 97);
            this.lblVan.Name = "lblVan";
            this.lblVan.Size = new System.Drawing.Size(29, 13);
            this.lblVan.TabIndex = 4;
            this.lblVan.Text = "Văn:";
            // 
            // txtAnhVan
            // 
            this.txtAnhVan.Location = new System.Drawing.Point(177, 123);
            this.txtAnhVan.Name = "txtAnhVan";
            this.txtAnhVan.Size = new System.Drawing.Size(237, 20);
            this.txtAnhVan.TabIndex = 7;
            this.txtAnhVan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnhVan_KeyPress);
            // 
            // lblAnhVan
            // 
            this.lblAnhVan.AutoSize = true;
            this.lblAnhVan.Location = new System.Drawing.Point(108, 123);
            this.lblAnhVan.Name = "lblAnhVan";
            this.lblAnhVan.Size = new System.Drawing.Size(51, 13);
            this.lblAnhVan.TabIndex = 6;
            this.lblAnhVan.Text = "Anh Văn:";
            // 
            // lbl_Heading
            // 
            this.lbl_Heading.AutoSize = true;
            this.lbl_Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Heading.ForeColor = System.Drawing.Color.Red;
            this.lbl_Heading.Location = new System.Drawing.Point(206, 19);
            this.lbl_Heading.Name = "lbl_Heading";
            this.lbl_Heading.Size = new System.Drawing.Size(400, 25);
            this.lbl_Heading.TabIndex = 1;
            this.lbl_Heading.Text = "CHƯƠNG TRÌNH QUẢN LÝ LỚP HỌC";
            // 
            // lbl_DTB
            // 
            this.lbl_DTB.AutoSize = true;
            this.lbl_DTB.Location = new System.Drawing.Point(108, 43);
            this.lbl_DTB.Name = "lbl_DTB";
            this.lbl_DTB.Size = new System.Drawing.Size(51, 13);
            this.lbl_DTB.TabIndex = 0;
            this.lbl_DTB.Text = "Điểm TB:";
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(177, 43);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.ReadOnly = true;
            this.txtDTB.Size = new System.Drawing.Size(237, 20);
            this.txtDTB.TabIndex = 1;
            // 
            // lbl_XL
            // 
            this.lbl_XL.AutoSize = true;
            this.lbl_XL.Location = new System.Drawing.Point(111, 72);
            this.lbl_XL.Name = "lbl_XL";
            this.lbl_XL.Size = new System.Drawing.Size(48, 13);
            this.lbl_XL.TabIndex = 2;
            this.lbl_XL.Text = "Xếp loại:";
            // 
            // txtXL
            // 
            this.txtXL.Location = new System.Drawing.Point(177, 69);
            this.txtXL.Name = "txtXL";
            this.txtXL.ReadOnly = true;
            this.txtXL.Size = new System.Drawing.Size(237, 20);
            this.txtXL.TabIndex = 3;
            // 
            // grp_Diem
            // 
            this.grp_Diem.Controls.Add(this.txtXL);
            this.grp_Diem.Controls.Add(this.lbl_XL);
            this.grp_Diem.Controls.Add(this.txtDTB);
            this.grp_Diem.Controls.Add(this.lbl_DTB);
            this.grp_Diem.Location = new System.Drawing.Point(34, 234);
            this.grp_Diem.Name = "grp_Diem";
            this.grp_Diem.Size = new System.Drawing.Size(500, 109);
            this.grp_Diem.TabIndex = 8;
            this.grp_Diem.TabStop = false;
            this.grp_Diem.Text = "Điểm học sinh";
            // 
            // grp_LH
            // 
            this.grp_LH.Controls.Add(this.txtSHSLL);
            this.grp_LH.Controls.Add(this.lblSHSLL);
            this.grp_LH.Controls.Add(this.txtSLHS);
            this.grp_LH.Controls.Add(this.lblSLHS);
            this.grp_LH.Location = new System.Drawing.Point(34, 367);
            this.grp_LH.Name = "grp_LH";
            this.grp_LH.Size = new System.Drawing.Size(500, 111);
            this.grp_LH.TabIndex = 9;
            this.grp_LH.TabStop = false;
            this.grp_LH.Text = "Lớp học";
            // 
            // txtSHSLL
            // 
            this.txtSHSLL.Location = new System.Drawing.Point(177, 69);
            this.txtSHSLL.Name = "txtSHSLL";
            this.txtSHSLL.ReadOnly = true;
            this.txtSHSLL.Size = new System.Drawing.Size(237, 20);
            this.txtSHSLL.TabIndex = 3;
            // 
            // lblSHSLL
            // 
            this.lblSHSLL.AutoSize = true;
            this.lblSHSLL.Location = new System.Drawing.Point(56, 69);
            this.lblSHSLL.Name = "lblSHSLL";
            this.lblSHSLL.Size = new System.Drawing.Size(103, 13);
            this.lblSHSLL.TabIndex = 2;
            this.lblSHSLL.Text = "Số học sinh lên lớp: ";
            this.lblSHSLL.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSLHS
            // 
            this.txtSLHS.Location = new System.Drawing.Point(177, 43);
            this.txtSLHS.Name = "txtSLHS";
            this.txtSLHS.ReadOnly = true;
            this.txtSLHS.Size = new System.Drawing.Size(237, 20);
            this.txtSLHS.TabIndex = 1;
            // 
            // lblSLHS
            // 
            this.lblSLHS.AutoSize = true;
            this.lblSLHS.Location = new System.Drawing.Point(89, 46);
            this.lblSLHS.Name = "lblSLHS";
            this.lblSLHS.Size = new System.Drawing.Size(70, 13);
            this.lblSLHS.TabIndex = 0;
            this.lblSLHS.Text = "Số lượng HS:";
            // 
            // btnNHS
            // 
            this.btnNHS.Location = new System.Drawing.Point(579, 87);
            this.btnNHS.Name = "btnNHS";
            this.btnNHS.Size = new System.Drawing.Size(126, 34);
            this.btnNHS.TabIndex = 10;
            this.btnNHS.Text = "Nhập HS";
            this.btnNHS.UseVisualStyleBackColor = true;
            this.btnNHS.Click += new System.EventHandler(this.btnNHS_Click);
            // 
            // btnXDLH
            // 
            this.btnXDLH.Location = new System.Drawing.Point(579, 155);
            this.btnXDLH.Name = "btnXDLH";
            this.btnXDLH.Size = new System.Drawing.Size(126, 34);
            this.btnXDLH.TabIndex = 11;
            this.btnXDLH.Text = "Xem Điểm Lớp học";
            this.btnXDLH.UseVisualStyleBackColor = true;
            this.btnXDLH.Click += new System.EventHandler(this.btnXDLH_Click);
            // 
            // btnXemDSG
            // 
            this.btnXemDSG.Location = new System.Drawing.Point(579, 208);
            this.btnXemDSG.Name = "btnXemDSG";
            this.btnXemDSG.Size = new System.Drawing.Size(126, 34);
            this.btnXemDSG.TabIndex = 12;
            this.btnXemDSG.Text = "Xem DS HS Giỏi";
            this.btnXemDSG.UseVisualStyleBackColor = true;
            this.btnXemDSG.Click += new System.EventHandler(this.btnXemDSG_Click);
            // 
            // btnTLHM
            // 
            this.btnTLHM.Location = new System.Drawing.Point(579, 269);
            this.btnTLHM.Name = "btnTLHM";
            this.btnTLHM.Size = new System.Drawing.Size(126, 34);
            this.btnTLHM.TabIndex = 13;
            this.btnTLHM.Text = "Tạo Lớp Học Mới";
            this.btnTLHM.UseVisualStyleBackColor = true;
            this.btnTLHM.Click += new System.EventHandler(this.btnTLHM_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(579, 436);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(126, 34);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmQLLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTLHM);
            this.Controls.Add(this.btnXemDSG);
            this.Controls.Add(this.btnXDLH);
            this.Controls.Add(this.btnNHS);
            this.Controls.Add(this.grp_LH);
            this.Controls.Add(this.grp_Diem);
            this.Controls.Add(this.lbl_Heading);
            this.Controls.Add(this.grp_N);
            this.Name = "FrmQLLH";
            this.Text = "0306231316_DoMinhNhat";
            this.grp_N.ResumeLayout(false);
            this.grp_N.PerformLayout();
            this.grp_Diem.ResumeLayout(false);
            this.grp_Diem.PerformLayout();
            this.grp_LH.ResumeLayout(false);
            this.grp_LH.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_N;
        private System.Windows.Forms.TextBox txtAnhVan;
        private System.Windows.Forms.Label lblAnhVan;
        private System.Windows.Forms.TextBox txtVan;
        private System.Windows.Forms.Label lblVan;
        private System.Windows.Forms.TextBox txtToan;
        private System.Windows.Forms.Label lblToan;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.Label lblHT;
        private System.Windows.Forms.Label lbl_Heading;
        private System.Windows.Forms.Label lbl_DTB;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.Label lbl_XL;
        private System.Windows.Forms.TextBox txtXL;
        private System.Windows.Forms.GroupBox grp_Diem;
        private System.Windows.Forms.GroupBox grp_LH;
        private System.Windows.Forms.TextBox txtSHSLL;
        private System.Windows.Forms.Label lblSHSLL;
        private System.Windows.Forms.TextBox txtSLHS;
        private System.Windows.Forms.Label lblSLHS;
        private System.Windows.Forms.Button btnNHS;
        private System.Windows.Forms.Button btnXDLH;
        private System.Windows.Forms.Button btnXemDSG;
        private System.Windows.Forms.Button btnTLHM;
        private System.Windows.Forms.Button btnThoat;
    }
}

