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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; // Cập nhật mỗi giây
            timer.Tick += timer1_Tick;
            timer.Start();
        }
        private Label lblTime;
        private Timer timer;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime1.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
