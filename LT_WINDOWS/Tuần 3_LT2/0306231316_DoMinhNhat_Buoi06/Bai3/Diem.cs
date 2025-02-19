using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class Diem
    {
        public double x{ get; set; }
        public double y {  get; set; }

        public Diem()
        {
            x = y = 0;
        }
        public Diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void nhap()
        {
            Console.Write("Nhap toa do x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Nhap toa do y: ");
            y = double.Parse(Console.ReadLine());
        }
        public void xuat() {
            Console.WriteLine($"toa do x: {x}");
            Console.WriteLine($"toa do y: {y}");
        }
        public double tinhkhoangcach(Diem Z) {
            return Math.Sqrt(Math.Pow(x - Z.x, 2) + Math.Pow(y - Z.y, 2));
        }
        

    }
}
