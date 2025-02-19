namespace _0306231316_DoMinhNhat_Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            double c = double.Parse(Console.ReadLine());
            double tbc = (a+b+c) / 3;
            Console.WriteLine("trung binh cong: " + tbc);
            if (a>tbc)
            {
                Console.WriteLine("a");
            }
            if (b > tbc)
            {
                Console.WriteLine("b");
            }
            if (c > tbc)
            {
                Console.WriteLine("c");
            }
        }
    }
}