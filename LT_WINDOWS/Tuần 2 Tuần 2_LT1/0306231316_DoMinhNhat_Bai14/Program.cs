namespace _0306231316_DoMinhNhat_Bai14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum, sum2, sum3;
            sum = sum2 = sum3 = 0;
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int i;
            for (i = 1; i < n+1; i++)
            {
                sum = Math.Sqrt(sum + i);
            }
            i = 1;
            while (i < n+1)
            {
                sum2 = Math.Sqrt(sum2 + i);
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
                sum3 = Math.Sqrt(sum3 + i);
                i++;
            } while (i < n + 1);
            Console.WriteLine(sum);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
        }
    }
}