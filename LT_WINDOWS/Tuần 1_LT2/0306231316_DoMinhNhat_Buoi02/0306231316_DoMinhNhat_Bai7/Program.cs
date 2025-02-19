namespace _0306231316_DoMinhNhat_Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap diem kiem tra: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem chuyen can: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap diem thi: ");
            int c = int.Parse(Console.ReadLine());
            double diemtk = b * 0.1 + a * 0.4 + c * 0.5;
            Console.WriteLine(diemtk);

            if (diemtk < 5)
            {
                Console.WriteLine("yeu");
            }
            else if (diemtk < 7)
            {
                Console.WriteLine("trung binh");
            }
            else if (diemtk < 8)
            {
                Console.WriteLine("kha");
            }
            else
            {
                Console.WriteLine("gioi");
            }

        }
    }
}