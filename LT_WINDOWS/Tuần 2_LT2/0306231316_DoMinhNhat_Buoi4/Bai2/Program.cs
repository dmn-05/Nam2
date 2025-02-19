namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            nhap(out a,out b,out c);
            int max_out = max(a, b, c);
            xuat(max_out);
        }
        static void nhap(out int a, out int b, out int c)
        {
            Console.WriteLine("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c: ");
            c = int.Parse(Console.ReadLine());
        }
        static int max (int a, int b, int c) {
            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            return max;
        }
        static void xuat(int max)
        {
            Console.WriteLine("max la: " + max);
        }
    }
}