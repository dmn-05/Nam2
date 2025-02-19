namespace _0306231316_DoMinhNhat_Bai21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap tuoi cha hien tai: ");
            int ageFather = int.Parse(Console.ReadLine());
            Console.Write("nhap tuoi con hien tai: ");
            int ageChild = int.Parse(Console.ReadLine());

            int years = 0;
            while (ageFather != 2 * ageChild)
            {
                ageFather++;
                ageChild++;
                years++;
            }

            Console.WriteLine("kq:" + ageFather + " " + ageChild + " " + years);

        }
    }
}