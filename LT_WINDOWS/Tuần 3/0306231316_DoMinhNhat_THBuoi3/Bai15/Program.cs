using System.Collections.Specialized;

namespace Bai15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] a = new double[100];
            int n;
            nhap(a, out n);
            xuat(a, n);
        }
        static void nhap(double[] a, out int n)
        {
            Console.Write("Nhap so luong phan tu: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i}: ");
                a[i] = double.Parse(Console.ReadLine());
            }
        }
        static void xuat(double[] a, int n)
        {
            double tong = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] < 0)
                {
                    tong += a[i];
                }
            }
            Console.WriteLine(tong);
        }
    }
}