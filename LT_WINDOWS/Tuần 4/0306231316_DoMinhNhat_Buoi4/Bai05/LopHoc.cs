using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    public class LopHoc
    {
        public hocsinh[] DSHocSinh { get; set; }
        public int sl { get; set; }
        public LopHoc() {
            sl = 0;
            DSHocSinh = null;
        }
        public void NhapDSHocSinh()
        {
            Console.Write("Nhap So Luong HS: ");
            sl = int.Parse(Console.ReadLine());
            DSHocSinh = new hocsinh[sl];
            for (int i = 0; i < sl; i++)
            {
                DSHocSinh[i] = new hocsinh();
                DSHocSinh[i].NhapBangDiemHocSinh();
            }
        }
        public void XuatDSHocSinh()
        {
            for (int i = 0; i < sl; i++)
            {
                DSHocSinh[i].XuatBangDiemHocSinh(); 
            }
        }
        public void XuatDSHocSinhGioi()
        {
            for (int i = 0; i < sl; i++)
            {
                if (DSHocSinh[i].XLHocLuc == "Gioi")
                {
                    DSHocSinh[i].XuatBangDiemHocSinh();
                }
            }
        }
        public void XuatDSHocSinhKha()
        {
            for (int i = 0; i < sl; i++)
            {
                if (DSHocSinh[i].XLHocLuc == "Kha")
                {
                    DSHocSinh[i].XuatBangDiemHocSinh();
                }
            }
        }
        public void XuatDSHocSinhTB()
        {
            for (int i = 0; i < sl; i++)
            {
                if (DSHocSinh[i].XLHocLuc == "Trung Binh")
                {
                    DSHocSinh[i].XuatBangDiemHocSinh();
                }
            }
        }
        public void XuatDSHocSinhYeu()
        {
            for (int i = 0; i < sl; i++)
            {
                if (DSHocSinh[i].XLHocLuc == "Yeu")
                {
                    DSHocSinh[i].XuatBangDiemHocSinh();
                }
            }
        }
    }
}
