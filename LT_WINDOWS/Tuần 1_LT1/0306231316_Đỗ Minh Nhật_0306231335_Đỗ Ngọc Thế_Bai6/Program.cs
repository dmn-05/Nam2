using System;
namespace _0306231316_Đỗ_Minh_Nhật_0306231335_Đỗ_Ngọc_Thế_Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap x: ");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine((Math.Pow(x, 3) + Math.Sqrt(x)) / (Math.Pow(x, 2) + 1 + Math.Sin(x)));
        }
    }
}