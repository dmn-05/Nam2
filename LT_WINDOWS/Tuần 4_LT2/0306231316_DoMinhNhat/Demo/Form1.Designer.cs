namespace Demo
{
    partial class Frm1
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_MSSV = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(288, 145);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(52, 16);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Ho Ten";
            // 
            // lbl_MSSV
            // 
            this.lbl_MSSV.AutoSize = true;
            this.lbl_MSSV.Location = new System.Drawing.Point(291, 198);
            this.lbl_MSSV.Name = "lbl_MSSV";
            this.lbl_MSSV.Size = new System.Drawing.Size(45, 16);
            this.lbl_MSSV.TabIndex = 1;
            this.lbl_MSSV.Text = "MSSV";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(294, 247);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(50, 16);
            this.lbl_address.TabIndex = 2;
            this.lbl_address.Text = "Dia Chi";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(403, 145);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(167, 22);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(403, 241);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(167, 22);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(403, 192);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(167, 22);
            this.txtMSSV.TabIndex = 5;
            this.txtMSSV.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 549);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_MSSV);
            this.Controls.Add(this.lbl_Name);
            this.Name = "Frm1";
            this.Text = "Thông Tin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_MSSV;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMSSV;
    }
}

