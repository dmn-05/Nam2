namespace _0306231316_Đỗ_Minh_Nhật_0306231335_Đỗ_Ngọc_Thế_Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chieu dai: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            float b = float.Parse(Console.ReadLine());
            float chuvi = (a + b) * 2;
            float dientich = a * b;
            Console.WriteLine("chu vi: " + chuvi);
            Console.WriteLine("dien tich: " + dientich);
        }
    }
}
