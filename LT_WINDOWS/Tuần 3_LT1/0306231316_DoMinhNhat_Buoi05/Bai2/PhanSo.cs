using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class PhanSo
    {
        public int tu { get; set;}
        public int mau { get; set;}

        public PhanSo() { 
            tu = 0;
            mau = 0;
        }
        public PhanSo(int tu, int mau) {
            this.tu = tu;
            this.mau = mau;
        }
        public void NhapPhanSo() {
            Console.Write("Nhap tu so: ");
            tu = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            mau = int.Parse(Console.ReadLine());
        }
        public void XuatPhanSo() {
            Console.WriteLine("Phan so la: {0}/{1}",tu,mau);
        }
        public int UocPhanSo(int a, int b) {
            while(b != 0)
            {
                int tam = a % b;
                a = b;
                b = tam;
            }
            return a;
        }
        public void RutGonPhanSo()
        {
            int ucln = UocPhanSo(tu,mau);
            tu /= ucln;
            mau /= ucln;
        }
        public PhanSo Tong(PhanSo ps)
        {
            PhanSo sum = new PhanSo();
            sum.tu = tu * ps.mau + mau * ps.tu;
            sum.mau = mau * ps.mau;
            sum.RutGonPhanSo();
            return sum;
        }
        public PhanSo Hieu(PhanSo ps)
        {
            PhanSo sub = new PhanSo();
            sub.tu = tu * ps.mau - mau * ps.tu;
            sub.mau = mau * ps.mau;
            sub.RutGonPhanSo();
            return sub;
        }
        public PhanSo Tich(PhanSo ps)
        {
            PhanSo time = new PhanSo();
            time.tu = tu * ps.tu;
            time.mau = mau * ps.mau;
            time.RutGonPhanSo();
            return time;
        }
        public PhanSo Thuong(PhanSo ps)
        {
            PhanSo div = new PhanSo();
            div.tu = tu * ps.mau;
            div.mau = mau * ps.tu;
            return div;
        }
    }
}
