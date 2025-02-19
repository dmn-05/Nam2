namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhanSo ps1 = new PhanSo();
            PhanSo ps2 = new PhanSo();

            ps1.NhapPhanSo();
            ps2.NhapPhanSo();

            ps1.XuatPhanSo();
            ps2.XuatPhanSo();

            Console.Write("Tong: ");
            ps1.Tong(ps2).XuatPhanSo();
            Console.Write("Hieu: ");
            ps1.Hieu(ps2).XuatPhanSo();
            Console.Write("Tich: ");
            ps1.Tich(ps2).XuatPhanSo();
            Console.Write("Thuong: ");
            ps1.Thuong(ps2).XuatPhanSo();
        }
    }
}