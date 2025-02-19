using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class TamGiac
    {
        public Diem A { get; set; }
        public Diem B { get; set; }
        public Diem C { get; set; }

        public void NhapTamGiac()
        {
            A = new Diem();
            B = new Diem();
            C = new Diem();
            Console.WriteLine("Nhap diem A: ");
            A.nhap();
            Console.WriteLine("Nhap diem B: ");
            B.nhap();
            Console.WriteLine("Nhap diem C: ");
            C.nhap();
        }
        public void XuatTamGiac()
        {
            Console.Write("Diem A: ");
            A.xuat();
            Console.Write("Diem B: ");
            B.xuat();
            Console.Write("Diem C: ");
            C.xuat();
        }
        public double ChuVi(){

            return A.tinhkhoangcach(B) + B.tinhkhoangcach(C) + C.tinhkhoangcach(A);
        }
        public double DienTich()
        {
            double a = B.tinhkhoangcach(C);
            double b = A.tinhkhoangcach(C);
            double c = A.tinhkhoangcach(B);
            double p = ChuVi() / 2;
            return (Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }
        public Diem TrongTam()
        {
            Diem TT = new Diem();
            TT.x = (A.x + B.x + C.x) / 3;
            TT.y = (A.y + B.y + C.y) / 3;
            return TT;
        }
       
    }
}
