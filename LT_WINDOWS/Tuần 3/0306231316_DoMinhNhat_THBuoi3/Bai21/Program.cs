namespace Bai21
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
        static void xuat(int[] a, int n)
        {
            int dem = 1;
            int []b = new int[n];
            b[0] = a[0];
            for (int i = 1; i < n; i++)
            {
                bool check = true;
                for (int j = 0; j < dem; j++)
                {
                    if (b[j] == a[i])
                    {
                       check = false;
                    }
                }
                if (check)
                {
                    b[dem] = a[i];
                    dem++;
                }
            }
            Console.WriteLine($"So luong phan tu phan biet trong mang la: {dem}");
        }
    }
}