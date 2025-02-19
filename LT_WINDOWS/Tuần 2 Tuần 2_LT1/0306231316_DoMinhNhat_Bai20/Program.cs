namespace _0306231316_DoMinhNhat_Bai20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            if (check(n))
            {
                Console.Write("La so nguyen to");
            }
            else
            {
                Console.Write("Khong phai so nguyen to");
            }
        }
        static bool check(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}