using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0306231316_DoMinhNhat_Buoi06
{
    public partial class max_min_slnhi : Form
    {
        public max_min_slnhi()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
            {
                MessageBox.Show("Hay nhap so: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            if (e.KeyChar == '-' && txtA.SelectionStart != 0)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtA.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
            {
                MessageBox.Show("Hay nhap so: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            if (e.KeyChar == '-' && txtA.SelectionStart != 0)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtA.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
            {
                MessageBox.Show("Hay nhap so: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            if (e.KeyChar == '-' && txtA.SelectionStart != 0)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtA.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            double c = 0;

            double.TryParse(txtA.Text, out a);
            double.TryParse(txtB.Text, out b);
            double.TryParse(txtC.Text, out c);

            double max = Math.Max(a, Math.Max(b, c));
            double min = Math.Min(a, Math.Min(b, c));
            double median = a + b + c - max - min;


            txtsln.Text = max.ToString();
            txtsnn.Text = min.ToString();
            txtslnhi.Text = median.ToString();
            txtslnhi.Text = median.ToString();
        }
    }
}
