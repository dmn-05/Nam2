namespace _0306231316_Đỗ_Minh_Nhật_0306231335_Đỗ_Ngọc_Thế_Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ban kinh: ");
            double bk = double.Parse(Console.ReadLine());
            double pi = 3.14;
            double chuvi = 2 * bk * pi;
            double dientich =  pi * bk * bk;
            Console.WriteLine("chu vi: " + chuvi);
            Console.WriteLine("dien tich: " + dientich);
        }
    }
}
