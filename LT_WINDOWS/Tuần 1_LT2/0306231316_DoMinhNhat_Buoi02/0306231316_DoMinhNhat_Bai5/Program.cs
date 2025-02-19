namespace _0306231316_DoMinhNhat_Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap so co 3 chu so: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 100 || n > 999);
            int a = n % 10;
            int b = n / 10 % 10;
            int c = n / 100 % 10;
            
            int max = int.MinValue;
            int secondMax = int.MinValue;
            if (a > max)
            {
                secondMax = max;
                max = a;
            }
            else if (a > secondMax && a < max)
            {
                secondMax = a;
            }

            if (b > max)
            {
                secondMax = max;
                max = b;
            }
            else if (b > secondMax && b < max)
            {
                secondMax = b;
            }
            if (c > max)
            {
                secondMax = max;
                max = c;
            }
            else if (c > secondMax && c < max)
            {
                secondMax = c;
            }


            // Kiểm tra và hiển thị kết quả
            if (secondMax == int.MinValue)
            {
                Console.WriteLine("khong co so lon nhi");
            }
            else
            {
                Console.WriteLine($"so lon nhat: {max}");
                Console.WriteLine($"so lon nhat: {secondMax}");
            }
        }
    }
}

