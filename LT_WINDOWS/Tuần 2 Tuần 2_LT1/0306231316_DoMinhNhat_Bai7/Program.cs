namespace _0306231316_DoMinhNhat_Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum, sum2, sum3;
            sum = sum2 = sum3 = 1;
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            for (i = 1; i < n + 1; i++)
            {
                sum *= i;
            }
            i = 1;
            while (i < n + 1)
            {
                sum2 *= i;
                i++;
            }
            i = 1;
            do
            {
                sum3 *= i;
                i++;
            } while (i < n + 1);
            Console.WriteLine(sum);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
        }
    }
}