namespace Bai01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HinhChuNhat hcn = new HinhChuNhat();
            hcn.NhapHinhChuNhat();
            hcn.XuatHinhChuNhat();
            Console.WriteLine("Chu Vi: " + hcn.TinhChuVi());
            Console.WriteLine("Dien Tich: " + hcn.TinhDienTich());
            Console.WriteLine("Duong Cheo: " + hcn.TinhDuongCheo());
        }
    }
}