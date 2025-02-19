namespace _0306231316_DoMinhNhat_Bai1
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
            
            double min = a;
            if (b<min)
            {
                min = b;
            }
            else
            {
                min = c;
            }
            Console.WriteLine("So nho nhat la: "+min);

        }
    }
}