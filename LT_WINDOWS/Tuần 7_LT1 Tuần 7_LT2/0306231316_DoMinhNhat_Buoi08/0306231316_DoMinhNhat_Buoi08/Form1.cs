using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0306231316_DoMinhNhat_Buoi08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cbDT.SelectedIndex = 0;
        }

        private void txtHT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != '\b') {
                MessageBox.Show("Vui long nhap chu!", "canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/'  && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            if ((txtNS.TextLength != 2 && txtNS.TextLength != 5) && e.KeyChar == '/')
            {
                e.Handled = true;
                return;
            }

            if ((txtNS.TextLength == 2 || txtNS.TextLength == 5) && e.KeyChar != '/')
            {
                e.Handled = true;
                return;
            }
            if (txtNS.TextLength == 10)
            {
                e.Handled = true;
                return;
            }

        }


        private void btnXemTT_Click(object sender, EventArgs e)
        {
            tabTTCN.SelectedIndex = 1;
            lblHT.Text = txtHT.Text;
            lblNS.Text = txtNS.Text;
            lblDT.Text = cbDT.Text;
            GioiTinh();
            HonNhan();
            NgoaiNgu();
            KyNang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtThem.Text))
            {
                MessageBox.Show("Hay nhap thong day du!", "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!chkb_KN.Items.Contains(txtThem.Text))
                {
                    chkb_KN.Items.Add(txtThem.Text);
                    chkb_KN.SetItemChecked(chkb_KN.Items.Count - 1, true);
                    txtThem.Clear();
                }
                else
                {
                    MessageBox.Show("Da co ngon ngu nay!", "Canh Bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }
        public void GioiTinh()
        {
            lblGT.Text = radNam.Checked ? "Nam" : "Nữ";
        }
        public void HonNhan()
        {
            foreach (Control control in gbHN.Controls)
            {
                if (control is RadioButton rad && rad.Checked)
                {
                    lblHN.Text = rad.Text;
                    break;
                }
            }
        }
        public void NgoaiNgu()
        {
            string NgoaiNgu = "";
            if (chkAnh.Checked)
            {
                NgoaiNgu += chkAnh.Text + " ";
            }
            if (chkHoa.Checked)
            {
                NgoaiNgu += chkHoa.Text + " ";
            }
            if (chkPhap.Checked)
            {
                NgoaiNgu += chkPhap.Text + " ";
            }
            lblNN.Text = NgoaiNgu;
        }
        public void KyNang()
        {
            foreach (Object ob in chkb_KN.CheckedItems)
            {
                string text = ob.ToString();
                txtKN.Text += text + ", ";
            }
        }

        private void txtNS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
