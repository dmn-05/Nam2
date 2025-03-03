namespace _0306231316_DoMinhNhat
{
    partial class add_name
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
            this.cbitem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.ListName = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbitem
            // 
            this.cbitem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbitem.FormattingEnabled = true;
            this.cbitem.Location = new System.Drawing.Point(94, 160);
            this.cbitem.Name = "cbitem";
            this.cbitem.Size = new System.Drawing.Size(121, 24);
            this.cbitem.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "First name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 53);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add Name";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(479, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 53);
            this.button2.TabIndex = 10;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(286, 160);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(128, 22);
            this.txtFN.TabIndex = 11;
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(458, 160);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(127, 22);
            this.txtLN.TabIndex = 12;
            // 
            // ListName
            // 
            this.ListName.FormattingEnabled = true;
            this.ListName.ItemHeight = 16;
            this.ListName.Location = new System.Drawing.Point(94, 214);
            this.ListName.Name = "ListName";
            this.ListName.Size = new System.Drawing.Size(491, 84);
            this.ListName.TabIndex = 13;
            // 
            // add_name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 353);
            this.Controls.Add(this.ListName);
            this.Controls.Add(this.txtLN);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbitem);
            this.Name = "add_name";
            this.Text = "add name";
            this.Load += new System.EventHandler(this.add_name_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbitem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.ListBox ListName;
    }
}

