namespace _0306231316_DoMinhNhat_Bai22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i <= 999; i++)
            {
                int sum = 0, num = i;
                while (num > 0)
                {
                    int temp = num % 10;
                    sum += temp * temp;
                    num /= 10;
                }

                if (sum == 25)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}