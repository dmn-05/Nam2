namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DanhSachThiSinh List = new DanhSachThiSinh();
            List.Nhap();
            List.Xuat();
            List.XuatTSDau();
            List.XuatTSLiet();
            List.xuatthukhoa();
            List.xuatbetkhoa();

        }
    }
}