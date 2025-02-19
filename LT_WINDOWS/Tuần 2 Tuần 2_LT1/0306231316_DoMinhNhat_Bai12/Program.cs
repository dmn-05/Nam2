namespace _0306231316_DoMinhNhat_Bai12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum, sum2, sum3;
            sum = sum2 = sum3 = 0;
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            for (i = 1; i < n + 1; i++)
            {
                if (i % 2 != 0)
                {
                    sum += (i / (double)(i + 1));
                }
            }
            i = 1;
            while (i < n + 1)
            {
                if (i % 2 != 0)
                {
                    sum2 += (i / (double)(i + 1));
                }
                i++;
            }
            i = 1;
            do
            {
                if (n < 1)
                {
                    sum3 = 0;
                    break;
                }
                if (i % 2 != 0)
                {
                    sum3 += (i / (double)(i + 1));
                }
                i++;
            } while (i < n + 1);
            Console.WriteLine(sum);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
        }
    }
}