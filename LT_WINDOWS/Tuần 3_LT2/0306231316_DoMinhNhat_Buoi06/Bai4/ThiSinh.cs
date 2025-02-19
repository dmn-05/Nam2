using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class ThiSinh
    {
        public string SBD { get; set; }
        public string HoTen { get; set; }
        public double Toan { get; set; }
        public double Ly { get; set; }
        public double Hoa { get; set; }
        public double TongDiem { get; set; }
        public ThiSinh() {
            SBD = HoTen = "";
            Toan = Ly = Hoa = TongDiem = 0.0;
        }
        public ThiSinh(string sBD, string hoTen, double toan, double ly, double hoa, double tongDiem)
        {
            SBD = sBD;
            HoTen = hoTen;
            Toan = toan;
            Ly = ly;
            Hoa = hoa;
            TongDiem = tongDiem;
        }

        public void Nhap()
        {
           
            Console.Write("Nhap SBD: ");
            SBD = Console.ReadLine();
            Console.Write("Nhap Ho Ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap Diem Toan: ");
            Toan = double.Parse(Console.ReadLine());
            Console.Write("Nhap Diem Ly: ");
            Ly = double.Parse(Console.ReadLine());
            Console.Write("Nhap Diem Hoa: ");
            Hoa = double.Parse(Console.ReadLine());
            TongDiem = Toan + Ly + Hoa;
        }
        public void Xuat()
        {
            Console.WriteLine($"SBD: {SBD}");
            Console.WriteLine($"Ho Ten: {HoTen}");
            Console.WriteLine($"Diem Toan: {Toan}");
            Console.WriteLine($"Diem Ly: {Ly}");
            Console.WriteLine($"Diem Hoa: {Hoa}");
            Console.WriteLine($"Tong Diem: {TongDiem}");
        }

    }
}
