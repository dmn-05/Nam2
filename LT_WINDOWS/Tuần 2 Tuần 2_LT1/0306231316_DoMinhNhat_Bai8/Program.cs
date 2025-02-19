namespace _0306231316_DoMinhNhat_Bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum, sum2, sum3;
            sum = sum2 = sum3 = 1;
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap m: ");
            int m = int.Parse(Console.ReadLine());
            int i = 1;
            for (i = 1; i < m + 1; i++)
            {
                sum *= n;
            }
            i = 1;
            while (i < m + 1)
            {
                sum2 *= n;
                i++;
            }
            i = 1;
            do
            {
                if (n < 1)
                {
                    sum3 = 1;
                    break;
                }
                sum3 *= n;
                i++;
            } while (i < m + 1);
            Console.WriteLine(sum);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
        }
    }
}