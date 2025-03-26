using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace _0306231316_DoMinhNhat
{
    public partial class WinformQLSV : Form
    {
        private string ChuoiKN = "Data Source=.\\sqlexpress01;Initial Catalog=QLSinhVien;Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand com = null;
        List<LopOBJ> dsLop;
        List<SinhVienOBJ> dsSinhVien;
        public WinformQLSV()
        {
            InitializeComponent();
        }
        //private void WinformQLSV_Load(object sender, EventArgs e)
        //{
        //    LoadDSLop();
        //    dgvQLSV.AutoGenerateColumns = false;
        //    LoadDSSV();
        //}
        //private void LoadDSLop()
        //{
        //    conn = new SqlConnection(ChuoiKN);
        //    conn.Open();
        //    string selectLop = "select * from Lop";
        //    com = new SqlCommand(selectLop, conn);
        //    dsLop = new List<LopOBJ>();
        //    SqlDataReader dr = com.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        LopOBJ lop = new LopOBJ();
        //        lop.MaLop = int.Parse(dr["MaLop"].ToString());
        //        lop.TenLop = dr["TenLop"].ToString();
        //        dsLop.Add(lop);
        //    }
        //    cbLop.DataSource = dsLop;
        //    cbLop.DisplayMember = "TenLop";
        //    cbLop.ValueMember = "MaLop";
        //    colLop.DataSource = dsLop;
        //    colLop.DisplayMember = "TenLop";
        //    colLop.ValueMember = "MaLop";
        //    dr.Close();
        //    conn.Close();
        //}
        //private void LoadDSSV()
        //{
        //    conn = new SqlConnection(ChuoiKN);
        //    conn.Open();
        //    string selectSinhVien = "select * from SinhVien where TrangThai= 1"; // bằng 0 tức là đã xóa mềm
        //    com = new SqlCommand(selectSinhVien, conn);
        //    dsSinhVien = new List<SinhVienOBJ>();
        //    SqlDataReader dr = com.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        SinhVienOBJ sv = new SinhVienOBJ();
        //        sv.ID = int.Parse(dr["ID"].ToString());
        //        sv.MSSV = dr["MSSV"].ToString();
        //        sv.Ho = dr["Ho"].ToString();
        //        sv.Ten = dr["Ten"].ToString();
        //        sv.DiaChi = dr["DiaChi"].ToString();
        //        sv.Lop = int.Parse(dr["Lop"].ToString());
        //        sv.NgaySinh = DateTime.Parse(dr["NgaySinh"].ToString());
        //        sv.TrangThai = 1;
        //        dsSinhVien.Add(sv);
        //    }
        //    dgvQLSV.DataSource = dsSinhVien;
        //    dr.Close();
        //    conn.Close();
        //}

        private SqlDataAdapter daSV = new SqlDataAdapter();
        private DataSet dsQLSV = new DataSet();
        private SqlDataAdapter daLop;
        private void WinformQLSV_Load(object sender, EventArgs e)
        {
            LoadDSLop();
            dgvQLSV.AutoGenerateColumns = false;//ko phát sinh cột ngoài thiết kế giao diện ban đầu
            daSV = new SqlDataAdapter("Select * From SinhVien Where TrangThai = 1", ChuoiKN);
            SqlCommandBuilder scb = new SqlCommandBuilder(daSV);
            // dataAdapter sinh viên có thể cập nhật dữ liệu
            //Tuỳ chỉnh lại lệnh insert cho dataAdapter Sinh viên khi thêm vào trạng thái = 1
            SqlCommand insCommand = new SqlCommand();
            insCommand.CommandText = "Insert Into SinhVien(MSSV, Ho, Ten, Lop, DiaChi, NgaySinh, TrangThai) values(@MSSV, @Ho, @Ten, @Lop, @DiaChi, @NgaySinh, 1)";
            insCommand.Parameters.Add("@MSSV", SqlDbType.NVarChar, 10, "MSSV");
            insCommand.Parameters.Add("@Ho", SqlDbType.NVarChar, 50, "Ho");
            insCommand.Parameters.Add("@Ten", SqlDbType.NVarChar, 50, "Ten");
            insCommand.Parameters.Add("@Lop", SqlDbType.Int, 10, "Lop");
            insCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 1000, "DiaChi"); insCommand.Parameters.Add("@NgaySinh", SqlDbType.Date, 20, "NgaySinh");
            daSV.InsertCommand = insCommand;
            LoadDSSV();
        }
        private void LoadDSSV()
        {
            if (dsQLSV.Tables["tblSinhVien"] != null)
            {
                dsQLSV.Tables["tblSinhVien"].Clear();
            }
            daSV.Fill(dsQLSV, "tblSinhVien");
            dgvQLSV.DataSource = dsQLSV.Tables["tblSinhVien"];
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dsQLSV.Tables["tblSinhVien"].GetChanges() != null)
            {
                daSV.Update(dsQLSV.Tables["tblSinhVien"]);
                LoadDSSV();
            }
        }
        private void LoadDSLop()
        {
            daLop = new SqlDataAdapter("Select * From Lop", ChuoiKN);
            daLop.Fill(dsQLSV, "tblLop");
            cbLop.DataSource = dsQLSV.Tables["tblLop"];
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaLop";
            colLop.DataSource = dsQLSV.Tables["tblLop"];
            colLop.DisplayMember = "TenLop";
            colLop.ValueMember = "MaLop";
        }
    }
}
