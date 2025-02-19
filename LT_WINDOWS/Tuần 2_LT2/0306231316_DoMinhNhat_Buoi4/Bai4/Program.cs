namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            nhap(out a, out b, out c, out d);
            double min_out = min_2(a, b, c, d);
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
        static double min_2(double a, double b, double c, double d)
        {
            double min, min2;
            if (a > b)
            {
                min = b;
                min2 = a;
            }
            else
            {
                min = a;
                min2 = b;
            }
            if (c < min) {
                min2 = min;
                min = c;
            }
            else if (c < min2 )
            {
                min2 = c;
            }
            if (d < min)
            {
                min2 = min;
                min = d;
            }
            else if (d < min2)
            {
                min2 = d;
            }


            return min2;
        }
        static void xuat(double min2)
        {
            Console.WriteLine("so nho nhi la: " + min2);
        }
    }
}