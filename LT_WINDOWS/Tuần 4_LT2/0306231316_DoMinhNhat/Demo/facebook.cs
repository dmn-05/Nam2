using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class facebook : Form
    {
        public facebook()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if(txtUser.Text == "Email Address")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
            
        }

        private void facebook_Load(object sender, EventArgs e)
        {
            txtUser.Text = "Email Address";
            txtUser.ForeColor = Color.Gray;
            txtPass.Text = "Password";
            txtPass.ForeColor = Color.Gray;

            txtPass.Select(0, 0);
            txtUser.Select(0, 0);
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
            }
        }
    }
}
