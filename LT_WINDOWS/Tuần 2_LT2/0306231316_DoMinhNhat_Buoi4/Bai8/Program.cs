namespace Bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            nhap(out a, out b, out c);
            xuat(giaipt(a,b,c));
        }
        static void nhap(out double a, out double b, out double c)
        {
            Console.WriteLine("Nhap a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c: ");
            c = double.Parse(Console.ReadLine());
        }
        static string giaipt( double a, double b, double c) {
            if (a == 0)
            {
                if (b == 0)
                {
                    return "Phuong trinh vo nghiem";
                }
                else {
                    return $"Phuong trinh co mot nghiem{-b / c}";
                }
            }
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                return "Phuong trinh vo nghiem";
            }
            else if (delta > 0) {
                return $"Phuong trinh co hai nghiem phan biet:\n" +
                    $"x1 = {(-b + Math.Sqrt(delta)) / (2 * a)}\n" +
                    $"x2 = {(-b - Math.Sqrt(delta)) / (2 * a)}\n";
            }
            return $"phuong trinh co nghiem kep x ={-b / (2 * a)}";
        }
        static void xuat(string kq)
        {
            Console.WriteLine(kq);
        }
    }
}