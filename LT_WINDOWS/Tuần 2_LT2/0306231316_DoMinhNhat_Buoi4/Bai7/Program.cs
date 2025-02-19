namespace Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            nhap(out a, out b);
            xuat(giaipt(a,b));
           
        }
        static void nhap(out double a, out double b)
        {
            Console.WriteLine("Nhap a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            b = double.Parse(Console.ReadLine());
        }
        static string giaipt(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    return "Phuong trinh vo so nghiem";
                }
                else
                {
                    return "Phuong trinh vo nghiem";
                }
            }
            return $"Phuong trinh co nghiem: { -b / a}";
        }
        static void xuat(string kq)
        {
            Console.WriteLine(kq);
        }
    }
}