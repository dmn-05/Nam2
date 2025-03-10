import java.util.Scanner;

public class hocsinh {
    public String Mssv;
    public String Hoten;
    public String Gioitinh;
    public double toan;
    public double van;

    public hocsinh() {
        Mssv = Hoten = Gioitinh = "";
        toan = van = 0;
    }

    public void Nhap() {
        Scanner input = new Scanner(System.in);
        System.out.print("Nhap ma so sinh vien: ");
        Mssv = input.nextLine();
        System.out.print("Nhap ho ten: ");
        Hoten = input.nextLine();
        System.out.print("Nhap gioi tinh: ");
        Gioitinh = input.nextLine();
        System.out.print("Nhap diem toan: ");
        toan = input.nextDouble();
        System.out.print("Nhap diem van: ");
        van = input.nextDouble();
    }

    public void Xuat() {
        System.out.println("ma so sinh vien: " + Mssv);
        System.out.println("ho ten: " + Hoten);
        System.out.println("gioi tinh: " + Gioitinh);
        System.out.println("diem toan: " + toan);
        System.out.println("diem van: " + van);
    }

    public double TinhDTB() {
        return (toan + van) / 2;
    }

    public String XepLoai(double diemtb) {
        if (diemtb < 5) {
            return "Yeu";
        } else if (diemtb < 6.5) {
            return "Trung Binh";
        } else if (diemtb < 8) {
            return "Kha";
        }
        return "Gioi";
    }
}
