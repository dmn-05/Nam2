namespace _0306231316_DoMinhNhat_Bai17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int i;
            for (i = 1; i < n + 1; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}