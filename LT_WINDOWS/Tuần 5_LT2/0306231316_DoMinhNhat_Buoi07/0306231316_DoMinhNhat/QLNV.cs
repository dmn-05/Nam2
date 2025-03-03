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

namespace _0306231316_DoMinhNhat
{
    public partial class QLNV : Form
    {
        public QLNV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbPhong.SelectedIndex < 0 || cbCV.SelectedIndex < 0 || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string item = txtName.Text;
                if (lbNC.Items.Contains(item) || lbQL.Items.Contains(item))
                {
                    MessageBox.Show("Đã có thông tin này");
                }
                else
                {
                    if (cbPhong.SelectedItem.ToString() == "Nguyên Cứu")
                    {
                        lbNC.Items.Add(item);
                    }
                    else
                    {
                        lbQL.Items.Add(item);
                    }
                }
                txtName.Clear();        
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void btnR_Click(object sender, EventArgs e)
        {
            if (lbNC.SelectedItems.Count >= 0)
            {
                lbQL.Items.Add(lbNC.SelectedItem);
                lbNC.Items.Remove(lbNC.SelectedItem);
            }
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            if (lbQL.SelectedItems.Count >= 0)
            {
                lbNC.Items.Add(lbQL.SelectedItem);
                lbQL.Items.Remove(lbQL.SelectedItem);
            }
        }

        private void btnallR_Click(object sender, EventArgs e)
        { 
            foreach (var item in lbNC.Items) // 4 5 6
            {
                lbQL.Items.Add(item);
            }
            lbNC.Items.Clear();
        }

        private void btnallL_Click(object sender, EventArgs e)
        {
            foreach (var item in lbQL.Items) // 4 5 6
            {
                lbNC.Items.Add(item);
            }
            lbQL.Items.Clear();

        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            lbQL.Items.Add("1");
            lbQL.Items.Add("2");
            lbQL.Items.Add("3");

            lbNC.Items.Add("4");
            lbNC.Items.Add("5");
            lbNC.Items.Add("6");

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (lbQL.SelectedItems.Count >= 0 && lbQL.SelectedItem != null)
            {
                lbQL.Items.Remove(lbQL.SelectedItem);
            }
            if (lbNC.SelectedItems.Count >= 0 && lbNC.SelectedItem != null)
            {
                lbNC.Items.Remove(lbNC.SelectedItem);
            }
        }
    }
}
