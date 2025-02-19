namespace _0306231316_DoMinhNhat_Bai19
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
            int tich = a * b;
            int i;
            for (i = n; i < tich + 1; i++)
            {
                if (i % a == 0 && i % b == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}