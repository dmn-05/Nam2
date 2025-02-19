using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bai05
{
    public class hocsinh
    {
        public int MaHocSinh { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string NgaySinh { get; set; }
        public double Toan { get; set; }
        public double Van { get; set; }
        public double Anh { get; set; }
        public double Sinh { get; set; }
        public double Ly { get; set; }
        public double Hoa { get; set; }
        public double Su { get; set; }
        public double Dia { get; set; }
        public double GDCD { get; set; }
        public double CongNghe { get; set; }
        public double TinHoc { get; set; }
        public double DiemTK { get; set; }
        public string XLHocLuc { get; set; }

        public hocsinh()
        {
            MaHocSinh = 0;
            Ho = "";
            Ten = "";
            NgaySinh = "";
            Toan = Van = Anh = Sinh = Ly = Hoa = Su = Dia = GDCD = CongNghe = TinHoc = DiemTK = 0;
            XLHocLuc = "";
        }
        public hocsinh(int maHocSinh, string ho, string ten, string ngaySinh, double toan, double van, double anh, double sinh, double ly, double hoa, double su, double dia, double gDCD, double congNghe, double tinHoc, double diemTK, string xLHocLuc)
        {
            MaHocSinh = maHocSinh;
            Ho = ho;
            Ten = ten;
            NgaySinh = ngaySinh;
            Toan = toan;
            Van = van;
            Anh = anh;
            Sinh = sinh;
            Ly = ly;
            Hoa = hoa;
            Su = su;
            Dia = dia;
            GDCD = gDCD;
            CongNghe = congNghe;
            TinHoc = tinHoc;
            DiemTK = diemTK;
            XLHocLuc = xLHocLuc;
        }
        public void NhapBangDiemHocSinh()
        {
            Console.Write("Nhap Ma Hoc Sinh: ");
            MaHocSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap Ho Hoc Sinh: ");
            Ho = Console.ReadLine();
            Console.Write("Nhap Ten Hoc Sinh: ");
            Ten = Console.ReadLine();
            Console.Write("Nhap Ngay Sinh Hoc Sinh: ");
            NgaySinh = Console.ReadLine();
            Console.Write("Nhap Diem Toan: ");
            Toan = double.Parse(Console.ReadLine());
            Console.Write("Nhap Diem Van: ");
            Van = double.Parse(Console.ReadLine());
            Console.Write("Nhap Diem Anh: ");
            Anh = double.Parse(Console.ReadLine());
            Console.Write("Nhap Diem Sinh: ");
            Sinh = double.Parse(Console.ReadLine());
            Console.Write("Nhap Diem Ly: ");
            Ly = double.Parse(Console.ReadLine());
            Console.Write("Nhap Diem Hoa: ");
            Hoa = double.Parse(Console.ReadLine());
            Console.Write("Nhap Diem Su: ");
            Su = double.Parse(Console.ReadLine());
            Console.Write("Nhap Diem Dia: ");
            Dia = double.Parse(Console.ReadLine());
            Console.Write("Nhap Diem GDCD: ");
            GDCD = double.Parse(Console.ReadLine());
            Console.Write("Nhap Diem Cong Nghe: ");
            CongNghe = double.Parse(Console.ReadLine());
            Console.Write("Nhap Diem Tin Hoc: ");
            TinHoc = double.Parse(Console.ReadLine());
            DiemTK = TinhDiemTongKet(Toan, Van, Anh, Sinh, Ly, Hoa, Su, Dia, GDCD, CongNghe, TinHoc);
            XLHocLuc = XepLoaiHocLuc(DiemTK);
        }
        public void XuatBangDiemHocSinh()
        {
            Console.WriteLine($"Ma Hoc Sinh: {MaHocSinh}");
            Console.WriteLine($"Ho Hoc Sinh: {Ho}");
            Console.WriteLine($"Ten Hoc Sinh: {Ten}");
            Console.WriteLine($"Ngay Sinh Hoc Sinh: {NgaySinh}");
            Console.WriteLine($"Diem Toan: {Toan}");
            Console.WriteLine($"Diem Van: {Van}");
            Console.WriteLine($"Diem Anh: {Anh}");
            Console.WriteLine($"Diem Sinh: {Sinh}");
            Console.WriteLine($"Diem Ly: {Ly}");
            Console.WriteLine($"Diem Hoa: {Hoa}");
            Console.WriteLine($"Diem Su: {Su}");
            Console.WriteLine($"Diem Dia: {Dia}");
            Console.WriteLine($"Diem GDCD: {GDCD}");
            Console.WriteLine($"Diem Cong Nghe: {CongNghe}");
            Console.WriteLine($"Diem Tin Hoc: {TinHoc}");
            Console.WriteLine($"Diem Tong Ket: {DiemTK}");
            Console.WriteLine($"Xep Hang Hoc Luc: {XLHocLuc}");
        }
        public double TinhDiemTongKet(double Toan, double Van, double Anh, double Sinh, double Ly, double Hoa, double Su, double Dia, double GDCD, double CongNghe, double TinHoc)
        {
            return (Toan + Van + Anh + Sinh + Ly + Hoa + Su + Dia + GDCD + CongNghe + TinHoc) / 11;
        }
        public string XepLoaiHocLuc(double DiemTK)
        {
            if (DiemTK >= 8)
            {
                return "Gioi";
            }
            else if (DiemTK >= 7)
            {
                return "Kha";
            }
            else if (DiemTK >= 5)
            {
                return "Trung Binh";
            }
            else if (DiemTK >= 3.5)
            {
                return "Yeu";
            }
            return "Kem";
        }
        public string XepLoaiHocLucNC(double Toan, double Van, double Anh, double Sinh, double Ly, double Hoa, double Su, double Dia, double GDCD, double CongNghe, double TinHoc, double DiemTK)
        {
            if (DiemTK >= 8 && ((Toan >= 8 || Van >= 8) && Toan >= 6.5 && Van >= 6.5 && Anh >= 6.5
                && Sinh >= 6.5 && Ly >= 6.5 && Hoa >= 6.5 && Su >= 6.5 && Dia >= 6.5 && GDCD >= 6.5
                && CongNghe >= 6.5 && TinHoc >= 6.5))
            {
                return "Gioi";
            }
            else if (DiemTK >= 6.5 && ((Toan >= 6.5 || Van >= 6.5) && Toan >= 5 && Van >= 5 && Anh >= 5
                && Sinh >= 5 && Ly >= 5 && Hoa >= 5 && Su >= 5 && Dia >= 5 && GDCD >= 5
                && CongNghe >= 5 && TinHoc >= 5))
            {
                return "Kha";
            }
            else if (DiemTK >= 5 && ((Toan >= 5 || Van >= 5) && Toan >= 3.5 && Van >= 3.5 && Anh >= 3.5
                && Sinh >= 3.5 && Ly >= 3.5 && Hoa >= 3.5 && Su >= 3.5 && Dia >= 3.5 && GDCD >= 3.5
                && CongNghe >= 3.5 && TinHoc >= 3.5))
            {
                return "Trung Binh";
            }
            else if (DiemTK >= 3.5 && ((Toan >= 3.5 || Van >= 3.5) && Toan >= 2 && Van >= 2 && Anh >= 2
                && Sinh >= 2 && Ly >= 2 && Hoa >= 2 && Su >= 2 && Dia >= 2 && GDCD >= 2
                && CongNghe >= 2 && TinHoc >= 2))
            {
                return "Yeu";
            }
            return "Kem";
        }
        public void MonDuoiTB(double Toan, double Van, double Anh, double Sinh, double Ly, double Hoa, double Su, double Dia, double GDCD, double CongNghe, double TinHoc)
        {
            if (Toan < 5)
            {
                Console.WriteLine($"Diem Toan: {Toan}");
            }
            if (Van < 5)
            {
                Console.WriteLine($"Diem Van: {Van}");
            }
            if (Anh < 5)
            {
                Console.WriteLine($"Diem Anh: {Anh}");
            }
            if (Sinh < 5)
            {
                Console.WriteLine($"Diem Sinh: {Sinh}");
            }
            if (Ly < 5)
            {
                Console.WriteLine($"Diem Ly: {Ly}");
            }
            if (Hoa < 5)
            {
                Console.WriteLine($"Diem Hoa: {Hoa}");
            }
            if (Su < 5)
            {
                Console.WriteLine($"Diem Su: {Su}");
            }
            if (Dia < 5)
            {
                Console.WriteLine($"Diem Dia: {Dia}");
            }
            if (GDCD < 5)
            {
                Console.WriteLine($"Diem GDCD: {GDCD}");
            }
            if (CongNghe < 5)
            {
                Console.WriteLine($"Diem Cong Nghe: {CongNghe}");
            }
            if (TinHoc < 5)
            {
                Console.WriteLine($"Diem Tin Hoc: {TinHoc}");
            }
        }
        public void MonHocLoaiGioi(double Toan, double Van, double Anh, double Sinh, double Ly, double Hoa, double Su, double Dia, double GDCD, double CongNghe, double TinHoc)
        {
            if (Toan > 8)
            {
                Console.WriteLine($"Diem Toan: {Toan}");
            }
            if (Van > 8)
            {
                Console.WriteLine($"Diem Van: {Van}");
            }
            if (Anh > 8)
            {
                Console.WriteLine($"Diem Anh: {Anh}");
            }
            if (Sinh > 8)
            {
                Console.WriteLine($"Diem Sinh: {Sinh}");
            }
            if (Ly > 8)
            {
                Console.WriteLine($"Diem Ly: {Ly}");
            }
            if (Hoa > 8)
            {
                Console.WriteLine($"Diem Hoa: {Hoa}");
            }
            if (Su > 8)
            {
                Console.WriteLine($"Diem Su: {Su}");
            }
            if (Dia > 8)
            {
                Console.WriteLine($"Diem Dia: {Dia}");
            }
            if (GDCD > 8)
            {
                Console.WriteLine($"Diem GDCD: {GDCD}");
            }
            if (CongNghe > 8)
            {
                Console.WriteLine($"Diem Cong Nghe: {CongNghe}");
            }
            if (TinHoc > 8)
            {
                Console.WriteLine($"Diem Tin Hoc: {TinHoc}");
            }
        }
    }
}
