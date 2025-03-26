import java.util.Scanner;

public abstract class Nguoi {
    protected String hoTen;
    protected int namSinh;
    protected String noiSinh;
    protected String diaChi;

    public Nguoi() {
        hoTen = "";
        namSinh = 0;
        noiSinh = "";
        diaChi = "";
    }

    public void nhap() {
        Scanner input = new Scanner(System.in);
        System.out.print("Hay nhap ho ten: ");
        hoTen = input.nextLine();
        System.out.print("Hay nhap nam sinh: ");
        namSinh = input.nextInt();
        input.nextLine();
        System.out.print("Hay nhap noi sinh: ");
        noiSinh = input.nextLine();
        System.out.print("Hay nhap dia chi: ");
        diaChi = input.nextLine();
    }

    public void xuat() {
        System.out.println("ho ten:" + hoTen);
        System.out.println("nam sinh: " + namSinh);
        System.out.println("noi sinh: " + noiSinh);
        System.out.println("dia chi: " + diaChi);
    }

    public abstract String getType();
}