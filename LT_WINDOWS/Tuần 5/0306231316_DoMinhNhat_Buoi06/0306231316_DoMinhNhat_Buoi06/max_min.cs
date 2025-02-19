using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0306231316_DoMinhNhat_Buoi06
{
    public partial class max_min : Form
    {
        public max_min()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtA.Text) || string.IsNullOrWhiteSpace(txtB.Text))
            {
                MessageBox.Show("Hãy nhập đủ số", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                int numA = 0;
                int numB = 0;

                int.TryParse(txtA.Text, out numA);
                int.TryParse(txtB.Text, out numB);

                if (numA > numB)
                {
                    txtsln.Text = numA.ToString();
                    txtsnn.Text = numB.ToString();
                }
                else 
                {
                    txtsln.Text = numB.ToString();
                    txtsnn.Text = numA.ToString();
                }
            }
        }
        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Hay nhap so: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Hay nhap so: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
