namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            nhap(out n);
            int s = tinh(n);
            xuat(s);

        }
        static void nhap(out int n)
        {
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
        }
        static int tinh(int n)
        {
            int s = 0;
            for (int i = 1;i < n + 1; i++)
            {
                s+= i;
            }
            return s;
        }
        static void xuat(int s)
        {
            Console.WriteLine(s);
        }
    }
}