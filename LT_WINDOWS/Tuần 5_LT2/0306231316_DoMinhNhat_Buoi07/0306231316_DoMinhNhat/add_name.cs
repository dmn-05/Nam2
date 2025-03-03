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
    public partial class add_name : Form
    {
        public add_name()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbitem.SelectedIndex < 0 || string.IsNullOrWhiteSpace(txtFN.Text) || string.IsNullOrWhiteSpace(txtLN.Text))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Cảnh Báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                string item = $"{cbitem.SelectedItem.ToString()} {txtFN.Text} {txtLN.Text}";
                if (ListName.Items.Contains(item))
                {
                    MessageBox.Show("Đã có thông tin này","Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    ListName.Items.Add(item);
                }
                txtFN.Clear();
                txtLN.Clear();
            }
        }

        private void add_name_Load(object sender, EventArgs e)
        {
            cbitem.Items.Add("Dr");
            cbitem.Items.Add("Mr");
            cbitem.Items.Add("Mrs");
            cbitem.Items.Add("Miss");

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
    }
}
