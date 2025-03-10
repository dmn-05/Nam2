using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0306231316_DoMinhNhat_CDTH23WebC
{
    public partial class FrmQLLH : Form
    {
        public string bangdiem = "";
        public int slhs = 0;
        public int sohslenlop = 0;
        public int hsgioi = 0;
        public string dshsgioi = "";
        public FrmQLLH()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNHS_Click(object sender, EventArgs e)
        {
            string HT, xeploai;
            double Toan, Van, Anh, diemtb;
            if (string.IsNullOrWhiteSpace(txtHT.Text) ||
                string.IsNullOrWhiteSpace(txtToan.Text)||
                string.IsNullOrWhiteSpace(txtVan.Text)||
                string.IsNullOrWhiteSpace(txtAnhVan.Text))
            {
                MessageBox.Show(
                    "Hay Nhap day du thong tin",
                    "Cảnh Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                HT = txtHT.Text;
                Toan = double.Parse(txtToan.Text);
                Van = double.Parse(txtVan.Text);
                Anh = double.Parse(txtAnhVan.Text);
                slhs++;
                diemtb = (Toan + Anh + Van) / 3;
                if (diemtb < 5)
                {
                    xeploai = "Yếu";
                }
                else if (diemtb < 6)
                {
                    xeploai = "Trung Bình";
                    sohslenlop++;
                }
                else if (diemtb < 7)
                {
                    xeploai = "Trung Bình - Khá";
                    sohslenlop++;
                }
                else if (diemtb < 8)
                {
                    sohslenlop++;
                    xeploai = "Khá";
                }
                else
                {
                    sohslenlop++;
                    xeploai = "Giỏi";
                    hsgioi++;
                    dshsgioi = dshsgioi + "\nHọ Tên: " + HT.ToString();
                    dshsgioi = dshsgioi + "\nĐiểm TB: " + diemtb.ToString();
                    dshsgioi = dshsgioi + "\nXếp Loại: " + xeploai.ToString();
                    dshsgioi = dshsgioi + "\n------------------------";
                }
                txtDTB.Text = diemtb.ToString();
                txtXL.Text = xeploai.ToString();
                txtSLHS.Text = slhs.ToString();
                txtSHSLL.Text = sohslenlop.ToString();
                bangdiem = bangdiem +  "\nHọ Tên: " + HT.ToString();
                bangdiem = bangdiem +  "\nĐiểm TB: " + diemtb.ToString();
                bangdiem = bangdiem +  "\nXếp Loại: " + xeploai.ToString();
                bangdiem = bangdiem + "\n------------------------";
            }
        }

        private void btnTLHM_Click(object sender, EventArgs e)
        {
            txtHT.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnhVan.Clear();
            txtDTB.Clear();
            txtXL.Clear();
            txtSLHS.Clear();
            txtSHSLL.Clear();
        }

        private void txtToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.') {
                MessageBox.Show(
                   "Hay Nhap So",
                   "Cảnh Báo",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            if (e.KeyChar == '.' && txtToan.Text.Contains('.'))
            {
                e.Handled =true;
            }
        }

        private void txtVan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show(
                   "Hay Nhap So",
                   "Cảnh Báo",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            if (e.KeyChar == '.' && txtVan.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void txtAnhVan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show(
                   "Hay Nhap So",
                   "Cảnh Báo",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            if (e.KeyChar == '.' && txtAnhVan.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void btnXDLH_Click(object sender, EventArgs e)
        {
            string s;
            s = "      BẢNG ĐIỂM LỚP HỌC";
            s = s + "\n-------------------------\n";
            s = s + bangdiem;
            s = s + "\n\n===========================================\n";
            s = s + "\nSố học sinh: " + slhs.ToString();
            s = s + "\nSố học sinh lên lớp: " + sohslenlop.ToString();
            MessageBox.Show(s);
        }

        private void btnXemDSG_Click(object sender, EventArgs e)
        {
            string s;
            s = "      DANH SÁCH HỌC SINH GIỎI";
            s = s + "\n-------------------------\n";
            s = s + dshsgioi;
            s = s + "\n\n===========================================\n";
            s = s + "\nSố học sinh: " + slhs.ToString();
            s = s + "\nSố học sinh giỏi: " + hsgioi.ToString();
            MessageBox.Show(s);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ban co muon thoat? ", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.OK)
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
