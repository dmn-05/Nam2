using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
using System.IO;
using System.Text;


namespace Bai05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FileName = "data.txt";  //file DuLieuThuNghiem.txt đặt cùng thư mục với file .EXE 

            StreamReader sr = new StreamReader(FileName, Encoding.UTF8);
            string s;

            s = sr.ReadLine(); //đọc dòng đầu tiên


            while (s != null)
            {
                Console.WriteLine(s);  //xuất ra màn hình kết quả 1 dòng Text


                s = sr.ReadLine();  //đọc dòng tiếp theo
            }
            sr.Close();
            hocsinh hs = new hocsinh();
            hs.NhapBangDiemHocSinh();
            hs.XuatBangDiemHocSinh();
            hs.MonDuoiTB(hs.Toan, hs.Van, hs.Anh, hs.Sinh, hs.Ly, hs.Hoa, hs.Su, hs.Dia, hs.GDCD, hs.CongNghe, hs.TinHoc);
            hs.MonHocLoaiGioi(hs.Toan, hs.Van, hs.Anh, hs.Sinh, hs.Ly, hs.Hoa, hs.Su, hs.Dia, hs.GDCD, hs.CongNghe, hs.TinHoc);
            LopHoc LH = new LopHoc();
            LH.NhapDSHocSinh();
            LH.XuatDSHocSinh();
            LH.XuatDSHocSinhGioi();
            LH.XuatDSHocSinhKha();
            LH.XuatDSHocSinhTB();
            LH.XuatDSHocSinhYeu();
        }
    }
}