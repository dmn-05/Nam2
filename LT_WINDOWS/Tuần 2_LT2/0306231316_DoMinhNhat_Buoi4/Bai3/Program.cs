namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            nhap(out a, out b, out c, out d);
            double min_out = min(a, b, c, d);
            xuat(min_out);
        }
        static void nhap(out double a, out double b, out double c, out double d)
        {
            Console.WriteLine("Nhap a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c: ");
            c = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Nhap d: ");
            d = double.Parse(Console.ReadLine());
        }
        static double min(double a, double b, double c, double d)
        {
            double min = a;
            if (b < min)
            {
                min = b;
            }
            if (c < min)
            {
                min = c;
            }
            if (d < min)
            {
                min = d;
            }
            return min;
        }
        static void xuat(double min)
        {
            Console.WriteLine("min la: " + min);
        }
    }
}