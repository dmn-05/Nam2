namespace Bai18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int n;
            nhap(a, out n);
            xuat(a, n);
        }
        static void nhap(int[] a, out int n)
        {
            Console.Write("Nhap so luong phan tu: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static bool isSNT(int a)
        {
            if (a < 2)
            {
                return false;
            }
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void xuat(int[] a, int n)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (isSNT(a[i]) && a[i] < 100)
                {
                    dem++;
                }

            }
            Console.WriteLine($"So luong so nguyen to be hon 100 trong mang la: {dem}");
        }
    }
}