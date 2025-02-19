namespace _0306231316_DoMinhNhat_Bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chiSoCu, chiSoMoi;


            Console.Write("dien cu: ");
            chiSoCu = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("dien moi: ");
                chiSoMoi = int.Parse(Console.ReadLine());
            } while (chiSoCu > chiSoMoi);
            int kwSuDung = chiSoMoi - chiSoCu;
            double tienDien = 0;

            if (kwSuDung <= 100)
            {
                tienDien = kwSuDung * 1242;
            }
            else if (kwSuDung <= 150)
            {
                tienDien = 100 * 1242 + (kwSuDung - 100) * 1304;
            }
            else if (kwSuDung <= 200)
            {
                tienDien = 100 * 1242 + 50 * 1304 + (kwSuDung - 150) * 1651;
            }
            else
            {
                tienDien = 100 * 1242 + 50 * 1304 + 50 * 1651 + (kwSuDung - 200) * 2912;
            }

            double thueVAT = tienDien * 0.10;
            double tongTien = tienDien + thueVAT;

            Console.WriteLine($"So KW su dung: {kwSuDung} KW");
            Console.WriteLine($"Tien dien chua tinh VAT: {tienDien} VND");
            Console.WriteLine($"Thue VAT: {thueVAT} VND");
            Console.WriteLine($"So tien phai tra (bao gom VAT): {tongTien} VND");
        }
    }
}