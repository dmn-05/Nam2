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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Hay nhap so: ","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Hay nhap so: ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNum1.Text) || string.IsNullOrWhiteSpace(txtNum2.Text))
            {
                MessageBox.Show("Hãy nhập đủ số", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                int num1 = 0;
                int num2 = 0;
                int Tong = 0;
                int Hieu = 0;
                double Tich = 0;
                double Thuong = 0;

                int.TryParse(txtNum1.Text, out num1);
                int.TryParse(txtNum2.Text, out num2);
                Tong = num1 + num2;
                Hieu = num1 - num2;
                Tich = num1 * num2;
                lblTong.Text = Tong.ToString();
                lblHieu.Text = Hieu.ToString();
                lblTich.Text = Tich.ToString();
                if (num2 == 0)
                {
                    lblThuong.Text = "Khong Thuc Hien Duoc";
                    lblThuong.ForeColor = Color.Red;
                }
                else
                {
                    lblThuong.ForeColor = lblTong.ForeColor;
                    Thuong = (double) num1 / num2;
                    lblThuong.Text = Thuong.ToString();
                }
            }
        }
    }
}
