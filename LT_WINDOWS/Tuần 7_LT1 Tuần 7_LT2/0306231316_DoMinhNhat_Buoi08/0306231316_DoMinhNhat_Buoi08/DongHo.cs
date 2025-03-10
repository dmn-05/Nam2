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
    public partial class DongHo : Form
    {
        public DongHo()
        {
            InitializeComponent();
        }

     
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now; // thời gian hiện tại
            int s = dt.Second; // lấy giây 
            int h = dt.Hour;
            int m = dt.Minute;
            //hh/pp/ss
            int s1 = s / 10; // số hàng chục của giây
            int s2 = s % 10; // số hàng đơn vị của giây
            int h1 = h / 10;
            int h2 = h % 10;
            int m1 = m / 10;
            int m2 = m % 10;
            pbS1.Image = imageList1.Images[s1];
            pbS2.Image = imageList1.Images[s2];
            pbH1.Image = imageList1.Images[h1];
            pbH2.Image = imageList1.Images[h2];
            pbM1.Image = imageList1.Images[m1];
            pbM2.Image = imageList1.Images[m2];
        }
    
    }
}

