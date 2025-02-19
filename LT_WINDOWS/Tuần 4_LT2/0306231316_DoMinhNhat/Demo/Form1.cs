using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text;
            text = ((TextBox)sender).Text;
            ((TextBox)sender).Text = text.ToUpper();
            txtName.SelectionStart = text.Length;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string text;
            text = ((TextBox)sender).Text;
            ((TextBox)sender).Text = text.ToUpper();
            txtMSSV.SelectionStart = text.Length;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string text;
            text = ((TextBox)sender).Text;
            ((TextBox)sender).Text = text.ToUpper();
            txtAddress.SelectionStart = text.Length;
        }
    }
}
