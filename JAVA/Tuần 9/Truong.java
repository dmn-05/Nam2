import java.util.LinkedList;
import java.util.Scanner;

public class Truong {
    private LinkedList<Nguoi> dsNguoi;

    public Truong() {
        dsNguoi = new LinkedList<>();
    }

    public void nhap() {
        Scanner input = new Scanner(System.in);
        System.out.print("Nhap so luong nguoi: ");
        int soluong = input.nextInt();
        input.nextLine();

        for (int i = 0; i < soluong; i++) {
            System.out.println("Ban can nhap: (1. HocSinh; 2. GiaoVien)");
            String temp = input.nextLine();

            if (temp.equals("HocSinh")) {
                HocSinh hs = new HocSinh();
                hs.nhap();
                dsNguoi.add(hs);
            } else {
                GiaoVien gv = new GiaoVien();
                gv.nhap();
                dsNguoi.add(gv);
            }
        }
    }

    public void xuat() {
        for (Nguoi nguoi : dsNguoi) {
            nguoi.xuat();
        }
    }

    public void diemtbcaonhat() {
        double maxDiem = -1; // Khởi tạo điểm trung bình thấp nhất
        HocSinh hsMax = null; // Lưu sinh viên có điểm cao nhất

        for (Nguoi nguoi : dsNguoi) {
            if (nguoi instanceof HocSinh) { // Kiểm tra nếu là Học Sinh
                HocSinh hs = (HocSinh) nguoi; // Ép kiểu từ Nguoi sang HocSinh
                if (hs.tinhdiemtb() > maxDiem) {
                    maxDiem = hs.tinhdiemtb();
                    hsMax = hs; // Lưu học sinh có điểm cao nhất
                }
            }
        }

        // In thông tin học sinh có điểm cao nhất
        if (maxDiem != -1) {
            System.out.println("diem trung binh cao nhat:");
            System.out.println(maxDiem);
        } else {
            System.out.println("Khong co hoc sinh nao trong danh sach.");
        }
    }

    public void hscodiemtbcaonhat() {
        double maxDiem = -1; // Khởi tạo điểm trung bình thấp nhất
        HocSinh hsMax = null; // Lưu sinh viên có điểm cao nhất

        for (Nguoi nguoi : dsNguoi) {
            if (nguoi instanceof HocSinh) { // Kiểm tra nếu là Học Sinh
                HocSinh hs = (HocSinh) nguoi; // Ép kiểu từ Nguoi sang HocSinh
                if (hs.tinhdiemtb() > maxDiem) {
                    maxDiem = hs.tinhdiemtb();
                    hsMax = hs; // Lưu học sinh có điểm cao nhất
                }
            }
        }

        // In thông tin học sinh có điểm cao nhất
        if (hsMax != null) {
            System.out.println("Hoc sinh co diem trung binh cao nhat:");
            hsMax.xuat();
        } else {
            System.out.println("Khong co hoc sinh nao trong danh sach.");
        }
    }

    public void thamniencaonhat() {
        double ThamNienmax = -1;
        GiaoVien gvMax = null;

        for (Nguoi nguoi : dsNguoi) {
            if (nguoi instanceof GiaoVien) {
                GiaoVien gv = (GiaoVien) nguoi;
                if (gv.tinhthamnien() > ThamNienmax) {
                    ThamNienmax = gv.tinhthamnien();
                    gvMax = gv;
                }
            }
        }

        // In thông tin học sinh có điểm cao nhất
        if (ThamNienmax != -1) {
            System.out.println("Tham nien cao nhat:");
            System.out.println(ThamNienmax);
        } else {
            System.out.println("Khong co giao vien nao trong danh sach.");
        }
    }

    public void nguoicothamniencaonhat() {
        double ThamNienmax = -1;
        GiaoVien gvMax = null;

        for (Nguoi nguoi : dsNguoi) {
            if (nguoi instanceof GiaoVien) {
                GiaoVien gv = (GiaoVien) nguoi;
                if (gv.tinhthamnien() > ThamNienmax) {
                    ThamNienmax = gv.tinhthamnien();
                    gvMax = gv;
                }
            }
        }

        // In thông tin học sinh có điểm cao nhất
        if (gvMax != null) {
            System.out.println("nguoi co tham nien cao nhat:");
            gvMax.xuat();
        } else {
            System.out.println("Khong co giao vien nao trong danh sach.");
        }
    }
}
