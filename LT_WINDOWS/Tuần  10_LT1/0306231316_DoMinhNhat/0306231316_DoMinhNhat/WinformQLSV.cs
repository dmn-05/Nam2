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

namespace _0306231316_DoMinhNhat {
  public partial class WinformQLSV : Form {
    private string ChuoiKN = "Data Source=.\\sqlexpress01;Initial Catalog=QLSinhVien;Integrated Security=True";
    SqlConnection conn = null;
    SqlCommand com = null;
    List<LopOBJ> dsLop;
    List<SinhVienOBJ> dsSinhVien;
    SinhVienOBJ sinhvien;
    public WinformQLSV() {
      InitializeComponent();
    }

    private void WinformQLSV_Load(object sender, EventArgs e) {
      LoadDSLop();
      dgvQLSV.AutoGenerateColumns = false;
      colNS.DefaultCellStyle.Format = "dd/MM/yyyy";
      LoadDSSV();
    }

    private void LoadDSLop() {
      dsLop = new List<LopOBJ>();

      using (SqlConnection conn = new SqlConnection(ChuoiKN)) {
        conn.Open();
        string selectLop = "SELECT * FROM Lop";
        using (SqlCommand com = new SqlCommand(selectLop, conn))
        using (SqlDataReader dr = com.ExecuteReader()) {
          while (dr.Read()) {
            LopOBJ lop = new LopOBJ {
              MaLop = dr["MaLop"] != DBNull.Value ? Convert.ToInt32(dr["MaLop"]) : 0,
              TenLop = dr["TenLop"].ToString()
            };
            dsLop.Add(lop);
          }
        }
      }

      cbLop.DataSource = dsLop;
      cbLop.DisplayMember = "TenLop";
      cbLop.ValueMember = "MaLop";

      colLop.DataSource = dsLop;
      colLop.DisplayMember = "TenLop";
      colLop.ValueMember = "MaLop";
    }

    private void LoadDSSV() {
      dsSinhVien = new List<SinhVienOBJ>();

      using (SqlConnection conn = new SqlConnection(ChuoiKN)) {
        conn.Open();
        string selectSinhVien = "SELECT * FROM SinhVien WHERE TrangThai = 1";

        using (SqlCommand com = new SqlCommand(selectSinhVien, conn))
        using (SqlDataReader dr = com.ExecuteReader()) {
          while (dr.Read()) {
            SinhVienOBJ sv = new SinhVienOBJ {
              ID = dr["ID"] != DBNull.Value ? Convert.ToInt32(dr["ID"]) : 0,
              MSSV = dr["MSSV"].ToString(),
              Ho = dr["Ho"].ToString(),
              Ten = dr["Ten"].ToString(),
              DiaChi = dr["DiaChi"].ToString(),
              Lop = dr["Lop"] != DBNull.Value ? Convert.ToInt32(dr["Lop"]) : 0,
              NgaySinh = dr["NgaySinh"] != DBNull.Value ? Convert.ToDateTime(dr["NgaySinh"]) : DateTime.MinValue,
              TrangThai = 1
            };
            dsSinhVien.Add(sv);
          }
        }
      }

      dgvQLSV.DataSource = dsSinhVien;
    }

    //private SqlDataAdapter daSV = new SqlDataAdapter();
    //private DataSet dsQLSV = new DataSet();
    //private SqlDataAdapter daLop;
    //private void WinformQLSV_Load(object sender, EventArgs e) {
    //  LoadDSLop();
    //  dgvQLSV.AutoGenerateColumns = false;//ko phát sinh cột ngoài thiết kế giao diện ban đầu
    //  daSV = new SqlDataAdapter("Select * From SinhVien Where TrangThai = 1", ChuoiKN);
    //  SqlCommandBuilder scb = new SqlCommandBuilder(daSV);
    //  dataAdapter sinh viên có thể cập nhật dữ liệu
    // Tuỳ chỉnh lại lệnh insert cho dataAdapter Sinh viên khi thêm vào trạng thái = 1
    //        SqlCommand insCommand = new SqlCommand();
    //  insCommand.CommandText = "Insert Into SinhVien(MSSV, Ho, Ten, Lop, DiaChi, NgaySinh, TrangThai) values(@MSSV, @Ho, @Ten, @Lop, @DiaChi, @NgaySinh, 1)";
    //  insCommand.Parameters.Add("@MSSV", SqlDbType.NVarChar, 10, "MSSV");
    //  insCommand.Parameters.Add("@Ho", SqlDbType.NVarChar, 50, "Ho");
    //  insCommand.Parameters.Add("@Ten", SqlDbType.NVarChar, 50, "Ten");
    //  insCommand.Parameters.Add("@Lop", SqlDbType.Int, 10, "Lop");
    //  insCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 1000, "DiaChi"); insCommand.Parameters.Add("@NgaySinh", SqlDbType.Date, 20, "NgaySinh");
    //  daSV.InsertCommand = insCommand;
    //  LoadDSSV();
    //}
    //private void LoadDSSV() {
    //  if (dsQLSV.Tables["tblSinhVien"] != null) {
    //    dsQLSV.Tables["tblSinhVien"].Clear();
    //  }
    //  daSV.Fill(dsQLSV, "tblSinhVien");
    //  dgvQLSV.DataSource = dsQLSV.Tables["tblSinhVien"];
    //}

    //private void btnLuu_Click(object sender, EventArgs e) {
    //  if (dsQLSV.Tables["tblSinhVien"].GetChanges() != null) {
    //    daSV.Update(dsQLSV.Tables["tblSinhVien"]);
    //    LoadDSSV();
    //  }
    //}
    //private void LoadDSLop() {
    //  daLop = new SqlDataAdapter("Select * From Lop", ChuoiKN);
    //  daLop.Fill(dsQLSV, "tblLop");
    //  cbLop.DataSource = dsQLSV.Tables["tblLop"];
    //  cbLop.DisplayMember = "TenLop";
    //  cbLop.ValueMember = "MaLop";
    //  colLop.DataSource = dsQLSV.Tables["tblLop"];
    //  colLop.DisplayMember = "TenLop";
    //  colLop.ValueMember = "MaLop";
    //}

    private void btnReload_Click(object sender, EventArgs e) {
      dgvQLSV.ClearSelection();
    }

    private void dgvQLSV_SelectionChanged(object sender, EventArgs e) {
      //Kiem tra co chon dong nao khong
      //Neu co hien thi day du thong tin trong groupbox chi tiet
      if (dgvQLSV.SelectedRows.Count > 0) {
        sinhvien = dgvQLSV.SelectedRows[0].DataBoundItem as
        SinhVienOBJ;
      } else {//Neu khong chon: clear cac thong tin trng groupbox chi tiet
        sinhvien = null;
      }
      HienThiChiTiet();
    }
    private void HienThiChiTiet() {
      if (sinhvien != null) {
        txtMSSV.Text = sinhvien.MSSV;
        txtHo.Text = sinhvien.Ho;
        txtTen.Text = sinhvien.Ten;
        txtDC.Text = sinhvien.DiaChi;
        dateNS.Value = sinhvien.NgaySinh;
        cbLop.SelectedValue = sinhvien.Lop;
        txtMSSV.ReadOnly = true;
      } else {
        txtMSSV.Clear();
        txtHo.Clear();
        txtTen.Clear();
        txtDC.Clear();
        dateNS.Value = DateTime.Now.AddYears(-18);
        txtMSSV.ReadOnly = false;
      }
    }

    private void btnAdd_Click(object sender, EventArgs e) {
      if (KiemTraViPhamDuLieu()) {
        return;
      }
      if (sinhvien != null) {
        MessageBox.Show("Sinh viên đã tồn tại, không thể thực hiện thao tác thêm mới", "Thông Báo");
        return;
      }
      LayThongTinSinhVien();
      if (LuuMoiSinhVien()) {
        MessageBox.Show($"Thêm mới sinh viên '{sinhvien.Ho} {sinhvien.Ten}' với MSSV {sinhvien.MSSV} thành công!", "Thông Báo");
        LoadDSSV();
      } else {
        MessageBox.Show("Thêm Sinh Viên Không Thành Công", "Thông Báo");
        sinhvien = null;
      }
    }
    private bool LuuMoiSinhVien() {
      SqlConnection conn = new SqlConnection(ChuoiKN);
      try {
        conn.Open();
        string strInsert = "Insert Into SinhVien(MSSV, Ho, Ten, Lop, NgaySinh, DiaChi, TrangThai) values (@MSSV, @Ho, @Ten, @Lop, @NgaySinh, @DiaChi, 1)";
        SqlCommand com = new SqlCommand(strInsert, conn);
        com.Parameters.Add(new SqlParameter("MSSV",
        sinhvien.MSSV));
        com.Parameters.Add(new SqlParameter("Ho", sinhvien.Ho));
        com.Parameters.Add(new SqlParameter("Ten", sinhvien.Ten));
        com.Parameters.Add(new SqlParameter("Lop", sinhvien.Lop));
        com.Parameters.Add(new SqlParameter("NgaySinh",
        sinhvien.NgaySinh));
        com.Parameters.Add(new SqlParameter("DiaChi",
        sinhvien.DiaChi));
        int kq = com.ExecuteNonQuery();
        conn.Close();
        return kq > 0;
      } catch (Exception ex) {
        return false;
      }
    }
    private void LayThongTinSinhVien() {
      if (sinhvien == null) {//khi thêm mới
        sinhvien = new SinhVienOBJ();
        sinhvien.MSSV = txtMSSV.Text;
      }
      sinhvien.Ho = txtHo.Text;
      sinhvien.Ten = txtTen.Text;
      sinhvien.DiaChi = txtDC.Text;
      sinhvien.NgaySinh = dateNS.Value;
      sinhvien.Lop = (int)cbLop.SelectedValue;
    }
    public bool KiemTraViPhamDuLieu() {
      //neu vi pham -> true nguoc lai false
      if (string.IsNullOrWhiteSpace(txtMSSV.Text) ||
      string.IsNullOrWhiteSpace(txtHo.Text) ||
      string.IsNullOrWhiteSpace(txtTen.Text)) {
        MessageBox.Show("Vui lòng nhập đầy đủ họ tên và MSSV",
        "Thông Báo");
        return true;
      }
      if (txtMSSV.Text.Length != 10) {
        MessageBox.Show("MSSV phải đúng 10 ký tự số", "Thông Báo");
        return true;
      }
      if (DateTime.Now.Year - dateNS.Value.Year < 18) {
        MessageBox.Show("Sinh viên phải 18 tuổi trở lên", "Thông Báo");
        return true;
      }
      return false;
    }

    private void txtMSSV_KeyPress(object sender, KeyPressEventArgs e) {
      if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
        e.Handled = true;
      }
    }
    private bool ThayDoiSinhVien() {
      SqlConnection conn = new SqlConnection(ChuoiKN);
    try {
        conn.Open();
        string edit = "UPDATE SinhVien SET Ho = @Ho, Ten = @Ten, NgaySinh = @NgaySinh, DiaChi = @DiaChi, Lop = @Lop WHERE MSSV = @MSSV";
        SqlCommand com = new SqlCommand(edit, conn);
        com.Parameters.Add(new SqlParameter("MSSV", sinhvien.MSSV));
        com.Parameters.Add(new SqlParameter("Ho", sinhvien.Ho));
        com.Parameters.Add(new SqlParameter("Ten", sinhvien.Ten));
        com.Parameters.Add(new SqlParameter("Lop", sinhvien.Lop));
        com.Parameters.Add(new SqlParameter("NgaySinh", sinhvien.NgaySinh));
        com.Parameters.Add(new SqlParameter("DiaChi", sinhvien.DiaChi));
        int kq = com.ExecuteNonQuery();
        conn.Close();
        return kq > 0;
      } catch (Exception ex) {
        return false;
      }
    }
    private void btnEdit_Click(object sender, EventArgs e) {
      if (KiemTraViPhamDuLieu()) {
        return;
      }
      if (sinhvien == null) {
        MessageBox.Show("Sinh viên chưa được chọn, không thể chỉnh sửa", "Thông Báo");
      return;
      }
      LayThongTinSinhVien();
      if (ThayDoiSinhVien()) {
        MessageBox.Show($"Thay đổi thông tin sinh viên '{sinhvien.Ho} {sinhvien.Ten}' với MSSV { sinhvien.MSSV} thành công!", "Thông Báo");
        LoadDSSV();
      } else {
        MessageBox.Show("Thay đổi Không Thành Công", "Thông Báo");
        sinhvien = null;
      }
    }
    private bool XoaSinhVien() {
      SqlConnection conn = new SqlConnection(ChuoiKN);
      try {
        conn.Open();
        string edit = "DELETE FROM SinhVien WHERE MSSV = @MSSV";
        SqlCommand com = new SqlCommand(edit, conn);
        com.Parameters.Add(new SqlParameter("MSSV",
        sinhvien.MSSV));
        com.Parameters.Add(new SqlParameter("Ho", sinhvien.Ho));
        com.Parameters.Add(new SqlParameter("Ten", sinhvien.Ten));
        com.Parameters.Add(new SqlParameter("Lop", sinhvien.Lop));
        com.Parameters.Add(new SqlParameter("NgaySinh",
        sinhvien.NgaySinh));
        com.Parameters.Add(new SqlParameter("DiaChi",
        sinhvien.DiaChi));
        int kq = com.ExecuteNonQuery();
        conn.Close();
        return kq > 0;
      } catch (Exception ex) {
        return false;
      }
    }
    private void btnXoa_Click(object sender, EventArgs e) {
      if (KiemTraViPhamDuLieu()) {
        return;
      }
      if (sinhvien == null) {
        MessageBox.Show("Sinh viên chưa được chọn, không thể xóa", "Thông Báo");
        return;
      }
      LayThongTinSinhVien();
      if (XoaSinhVien()) {
        MessageBox.Show($"Xóa thành công!", "Thông Báo");
        LoadDSSV();
      } else {
        MessageBox.Show("Xóa Không Thành Công", "Thông Báo");
        sinhvien = null;
      }
    }
  }
}
