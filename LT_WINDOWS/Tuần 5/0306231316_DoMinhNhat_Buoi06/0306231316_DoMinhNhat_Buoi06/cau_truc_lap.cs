using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0306231316_DoMinhNhat_Buoi06
{
    public partial class cau_truc_lap : Form
    {
        public cau_truc_lap()
        {
            InitializeComponent();
        }

        private void cau_truc_lap_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            int.TryParse(txtN.Text, out n);

            double S1 = 0;
            double S2 = 0;
            double S3 = 0;
            double S4 = 0;

            for (int i = 1; i <= n; i++)
            {
                S1 += i;
                S2 += i * i;
                S3 += (double)1 / i;
                if (i % 2 != 0) { 
                    S4 += i;
                }
            }

            txtS1.Text = S1.ToString();
            txtS2.Text = S2.ToString();
            txtS3.Text = S3.ToString();
            txtS4.Text = S4.ToString();

        }
    }
}
