using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0306231316_DoMinhNhat
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            long DungLuongRAM = 0;
            // Tên máy tính
            lblname.Text = Environment.MachineName.ToString();
            // Lấy dung lượng bộ nhớ RAM
            ManagementObjectSearcher searcher = new ManagementObjectSearcher
            ("SELECT * FROM Win32_Computersystem"); foreach (ManagementObject obj in searcher.Get())
            {
                DungLuongRAM = long.Parse(obj["TotalPhysicalMemory"].ToString());
                DungLuongRAM = DungLuongRAM / (1024 * 1024);
            }
            lblram.Text = DungLuongRAM.ToString() + " MB";

            // Tên CPU
            string sCPUName = "";
            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher
            ("SELECT * FROM Win32_Processor"); foreach (ManagementObject obj in searcher2.Get())
            {
                sCPUName = obj["Name"].ToString();
            }
            lblcpu.Text = sCPUName;

            // Thông tin đĩa cứng (HDD) string sHDDName = "";
            string sHDDName = "";
            float sHDDSize = 0;
            ManagementObjectSearcher searcher3 = new ManagementObjectSearcher
            ("SELECT * FROM Win32_DiskDrive"); foreach (ManagementObject obj in searcher3.Get())
            {
                foreach (PropertyData pd in obj.Properties)
                {
                    if (pd.Name == "Model")
                    {
                        sHDDName = pd.Value.ToString();
                    }
                    if (pd.Name == "Size")
                    {
                        string size = pd.Value.ToString(); // byte
                        sHDDSize = float.Parse(size) / (1024 * 1024 * 1024); //GB
                    }
                }
            }
            lblhdd.Text = sHDDName + " - Size: " + sHDDSize.ToString() + " GB";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát!", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
