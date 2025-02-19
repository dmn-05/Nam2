namespace _0306231316_DoMinhNhat_Bai18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            int b = int.Parse(Console.ReadLine());
            int n = a > b ? b : a;
            int i;
            for (i = n; i > 0; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}