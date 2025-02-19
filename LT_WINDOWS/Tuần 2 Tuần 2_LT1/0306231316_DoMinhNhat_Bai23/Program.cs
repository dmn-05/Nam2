namespace _0306231316_DoMinhNhat_Bai23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen duong N: ");
            int soNguyenDuong = int.Parse(Console.ReadLine());
            int soBanDau = soNguyenDuong;

            int tongChuSo = 0;
            int soLuongSoLe = 0;
            int chuSoLonNhat = 0;
            int chuSoNhoNhat = 9;
            int tongChuSoNguyenTo = 0;
            bool toanSoChan = true;
            int[] demChuSo = new int[10];


            while (soNguyenDuong > 0)
            {
                int chuSo = soNguyenDuong % 10;


                tongChuSo += chuSo;

                if (chuSo % 2 != 0)
                    soLuongSoLe++;

                if (chuSo > chuSoLonNhat)
                    chuSoLonNhat = chuSo;

                if (chuSo < chuSoNhoNhat)
                    chuSoNhoNhat = chuSo;

                if (chuSo % 2 != 0)
                    toanSoChan = false;

                if (laSoNguyenTo(chuSo))
                    tongChuSoNguyenTo += chuSo;

                demChuSo[chuSo]++;

                soNguyenDuong /= 10;
            }

            Console.WriteLine("a) Tong cac chu so: " + tongChuSo);
            Console.WriteLine("b) So luong cac so le: " + soLuongSoLe);
            Console.WriteLine("c) Chu so lon nhat: " + chuSoLonNhat);
            Console.WriteLine("d) N co toan chan hay khong? " + (toanSoChan ? "Co" : "Khong"));
            Console.WriteLine("e) So luong chu so nho nhat: " + demChuSo[chuSoNhoNhat]);
            Console.WriteLine("f) Tong cac chu so la so nguyen to: " + tongChuSoNguyenTo);
        }

        static bool laSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

    }
}