using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        string strChuoiKetNoi = "Data Source=LAPTOP-F8I3O6B7\\SQLEXPRESS01;Initial Catalog=DemoDB;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMSSV.Text))
            {
                string insert = "INSERT INTO SINH_VIEN(MSSV, HoTen, NgaySinh, GioiTinh, DiemTB) " +
                                "VALUES(@MSSV, @HoTen, @NgaySinh, @GioiTinh, @DiemTB)";

                using (SqlConnection conn = new SqlConnection(strChuoiKetNoi))
                {
                    conn.Open();
                    using (SqlCommand com = new SqlCommand(insert, conn))
                    {
                        com.Parameters.AddWithValue("@MSSV", txtMSSV.Text);
                        com.Parameters.AddWithValue("@HoTen", txtName.Text);
                        com.Parameters.AddWithValue("@NgaySinh", dateNS.Value);
                        com.Parameters.AddWithValue("@GioiTinh", radNam.Checked ? 1 : 0);
                        com.Parameters.AddWithValue("@DiemTB", numDTB.Value);

                        if (com.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show($"Đã thêm sinh viên {txtMSSV.Text} thành công");
                        }
                        else
                        {
                            MessageBox.Show("Thêm sinh viên thất bại!");
                        }
                    }
                }
                txtMSSV.Clear();
                txtName.Clear();
                radNam.Checked = true;
                numDTB.Value = 5;
                DateTime NgayMacDinh = DateTime.Today.AddYears(-18);
                dateNS.Text = NgayMacDinh.ToString();

            }
            else
            {
                MessageBox.Show("Hãy nhập mã số sinh viên");
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMSSV.Text))
            {
                string insert = "UPDATE SINH_VIEN " +
                                "SET Hoten = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiemTB = @DiemTB " +
                                "WHERE MSSV = @MSSV";

                using (SqlConnection conn = new SqlConnection(strChuoiKetNoi))
                {
                    conn.Open();
                    using (SqlCommand com = new SqlCommand(insert, conn))
                    {
                        com.Parameters.AddWithValue("@MSSV", txtMSSV.Text);
                        com.Parameters.AddWithValue("@HoTen", txtName.Text);
                        com.Parameters.AddWithValue("@NgaySinh", dateNS.Value);
                        com.Parameters.AddWithValue("@GioiTinh", radNam.Checked ? 1 : 0);
                        com.Parameters.AddWithValue("@DiemTB", numDTB.Value);

                        if (com.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show($"Đã cập nhật sinh viên {txtMSSV.Text} thành công");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật sinh viên thất bại!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập mã số sinh viên");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMSSV.Text) && !string.IsNullOrWhiteSpace(txtName.Text))
            {
                string insert = "DELETE FROM SINH_VIEN " +
                                "WHERE MSSV = @MSSV";

                using (SqlConnection conn = new SqlConnection(strChuoiKetNoi))
                {
                    conn.Open();
                    using (SqlCommand com = new SqlCommand(insert, conn))
                    {
                        com.Parameters.AddWithValue("@MSSV", txtMSSV.Text);

                        if (com.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show($"Đã xóa sinh viên {txtMSSV.Text} thành công");
                        }
                        else
                        {
                            MessageBox.Show("Xóa sinh viên thất bại!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
        }

        private void btnSLTV_Click(object sender, EventArgs e)
        {

            string insert = "SELECT count(*) FROM SINH_VIEN ";
                           

            using (SqlConnection conn = new SqlConnection(strChuoiKetNoi))
            {
                conn.Open();
                using (SqlCommand com = new SqlCommand(insert, conn))
                {
                    if ((int)com.ExecuteScalar() > 0)
                    {
                        MessageBox.Show($"Lớp có {com.ExecuteScalar()} sinh viên");
                    }
                    else
                    {
                        MessageBox.Show("Không có sinh viên nào!");
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radNam.Checked = true;
            numDTB.Value = 5;
            DateTime NgayMacDinh = DateTime.Today.AddYears(-18);
            dateNS.Text = NgayMacDinh.ToString();
        }

        private void txtMSSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập số!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && txtMSSV.Text.Length >= 10)
            {
                e.Handled = true;
            }
        }
        private void txtMSSV_Leave(object sender, EventArgs e)
        {
            if (txtMSSV.Text.Length != 10)
            {
                MessageBox.Show("vui lòng nhập đủ 10 ký tự!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMSSV.Focus();                
            }
           
            string mssv = txtMSSV.Text.Trim(); 
            if (string.IsNullOrEmpty(mssv)) return;

            string query = "SELECT HoTen, NgaySinh, GioiTinh, DiemTB FROM SINH_VIEN WHERE MSSV = @MSSV";

            using (SqlConnection conn = new SqlConnection(strChuoiKetNoi))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MSSV", mssv);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read()) 
                    {
                        txtName.Text = reader["HoTen"].ToString();
                        dateNS.Value = Convert.ToDateTime(reader["NgaySinh"]);
                        bool gioiTinh = Convert.ToBoolean(reader["GioiTinh"]);
                        radNam.Checked = gioiTinh;
                        radNu.Checked = !gioiTinh;
        
                        numDTB.Value = Convert.ToDecimal(reader["DiemTB"]);
                    }
                    else 
                    {
                       
                    }
                }
            }
            

        }

        private void dateNS_Leave(object sender, EventArgs e)
        {
            int namht = DateTime.Now.Year;
            int namsinh = dateNS.Value.Year;
            if (namht - namsinh < 18)
            {
                MessageBox.Show("Bạn chưa đủ 18 tuổi!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateNS.Focus();
            }
        }

        private void numDTB_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
