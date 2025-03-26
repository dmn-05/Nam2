namespace _0306231316_DoMinhNhat
{
    partial class frmQLSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLSV));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLH = new System.Windows.Forms.ComboBox();
            this.radLop = new System.Windows.Forms.RadioButton();
            this.btnSearch_HT = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radHT = new System.Windows.Forms.RadioButton();
            this.btnSearch_MSSV = new System.Windows.Forms.Button();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.radMSSV = new System.Windows.Forms.RadioButton();
            this.radTatca = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSSV = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLH);
            this.groupBox1.Controls.Add(this.radLop);
            this.groupBox1.Controls.Add(this.btnSearch_HT);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.radHT);
            this.groupBox1.Controls.Add(this.btnSearch_MSSV);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.radMSSV);
            this.groupBox1.Controls.Add(this.radTatca);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(281, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // cbLH
            // 
            this.cbLH.FormattingEnabled = true;
            this.cbLH.Location = new System.Drawing.Point(513, 85);
            this.cbLH.Name = "cbLH";
            this.cbLH.Size = new System.Drawing.Size(205, 28);
            this.cbLH.TabIndex = 8;
            // 
            // radLop
            // 
            this.radLop.AutoSize = true;
            this.radLop.Location = new System.Drawing.Point(419, 86);
            this.radLop.Name = "radLop";
            this.radLop.Size = new System.Drawing.Size(67, 24);
            this.radLop.TabIndex = 7;
            this.radLop.TabStop = true;
            this.radLop.Text = "Lớp:";
            this.radLop.UseVisualStyleBackColor = true;
            // 
            // btnSearch_HT
            // 
            this.btnSearch_HT.ImageIndex = 1;
            this.btnSearch_HT.ImageList = this.imageList1;
            this.btnSearch_HT.Location = new System.Drawing.Point(724, 24);
            this.btnSearch_HT.Name = "btnSearch_HT";
            this.btnSearch_HT.Size = new System.Drawing.Size(30, 30);
            this.btnSearch_HT.TabIndex = 6;
            this.btnSearch_HT.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Save-icon.png");
            this.imageList1.Images.SetKeyName(1, "SearchIcon.png");
            this.imageList1.Images.SetKeyName(2, "StudentIcon.png");
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(513, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(205, 27);
            this.textBox2.TabIndex = 5;
            // 
            // radHT
            // 
            this.radHT.AutoSize = true;
            this.radHT.Location = new System.Drawing.Point(419, 26);
            this.radHT.Name = "radHT";
            this.radHT.Size = new System.Drawing.Size(97, 24);
            this.radHT.TabIndex = 4;
            this.radHT.TabStop = true;
            this.radHT.Text = "Họ Tên:";
            this.radHT.UseVisualStyleBackColor = true;
            // 
            // btnSearch_MSSV
            // 
            this.btnSearch_MSSV.ImageIndex = 1;
            this.btnSearch_MSSV.ImageList = this.imageList1;
            this.btnSearch_MSSV.Location = new System.Drawing.Point(339, 84);
            this.btnSearch_MSSV.Name = "btnSearch_MSSV";
            this.btnSearch_MSSV.Size = new System.Drawing.Size(30, 30);
            this.btnSearch_MSSV.TabIndex = 3;
            this.btnSearch_MSSV.UseVisualStyleBackColor = true;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(127, 86);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(205, 27);
            this.txtMSSV.TabIndex = 2;
            // 
            // radMSSV
            // 
            this.radMSSV.AutoSize = true;
            this.radMSSV.Location = new System.Drawing.Point(33, 86);
            this.radMSSV.Name = "radMSSV";
            this.radMSSV.Size = new System.Drawing.Size(87, 24);
            this.radMSSV.TabIndex = 1;
            this.radMSSV.TabStop = true;
            this.radMSSV.Text = "MSSV:";
            this.radMSSV.UseVisualStyleBackColor = true;
            // 
            // radTatca
            // 
            this.radTatca.AutoSize = true;
            this.radTatca.Location = new System.Drawing.Point(33, 37);
            this.radTatca.Name = "radTatca";
            this.radTatca.Size = new System.Drawing.Size(83, 24);
            this.radTatca.TabIndex = 0;
            this.radTatca.TabStop = true;
            this.radTatca.Text = "Tất cả";
            this.radTatca.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::_0306231316_DoMinhNhat.Properties.Resources.StudentIcon;
            this.pictureBox1.Location = new System.Drawing.Point(71, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 156);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(459, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // dgvDSSV
            // 
            this.dgvDSSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colMSSV,
            this.colH,
            this.colT,
            this.colNS,
            this.colLH,
            this.colDC});
            this.dgvDSSV.Location = new System.Drawing.Point(25, 231);
            this.dgvDSSV.Name = "dgvDSSV";
            this.dgvDSSV.RowHeadersWidth = 51;
            this.dgvDSSV.RowTemplate.Height = 24;
            this.dgvDSSV.Size = new System.Drawing.Size(1068, 319);
            this.dgvDSSV.TabIndex = 3;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            // 
            // colMSSV
            // 
            this.colMSSV.DataPropertyName = "MSSV";
            this.colMSSV.HeaderText = "MSSV";
            this.colMSSV.MinimumWidth = 6;
            this.colMSSV.Name = "colMSSV";
            // 
            // colH
            // 
            this.colH.DataPropertyName = "Ho";
            this.colH.HeaderText = "Họ";
            this.colH.MinimumWidth = 6;
            this.colH.Name = "colH";
            // 
            // colT
            // 
            this.colT.DataPropertyName = "Ten";
            this.colT.HeaderText = "Tên";
            this.colT.MinimumWidth = 6;
            this.colT.Name = "colT";
            // 
            // colNS
            // 
            this.colNS.DataPropertyName = "NgaySinh";
            this.colNS.HeaderText = "Ngày sinh";
            this.colNS.MinimumWidth = 6;
            this.colNS.Name = "colNS";
            // 
            // colLH
            // 
            this.colLH.DataPropertyName = "Lop";
            this.colLH.HeaderText = "Lớp học";
            this.colLH.MinimumWidth = 6;
            this.colLH.Name = "colLH";
            this.colLH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colDC
            // 
            this.colDC.DataPropertyName = "DiaChi";
            this.colDC.HeaderText = "Địa chỉ";
            this.colDC.MinimumWidth = 6;
            this.colDC.Name = "colDC";
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(975, 566);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(118, 55);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "     Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 633);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvDSSV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmQLSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.frmQLSV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radTatca;
        private System.Windows.Forms.RadioButton radMSSV;
        private System.Windows.Forms.Button btnSearch_MSSV;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.ComboBox cbLH;
        private System.Windows.Forms.RadioButton radLop;
        private System.Windows.Forms.Button btnSearch_HT;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radHT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSSV;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNS;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDC;
    }
}

