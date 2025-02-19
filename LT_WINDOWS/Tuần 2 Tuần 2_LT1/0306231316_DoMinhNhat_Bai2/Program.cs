using System;
namespace _0306231316_DoMinhNhat_Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum, sum2, sum3;
            sum = sum2 = sum3 = 0;
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            for (i = 1; i < n + 1; i++)
            {
                sum += Math.Pow(i, 2);
            }
            i = 1;
            while (i < n + 1)
            {
                sum2 += Math.Pow(i, 2);
                i++;
            }
            i = 0;
            do
            {
                sum3 += Math.Pow(i, 2);
                i++;
            } while (i < n + 1);
            Console.WriteLine(sum);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
        }
    }
}