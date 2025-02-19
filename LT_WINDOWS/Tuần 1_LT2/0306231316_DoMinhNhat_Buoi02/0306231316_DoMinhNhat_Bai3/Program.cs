using System;

namespace _0306231316_DoMinhNhat_Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Nhap a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            double b = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Vo nghiem");
                }
            }
            else
            {
                Console.Write(-b / a);
            }
           
        }
    }
}