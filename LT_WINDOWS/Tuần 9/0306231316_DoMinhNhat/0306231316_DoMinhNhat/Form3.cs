using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _0306231316_DoMinhNhat
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lvwDoAn.View = View.Details;
            lvwDoAn.GridLines = true;
            lvwDoAn.FullRowSelect = true;
            string[,] sanPham = {
                { "Cà phê sữa", "15,000", "Hương vị thơm ngon của chúng tôi" },
                { "Nước trái cây", "25,000", "Nước ép nguyên chất từ trái cây tươi" },
                { "Món khai vị", "50,000", "Ngoài ra, cửa hàng còn phục vụ các món ăn Việt Nam." },
                { "Heineken", "25,000", "Bia Heineken xuất xứ từ Hà Lan" },
                { "Lẩu cá kèo", "100,000", "Lẩu cá kèo của cửa hàng với nguyên liệu tươi sống" },
                { "Bạch tuộc nướng", "45,000", "Món bạch tuộc nướng hấp dẫn với gia vị cay" },
                { "Coca cola", "15,000", "Nước giải khát coca cola" },
                { "Thạch trái cây", "25,000", "Món thạch trái cây thơm ngon bổ dưỡng" }
            };

            for (int i = 0; i < sanPham.GetLength(0); i++)
            {
                ListViewItem item = new ListViewItem(sanPham[i, 0]);
                item.SubItems.Add(sanPham[i, 1]);
                item.SubItems.Add(sanPham[i, 2]);

                lvwDoAn.Items.Add(item);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Mở hình ảnh";
            opf.Filter = "Ảnh (*.png;*.jpg|*.png;*.jpg)";
        }
    }
}
