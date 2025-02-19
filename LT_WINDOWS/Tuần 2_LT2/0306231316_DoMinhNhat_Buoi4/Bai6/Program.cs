namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            nhap(out n);
            double p = tinh(n);
            xuat(p);

        }
        static void nhap(out int n)
        {
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
        }
        static double tinh(int n)
        {
            double p = 0;
            for (int i = 1; i < n + 1; i++)
            {
                p += (double)1 / i;
            }
            return p;
        }
        static void xuat(double p)
        {
            Console.WriteLine(p);
        }
    }
}