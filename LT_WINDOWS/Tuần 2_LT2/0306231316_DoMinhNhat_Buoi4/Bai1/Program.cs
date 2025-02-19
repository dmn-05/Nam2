namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            nhap(out x);
            double y = tinh(x);
            xuat(y);

        }
        static void nhap(out double x)
        {
            Console.Write("Nhap x: ");
            x = double.Parse(Console.ReadLine());
        }
        static double tinh(double x) {
            return 7 * Math.Pow(x,10) - 6 * Math.Pow(x,2) + 5 * x + 3;
        }
        static void xuat(double y)
        {
            Console.WriteLine(y);
        }
    }
}