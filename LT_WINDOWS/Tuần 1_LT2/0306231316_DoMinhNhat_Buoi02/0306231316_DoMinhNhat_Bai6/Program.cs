using System;
namespace _0306231316_DoMinhNhat_Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int tong,tong2,tong3,tich;
            tong = tong2 = tong3 = 0;
            tich = 1;
            do
            {
                Console.Write("Nhap so nguyen duong: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 1);
            for (int i = 1; i < n + 1; i++) {
                tong += i;
                tong2 += (int)Math.Pow(i, 2);
                tong3 += i * 2;
                tich *= i;
            }
            Console.WriteLine($"S = {tong}");
            Console.WriteLine($"T = {tong2}");
            Console.WriteLine($"Q = {tong3}");
            Console.WriteLine($"P = {tich}");
        }
    }
}