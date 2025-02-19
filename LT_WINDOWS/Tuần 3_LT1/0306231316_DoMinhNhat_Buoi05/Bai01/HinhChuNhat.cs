using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    public class HinhChuNhat
    {
        public double chieudai { get; set; }
        public double chieurong { get; set; }
        public HinhChuNhat() { 
            chieudai = 0;
            chieurong = 0;
        }
        public HinhChuNhat(double dai, double rong)
        {
            chieudai = dai;
            chieurong = rong;
        }
        public void NhapHinhChuNhat() {
            Console.Write("Nhap chieu dai: ");
            chieudai = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            chieurong = double.Parse(Console.ReadLine());
        }
        public void XuatHinhChuNhat()
        {
            Console.WriteLine("Hinh Chu Nhat: ");
            Console.WriteLine("chieu dai: {0}\nChieu rong: {1}",chieudai, chieurong);
        }
        public double TinhChuVi()
        {
            return (chieudai + chieurong) * 2;
        }
        public double TinhDienTich()
        {
            return chieudai * chieurong;
        }
        public double TinhDuongCheo()
        {
            return Math.Sqrt(Math.Pow(chieudai,2) + Math.Pow(chieurong,2));
        }
    }
}
