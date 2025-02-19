using System;
namespace _0306231316_DoMinhNhat_Bai13
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
            for (i = n; i > 0; i--)
            {
                sum = Math.Sqrt(sum + i);
            }
            i = n;
            while (i > 0)
            {
                sum2 = Math.Sqrt(sum2 + i);
                i--;
            }
            i = n;
            do
            {
                if (n < 1)
                {
                    sum3 = 0;
                    break;
                }
                sum3 = Math.Sqrt(sum3 + i);
                i--;
            } while (i > 0);
            Console.WriteLine(sum);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
        }
    }
}