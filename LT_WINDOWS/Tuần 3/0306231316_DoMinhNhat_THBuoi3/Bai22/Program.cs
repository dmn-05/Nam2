namespace Bai22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] a = new double[100];
            int n;
            nhap(a, out n);
            interchangesort(a, n);
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
        static void interchangesort(double []a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j]) { 
                        double temp = a[i]; 
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
        static void xuat(double[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Phan tu thu a[{i}] la: {a[i]}");
            }
        }
    }
}