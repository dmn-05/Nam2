using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0306231316_DoMinhNhat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Vui lòng chỉ nhập số!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled |= true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool exists = false;
            foreach (ListViewItem item in lvwDSNV.Items)
            {
                if (item.Text == txtHT.Text) // So sánh với cột đầu tiên (Text)
                {
                    exists = true;
                    break;
                }
            }
            if (string.IsNullOrWhiteSpace(txtHT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ListViewItem item = new ListViewItem(txtHT.Text);
                item.SubItems.Add(dateNS.Value.ToLongDateString());
                item.SubItems.Add(txtDT.Text);
                item.SubItems.Add(txtDC.Text);
                if (exists)
                {
                    MessageBox.Show("Đã có nhân viên này", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    lvwDSNV.Items.Add(item);
                }
            }
            txtHT.Clear();
            txtDC.Clear();
            txtDT.Clear();
            dateNS.Value = DateTime.Now;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvwDSNV.SelectedItems.Count > 0)
            {
                ListViewItem lv = lvwDSNV.SelectedItems[0];
                lv.SubItems[0].Text = txtHT.Text;
                lv.SubItems[1].Text = dateNS.Value.ToLongDateString();
                lv.SubItems[2].Text = txtDT.Text;
                lv.SubItems[3].Text = txtDC.Text;
            }
            else
            {
                MessageBox.Show(
                    "Cần chọn để sửa",
                    "Thông báo"
                );
            }
        }

        private void lvwDSNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDSNV.SelectedItems.Count > 0)
            {
                ListViewItem slItem = lvwDSNV.SelectedItems[0];
                txtHT.Text = slItem.Text; // Tương đương subitem[0]
                DateTime dt;
                DateTime.TryParse(slItem.SubItems[1].Text, out dt);
                txtDT.Text = slItem.SubItems[2].Text;
                txtDC.Text = slItem.SubItems[3].Text;
                
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(lvwDSNV.SelectedItems.Count > 0)
            {
                ListViewItem lv = lvwDSNV.SelectedItems[0];
                lvwDSNV.Items.Remove(lv);
            }
            else
            {
                MessageBox.Show(
                    "Cần chọn để sửa",
                    "Thông báo"
                );
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                this.Close();
            }
        }

        private void btnUpIMG_Click(object sender, EventArgs e)
        {
            OpenFileDialog _openFileDialog = new OpenFileDialog();
            _openFileDialog.Title = "Chọn ảnh";

            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbIMG.Image = new Bitmap(_openFileDialog.FileName);
            }
        }
    }
}
