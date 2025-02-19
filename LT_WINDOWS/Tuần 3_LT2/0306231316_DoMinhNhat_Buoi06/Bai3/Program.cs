namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TamGiac TG = new TamGiac();
            TG.NhapTamGiac();
            TG.XuatTamGiac();
            Console.WriteLine($"Chu vi la: {TG.ChuVi()}");
            Console.WriteLine($"Dien tich la: {TG.DienTich()}");
            Diem TT = new Diem();
            TT = TG.TrongTam();
            Console.WriteLine($"Trong tam tam giac la: \nx = {TT.x}\ny = {TT.y}");
        }
    }
}