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

namespace _0306231316_DoMinhNhat
{
    public partial class frmQLSV : Form
    {
        private string ChuoiKN = "Data Source=LAPTOP-F8I3O6B7\\SQLEXPRESS01;Initial Catalog=QLSinhVien;Integrated Security=True";
        private SqlDataAdapter dtaLop;
        private SqlDataAdapter dtaSV;
        DataSet dsSV = new DataSet();
        private void frmQLSV_Load(object sender, EventArgs e)
        {
            LoadDSLop();
            string select = "Select * from SinhVien where TrangThai = 1";
            dtaSV = new SqlDataAdapter(select, ChuoiKN);
            SqlCommandBuilder scb = new SqlCommandBuilder(dtaSV);
            LoadDSSV();
        }
        public frmQLSV()
        {
            InitializeComponent();
            dgvDSSV.AutoGenerateColumns = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadDSLop()
        {
            string select = "Select * From Lop";
            dtaLop = new SqlDataAdapter(select, ChuoiKN);
            dtaLop.Fill(dsSV, "tbLop");
            cbLH.DataSource = dsSV.Tables["tbLop"];
            cbLH.DisplayMember = "TenLop";
            cbLH.ValueMember = "MaLop";

            colLH.DataSource = dsSV.Tables["tbLop"].Copy();
            colLH.DisplayMember = "TenLop";
            colLH.ValueMember = "MaLop";
        }
        private void LoadDSSV()
        {
            if (dsSV.Tables["tbSinhVien"] != null)
            {
                dsSV.Tables["tbSinhVien"].Clear();
            }
            dtaSV.Fill(dsSV, "tbSinhVien");
            dgvDSSV.DataSource = dsSV.Tables["tbSinhVien"];
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dsSV.Tables["tbSinhVien"].GetChanges() != null)
            {
                dtaSV.Update(dsSV, "tbSinhVien");
                LoadDSSV();
            }
        }
    }
}
