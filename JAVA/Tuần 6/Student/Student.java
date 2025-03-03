import java.util.Scanner;

public class student {

    public String mssv;
    public String hoten;
    public double toan;
    public double van;

    public student() {
        mssv = "";
        hoten = "";
        toan = 0;
        van = 0;
    }

    public void nhap() {
        Scanner input = new Scanner(System.in);
        System.out.print("Nhap mssv: ");
        this.mssv = input.nextLine();
        System.out.print("Nhap ho ten: ");
        this.hoten = input.nextLine();
        System.out.print("Nhap diem toan: ");
        this.toan = input.nextDouble();
        System.out.print("Nhap diem van: ");
        this.van = input.nextDouble();
    }

    public double diemtb() {
        return (toan + van) / 2;
    }

    public String xeploai(double diemtb) {
        if (diemtb < 3.5) {
            return "Kem";
        } else if (diemtb < 5) {
            return "Yeu";
        } else if (diemtb < 6.5) {
            return "Trung Binh";
        } else if (diemtb < 8) {
            return "Kha";
        }
        return "Gioi";
    }
}
