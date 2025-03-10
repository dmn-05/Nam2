import java.util.Scanner;

public abstract class GiaSuc {
    protected String Maso;
    protected float CanNang;
    protected int Tuoi;

    GiaSuc() {
        Maso = "";
        CanNang = 0;
        Tuoi = 0;
    }

    public void nhap(Scanner input) {
        System.out.print("Nhap ma so: ");
        Maso = input.nextLine();
        System.out.print("Nhap can nang: ");
        CanNang = input.nextFloat();
        System.out.print("Nhap tuoi: ");
        Tuoi = input.nextInt();
        input.nextLine();
    }

    public void xuat() {
        System.out.println("Ma so: " + Maso);
        System.out.println("Can nang: " + CanNang);
        System.out.println("Tuoi: " + Tuoi);
    }

    public abstract float TinhLuongSua();

    public abstract String getType();
}
