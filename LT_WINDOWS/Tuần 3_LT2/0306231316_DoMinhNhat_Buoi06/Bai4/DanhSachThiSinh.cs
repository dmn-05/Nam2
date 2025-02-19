using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class DanhSachThiSinh
    {
        public ThiSinh[] DS {  get; set; }
        public int soluong {  get; set; }
        public DanhSachThiSinh()
        {
            DS = null;
            soluong = 0;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap so luong thi sinh: ");
            soluong = int.Parse(Console.ReadLine());
            DS = new ThiSinh[soluong];
            for (int i = 0; i < soluong; i++) {
                DS[i] = new ThiSinh();
                Console.WriteLine($"Nhap Thi Sinh {i}: ");
                DS[i].Nhap();
            }
        }
        public void Xuat()
        {
            for (int i = 0; i < soluong; i++)
            {
                Console.WriteLine($"Thi Sinh {i}: ");
                DS[i].Xuat();
            }
        }
        public void XuatTSDau()
        {
            for (int i = 0; i < soluong; i++)
            {
                if (DS[i].TongDiem >= 15 && DS[i].Toan > 1 && DS[i].Ly > 1 && DS[i].Hoa > 1)
                {

                    DS[i].Xuat();
                }
            }
        }
        public void XuatTSLiet()
        {
            for (int i = 0; i < soluong; i++)
            {
                if (DS[i].TongDiem < 15 || DS[i].Toan < 1 || DS[i].Ly < 1 || DS[i].Hoa < 1)
                {

                    DS[i].Xuat();
                }
            }
        }
        public double diemcaonhat()
        {
            double max = DS[0].TongDiem;
            for (int i = 1; i < soluong; i++)
            {
                if (max < DS[i].TongDiem)
                {
                    max = DS[i].TongDiem;
                }
            }
            return max;
        }
        public double diemthapnhat()
        {
            double min = DS[0].TongDiem;
            for (int i = 1; i < soluong; i++)
            {
                if (min > DS[i].TongDiem)
                {
                    min = DS[i].TongDiem;
                }
            }
            return min;
        }
        public void xuatthukhoa()
        {
            for (int i = 0; i < soluong; i++)
            {
                if (DS[i].TongDiem == diemcaonhat())
                {
                    DS[i].Xuat();
                }
            }
        }
        public void xuatbetkhoa() {
            for (int i = 0; i < soluong; i++)
            {
                if (DS[i].TongDiem == diemthapnhat())
                {
                    DS[i].Xuat();
                }
            }
        }
    }
}
