namespace _0306231316_DoMinhNhat_Bai15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum, sum2, sum3;
            sum = sum2 = sum3 = 0;
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap x: ");
            int x = int.Parse(Console.ReadLine());
            int i;
            int mau = 0;
            for (i = 1; i < n + 1; i++)
            {
                mau += i;
                sum += Math.Pow(-x, i) / mau;

            }
            i = 1;
            mau = 0;
            while (i < n + 1)
            {
                mau += i;
                sum2 += Math.Pow(-x, i) / mau;
                i++;
            }
            i = 1;
            mau = 0;
            do
            {
                if (n < 1)
                {
                    sum3 = 0;
                    break;
                }
                mau += i;
                sum3 += Math.Pow(-x, i) / mau;
                i++;
            } while (i < n + 1);
            Console.WriteLine(sum);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
        }
    }
}