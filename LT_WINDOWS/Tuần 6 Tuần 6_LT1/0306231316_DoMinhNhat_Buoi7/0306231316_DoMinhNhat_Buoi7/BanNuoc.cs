using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _0306231316_DoMinhNhat_Buoi7
{
    public partial class BanNuoc : Form
    {
        public int TongSL;
        public double TongTien;
        public double TrungBinh;
        public BanNuoc()
        {
            InitializeComponent();
            TongSL = 0;
            TongTien = 0;
            TrungBinh = 0;
        }

        private void btnBanMoi_Click(object sender, EventArgs e)
        {
            txt_N_HD.Clear();
            txt_N_SL.Clear();
            txt_N_TT.Clear();
            txt_TK_TT.Clear();
            txt_TK_TSL.Clear();
            txt_TK_TB.Clear();
            radBia.Checked = false;
            radCFD.Checked = false;
            radCPS.Checked = false;
            radRedbull.Checked = false;
            chkMuaVe.Checked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void txt_N_SL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Hay Nhap So: ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txt_N_HD_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void radCFD_CheckedChanged(object sender, EventArgs e)
        {
            txt_N_HD.Text = "Cà phê đá";
        }

        private void radCPS_CheckedChanged(object sender, EventArgs e)
        {
            txt_N_HD.Text = "Cà phê sữa";
        }

        private void radBia_CheckedChanged(object sender, EventArgs e)
        {
            txt_N_HD.Text = "Bia";
        }

        private void radRedbull_CheckedChanged(object sender, EventArgs e)
        {
            txt_N_HD.Text = "Redbull";
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {

           
            if ( string.IsNullOrWhiteSpace(txt_N_SL.Text) || string.IsNullOrWhiteSpace(txt_N_HD.Text))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double DonGia = 0;
                int SL = int.Parse(txt_N_SL.Text);
                double ThanhTien;
                if (radCFD.Checked)
                {
                    DonGia = 5000;
                }
                else if (radCPS.Checked)
                {
                    DonGia = 7000;
                }
                else if (radBia.Checked)
                {
                    DonGia = 11000;
                }
                else if (radRedbull.Checked)
                {
                    DonGia = 8000;
                }

                if (chkMuaVe.Checked)
                {
                    ThanhTien = (SL * DonGia) * 1.05;
                }
                else
                {
                    ThanhTien = DonGia * SL;
                }
                txt_N_TT.Text = ThanhTien.ToString();

                TongSL += SL;
                TongTien += ThanhTien;
                TrungBinh = TongTien / TongSL;
            }
        }
        private void btnXemTK_Click(object sender, EventArgs e)
        {
            txt_TK_TSL.Text = TongSL.ToString();
            txt_TK_TT.Text = TongSL.ToString();
            txt_TK_TB.Text = TrungBinh.ToString();
        }
    }
}
