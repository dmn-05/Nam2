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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtTK.Text) && string.IsNullOrWhiteSpace(txtHT.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin!",
                    "Cảnh Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                ListViewItem item = new ListViewItem(txtTK.Text);
                item.SubItems.Add(txtHT.Text);
                item.SubItems.Add(dateNS.Value.ToLongDateString());
                item.SubItems.Add(radNam.Checked ? "Nam" : "Nữ");
                item.SubItems.Add(chkHD.Checked ? "Hoạt Động" : "Không Hoạt Động");
                lvwView.Items.Add(item);

            }
        }

        private void bntEdit_Click(object sender, EventArgs e)
        {
            if (lvwView.SelectedItems.Count > 0)
            {
                ListViewItem lv = lvwView.SelectedItems[0];
                lv.SubItems[1].Text = txtHT.Text;
                lv.SubItems[2].Text = dateNS.Value.ToLongDateString();
                lv.SubItems[3].Text = radNam.Checked ? "Nam" : "Nữ";
                lv.SubItems[4].Text = chkHD.Checked ? "Hoạt Động" : "Không Hoạt Động";
            }
            else
            {
                MessageBox.Show(
                    "Cần chọn để sửa",
                    "Thông báo"
                );
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwView.SelectedItems.Count > 0)
            {
                ListViewItem slItem = lvwView.SelectedItems[0];
                lvwView.Items.Remove(slItem);
            }
            else
            {
                MessageBox.Show(
                    "Cần chọn để xóa",
                    "Thông báo"
                );
            }
        }

        private void lvwView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwView.SelectedItems.Count > 0)
            {
                ListViewItem slItem = lvwView.SelectedItems[0];
                txtTK.Text = slItem.Text; // Tương đương subitem[0]
                txtHT.Text = slItem.SubItems[1].Text;
                DateTime dt;
                DateTime.TryParse(slItem.SubItems[2].Text, out dt);
                dateNS.Value = dt;
                if (slItem.SubItems[3].Text == "Nam")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
                chkHD.Checked = slItem.SubItems[4].Text == "Hoạt động";
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtTK.Clear();
            txtHT.Clear();
            radNam.Checked = true;
            chkHD.Checked = true;
        }
    }
}
