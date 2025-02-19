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
    public partial class UCLN : Form
    {
        public UCLN()
        {
            InitializeComponent();
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Hay nhap so: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtS1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Hay nhap so: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            int.TryParse(txtA.Text, out a);
            int.TryParse(txtB.Text, out b);

            for (int i = a>b?b:a; i > 0; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    txtKQ.Text = i.ToString();
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKQ.Clear();
            txtA.Focus();
        }
    }
}
