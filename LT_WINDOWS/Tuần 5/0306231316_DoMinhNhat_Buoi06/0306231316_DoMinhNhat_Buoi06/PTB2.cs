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
    public partial class PTB2 : Form
    {
        public PTB2()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtA.Text) || string.IsNullOrWhiteSpace(txtB.Text))
            {
                MessageBox.Show("Hãy nhập đủ số", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                int a = 0;
                int b = 0;
                int c = 0;

                int.TryParse(txtA.Text, out a);
                int.TryParse(txtB.Text, out b);
                int.TryParse(txtC.Text, out c);

                if (a == 0)
                {
                    if (b == 0)
                    {
                        txtKQ.Text = c == 0 ? "Phương trình có vô số nghiệm" : "Phương trình vô nghiệm";
                    }
                    else
                    {
                        txtKQ.Text = "Phương trình có một nghiệm: x = " + (-c / b);
                    }
                }
                else
                {
                    double delta = b * b - 4 * a * c;
                    if (delta > 0)
                    {
                        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                        txtKQ.Text = $"Phương trình có hai nghiệm: x1 = {x1}, x2 = {x2}";                  }
                    else if (delta == 0)
                    {
                        double x = -b / (2 * a);
                        txtKQ.Text = $"Phương trình có nghiệm kép: x = {x}";
                    }
                    else
                    {
                        txtKQ.Text = "Phương trình vô nghiệm thực";
                    }
                }
            }
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
            {
                MessageBox.Show("Hay nhap so: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            if ( e.KeyChar == '-' && txtA.SelectionStart != 0)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtA.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
            {
                MessageBox.Show("Hay nhap so: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            if (e.KeyChar == '-' && txtB.SelectionStart != 0)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtB.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
            {
                MessageBox.Show("Hay nhap so: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            if (e.KeyChar == '-' && txtC.SelectionStart != 0)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtC.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtKQ.Clear();
            txtA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }
    
    }
}
