import java.util.Scanner;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;

public class lophoc {
    public ArrayList<hocsinh> DanhSachHocSinh;
    public int soluong;

    public lophoc() {
        DanhSachHocSinh = new ArrayList<>();
    }

    public void NhapLopHoc() {
        Scanner input = new Scanner(System.in);
        System.out.print("Nhap so luong hoc sinh: ");
        soluong = input.nextInt();
        input.nextLine(); // Đọc ký tự xuống dòng còn sót lại

        for (int i = 0; i < soluong; i++) {
            System.out.println("Nhap thong tin hoc sinh thu " + (i + 1) + ":");
            hocsinh hs = new hocsinh();
            hs.Nhap();
            DanhSachHocSinh.add(hs);
        }
    }

    public void XuatLopHoc() {
        for (hocsinh hs : DanhSachHocSinh) {
            hs.Xuat();
        }
    }

    public void TimHSMssv() {
        String ma;
        hocsinh hs = new hocsinh();
        Scanner input = new Scanner(System.in);
        System.out.print("Nhap ma so sinh vien: ");
        ma = input.nextLine();
        for (int i = 0; i < soluong; i++) {
            hs = DanhSachHocSinh.get(i);
            if (ma.equalsIgnoreCase(hs.Mssv.trim())) {
                hs.Xuat();
                break;
            }
        }
    }

    public void TimHSTen() {
        String Ten;
        Scanner input = new Scanner(System.in);
        System.out.print("Nhap ho ten sinh vien: ");
        Ten = input.nextLine();
        for (hocsinh hs : DanhSachHocSinh) {
            String ten = layTen(hs.Hoten);
            if (Ten.equalsIgnoreCase(ten)) {
                hs.Xuat();
            }
        }
    }

    public void HSG() {
        for (hocsinh hs : DanhSachHocSinh) {
            if (hs.XepLoai(hs.TinhDTB()) == "Gioi") {
                hs.Xuat();
            }
        }
    }

    public void SapXepDTB() {
        hocsinh hs = new hocsinh();
        for (int i = 0; i < soluong - 1; i++) {
            for (int j = i + 1; j < soluong; j++) {
                if (DanhSachHocSinh.get(i).TinhDTB() < DanhSachHocSinh.get(j).TinhDTB()) {
                    Collections.swap(DanhSachHocSinh, i, j);
                }
            }
        }
    }

    public String layTen(String hoTen) {
        String[] parts = hoTen.trim().split("\\s+");
        return parts[parts.length - 1]; // Lấy phần cuối cùng (tên)
    }
}