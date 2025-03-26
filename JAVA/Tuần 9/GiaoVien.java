import java.time.LocalDate;
import java.util.Scanner;

public class GiaoVien extends Nguoi {
    private int namBatDau;
    private String chuyenMon;

    // Hàm khởi tạo của lớp GiaoVien
    public GiaoVien() {
        super();
        namBatDau = 0;
        chuyenMon = "";
    }

    @Override
    public String getType() {
        return "GiaoVien";
    }

    @Override
    public void nhap() {
        Scanner input = new Scanner(System.in);
        super.nhap();
        System.out.print("Nhap nam bat dau: ");
        namBatDau = input.nextInt();
        System.out.println("Nhap chuyen mon: ");
        chuyenMon = input.nextLine();
    }

    public void xuat() {
        super.xuat();
        System.out.println("bat dau: " + namBatDau);
        System.out.println("chuyen mon: " + chuyenMon);
    }

    public int tinhthamnien() {
        return (LocalDate.now().getYear() - namBatDau);
    }
}
