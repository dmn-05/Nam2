namespace Bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] a = new double[100];
            int n;
            nhap(a, out n);
            xuat(a, n);
        }
        static void nhap(double[] a, out int n)
        {
            Console.Write("Nhap so luong phan tu: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i}: ");
                a[i] = double.Parse(Console.ReadLine());
            }
        }
        static void xuat(double[] a, int n)
        {
            int vt = -1;
            double min = double.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > 0 && min > a[i])
                {
                    vt = i;
                    min = a[i];  
                }

            }
            Console.WriteLine($"Phan tu duong nho nhat la: a[{vt}]");
        }
    }
}