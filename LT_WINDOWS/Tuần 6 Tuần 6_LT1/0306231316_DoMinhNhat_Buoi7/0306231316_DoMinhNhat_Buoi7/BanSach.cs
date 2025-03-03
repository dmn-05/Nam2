using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace _0306231316_DoMinhNhat_Buoi7
{
    public partial class BanSach : Form
    {
        public int tongslsach = 0;
        public double tongtkm = 0;
        public double tongtien = 0;
        public double tbtiensach = 0;
        public string HoaDon = "";
        public BanSach()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTuaSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Hay nhap so! ", "Canh Bao" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }   

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Hay nhap so! ", "Canh Bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            int soluong;
            double gia, thanhtien, khuyenmai, tienthucte;
            if (string.IsNullOrWhiteSpace(txtTuaSach.Text)||string.IsNullOrWhiteSpace(txtSL.Text)||string.IsNullOrWhiteSpace(txtGia.Text))
            {
                MessageBox.Show("Hay nhap day du thong tin! ", "Canh Bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                soluong = int.Parse(txtSL.Text);
                gia = double.Parse(txtGia.Text);
                thanhtien = soluong * gia;
                khuyenmai = (thanhtien * 0.15);
                tienthucte = thanhtien - khuyenmai;
                tongslsach += soluong;
                tongtien += tienthucte;
                tongtkm += khuyenmai;
                tbtiensach = tongtien / tongslsach;
                txtTT.Text = thanhtien.ToString();
                txtKM.Text = khuyenmai.ToString();
                txtTPT.Text = tienthucte.ToString();
                txtTSLS.Text = tongslsach.ToString();
                txtTTKM.Text = tongtkm.ToString();
                txtTTTT.Text = tongtien.ToString();
                txtTBST.Text = tbtiensach.ToString();
                HoaDon = HoaDon + "\n\nTựa sách: "+ txtTuaSach.Text;
                HoaDon = HoaDon + "\nSố lượng: " + txtSL.Text;
                HoaDon = HoaDon + "\nGiá: " + txtGia.Text;
                HoaDon = HoaDon + "\nThành tiền: " + thanhtien.ToString();
                HoaDon = HoaDon + "\nKhuyến mãi (15%): "+ khuyenmai.ToString();
                HoaDon = HoaDon + "\nSố tiền thực tế: " + tienthucte.ToString();
                HoaDon = HoaDon + "\n----------------------  ";
            }

        }

        private void btnXHD_Click(object sender, EventArgs e)
        {
            string s;
            s = "	HOÁ ĐƠN	";
            s = s + "\n	";
            s = s + HoaDon;
            s = s + "\n\n==================================";
            s = s + "\nTổng số lượng sách: " + tongslsach.ToString();
            s = s + "\nTổng tiền khuyến mãi: " +tongtkm.ToString();
            s = s + "\nTổng tiền thực tế: " + tongtien.ToString();
            s = s + "\nTrung bình: " + tbtiensach.ToString();

            MessageBox.Show(s);
        }

        private void btnTM_Click(object sender, EventArgs e)
        {
            txtTuaSach.Clear();
            txtSL.Clear();
            txtGia.Clear();
            txtTT.Clear();
            txtKM.Clear();
            txtTPT.Clear();
            txtTSLS.Clear();
            txtTTKM.Clear();
            txtTTTT.Clear();
            txtTBST.Clear();
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
    }
}
