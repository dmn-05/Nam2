import java.util.Scanner;

public class HocSinh extends Nguoi {
    private int diemToan;
    private int diemVan;
    private int diemAnhVan;

    public HocSinh() {
        super();
        diemAnhVan = diemToan = diemVan = 0;
    }

    @Override
    public String getType() {
        return "HocSinh";
    }

    public void nhap() {
        Scanner input = new Scanner(System.in);
        super.nhap();
        System.out.print("Nhap diem toan: ");
        diemToan = input.nextInt();
        System.out.print("Nhap diem van: ");
        diemVan = input.nextInt();
        System.out.print("Nhap diem anh van: ");
        diemAnhVan = input.nextInt();
    }

    public void xuat() {
        super.xuat();
        System.out.println("diem toan: " + diemToan);
        System.out.println("diem van: " + diemVan);
        System.out.println("diem anh van: " + diemAnhVan);
    }

    public float tinhdiemtb() {
        return (diemAnhVan + diemToan + diemVan) / 3;
    }
}
