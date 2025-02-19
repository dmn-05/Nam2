namespace _0306231316_DoMinhNhat_Bai9
{
    class Program
    {
        static void Main()
        {

            int ngay, thang, nam;
            Console.Write("ngay: ");
            ngay = int.Parse(Console.ReadLine());

            Console.Write("thang: ");
            thang = int.Parse(Console.ReadLine());

            Console.Write("nam: ");
            nam = int.Parse(Console.ReadLine());


            int[] soNgayTrongThang = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


            if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
            {
                soNgayTrongThang[1] = 29;                
            }
            ngay++;

            if (ngay > soNgayTrongThang[thang - 1])
            {
                ngay = 1;
                thang++;
            }

            if (thang > 12)
            {
                thang = 1;
                nam++;
            }
            Console.WriteLine($"Ngày tiếp theo: {ngay}/{thang}/{nam}");
        }

    }
}

