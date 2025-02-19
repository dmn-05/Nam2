namespace Bai6
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
            int vt = -1;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    vt = i;
                    break;
                }

            }
            Console.WriteLine($"Phan tu chan dau tien la: a[{vt}]");
        }
    }
}