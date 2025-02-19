
import java.util.Scanner;

public class chuong3 {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        // System.out.print("Nhap a: ");
        // double a = input.nextInt();
        // System.out.print("Nhap b: ");
        // double b = input.nextInt();
        // System.out.print("Nhap c: ");
        // double c = input.nextInt();

        System.out.print("Nhap bai can chay: ");
        int chucnang = input.nextInt();

        switch (chucnang) {
            case 1:
                System.out.print("Nhap a: ");
                int a1 = input.nextInt();
                System.out.print("Nhap b: ");
                int b1 = input.nextInt();
                System.out.println(bai1(a1, b1));
                break;
            case 2:
                System.out.print("Nhap a: ");
                double a2 = input.nextDouble();
                System.out.print("Nhap b: ");
                double b2 = input.nextDouble();
                System.out.print("Nhap c: ");
                double c2 = input.nextDouble();
                bai2(a2, b2, c2);
            case 3:
                double a3 = 5000;
                double b3 = 0;
                double c3 = 0;
                System.out.print("Nhap tien can kiem: ");
                double d3 = input.nextDouble();
                bai3(a3, b3, c3, d3);
                break;
            case 4:
                int thang, nam;
                do {
                    System.out.println("Nhap Thang: ");
                    thang = input.nextInt();
                } while (thang > 12 || thang < 1);
                do {
                    System.out.println("Nhap Nam: ");
                    nam = input.nextInt();
                } while (nam < 0);
                System.out.println(bai4(thang, nam));
                break;
            case 5:
                bai5a();
                System.out.println("\n");
                bai5b(6);
                System.out.println("\n");
                bai5c(6);
                System.out.println("\n");
                bai5d(6);
                System.out.println("\n");
                bai5e(6);
                System.out.println("\n");
                break;
            case 6:
                bai6(7);
                break;
            case 7:
                System.out.println("nhap n: ");
                int n = input.nextInt();
                bai7(n);
                break;
            case 8:
                double z;
                System.out.println("nhap n");
                z = input.nextDouble();
                double kq = bai8a(z);
                System.out.println("kq: " + kq);
                System.out.println("nhap n: ");
                int m = input.nextInt();
                kq = bai8b(m);
                System.out.println("kq: " + kq);
                break;
            case 9:
                System.out.println("Nhap nam: ");
                int inam = input.nextInt();
                System.out.println("Nhap thu ngay dau nam");
                int thu = input.nextInt();
                bai9(inam, thu);
            case 10:
                System.out.println("Nhap so dien cu: ");
                int sodiencu = input.nextInt();
                int sodienmoi;
                do {
                    System.out.println("Nhap so dien moi: ");
                    sodienmoi = input.nextInt();
                } while (sodiencu > sodienmoi);
                bai10(sodiencu, sodienmoi);
            case 11:
                System.out.println("Nhap ax: ");
                int ax =  input.nextInt();
                System.out.println("Nhap ay: ");
                int ay =  input.nextInt();
                System.out.println("Nhap bx: ");
                int bx =  input.nextInt();
                System.out.println("Nhap by: ");
                int by =  input.nextInt();
                System.out.println("Nhap cx: ");
                int cx =  input.nextInt();
                System.out.println("Nhap cy: ");
                int cy =  input.nextInt();
                bai11(ax, ay, bx, by, cx, cy);
            default:
                break;
        }
        input.close();

    }

    public static int bai1(int a, int b) {
        while (b != 0) {
            int temp = a % b;
            a = b;
            b = temp;
        }
        return a;
    }

    public static void bai2(double a, double b, double c) {

        if (a + b > c && a + c > b && b + c > a) {
            if (a == b && b == c) {
                System.out.println("Tam giac deu");
            } else if (a == b || a == c || b == c) {
                if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a) {
                    System.out.println("Tam giac vuong can");
                } else {
                    System.out.println("Tam giac can");
                }
            } else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a) {
                System.out.println("Tam giac vuong");
            } else {
                System.out.println("Tam giac thuong");
            }

        }
        else{
            System.out.println("Khong phai tam giac");
        }
    }

    public static void bai3(double luongcb, double tienhh, double tienbh, double tienck) {
        while (luongcb + tienhh < tienck) {
            tienbh += 0.01;
            if (tienbh <= 5000) {
                tienhh = tienbh * 0.08;
            } else if (tienbh <= 10000) {
                tienhh = 5000 * 0.08 + (tienbh - 5000) * 0.1;
            } else {
                tienhh = 5000 * 0.08 + 5000 * 0.1 + (tienbh - 10000) * 0.1;
            }
        }
        System.out.printf("Can ban hang $%.2f de dat muc thu nhap $%.2f/nam\n", tienbh, tienck);
    }

    public static int bai4(int thang, int nam) {
        switch (thang) {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                return 31;
            case 2:
                if (nam % 100 != 0 && nam % 4 == 0 || nam % 400 == 0) {
                    return 29;
                } else {
                    return 28;
                }
            default:
                return 30;
        }
    }

    public static void bai5a() {
        for (int i = 0; i < 8; i++) {
            for (int k = 0; k < (7 - i) * 3; k++) {
                System.out.print(" ");
            }
            for (int j = 0; j <= i; j++) {
                System.out.printf("%3d", (int) Math.pow(2, j));
            }
            for (int j = i - 1; j >= 0; j--) {
                System.out.printf("%3d", (int) Math.pow(2, j));
            }
            System.out.println();
        }
    }

    public static void bai5b(int rows) {
        for (int i = 1; i <= rows; i++) {
            for (int j = 1; j <= i; j++) {
                System.out.print(j + " ");
            }
            System.out.println();
        }
    }

    public static void bai5c(int rows) {
        for (int i = 0; i < rows; i++) {
            for (int j = 1; j <= rows - i; j++) {
                System.out.print(j + " ");
            }
            System.out.println();
        }
    }

    public static void bai5d(int rows) {
        for (int i = 1; i <= rows; i++) {
            for (int j = i; j >= 1; j--) {
                System.out.print(j + " ");
            }
            System.out.println();
        }
    }

    public static void bai5e(int rows) {
        for (int i = 0; i < rows; i++) {
            for (int j = 1; j <= rows - i; j++) {
                System.out.print(j + " ");
            }
            System.out.println();
        }
    }

    public static void bai6(int n) {
        for (int i = 1; i <= n; i++) {
            for (int j = n - i; j > 0; j--) {
                System.out.print("  ");
            }
            for (int j = i; j >= 1; j--) {
                System.out.print(j + " ");
            }
            for (int j = 2; j <= i; j++) {
                System.out.print(j + " ");
            }
            System.out.println();
        }
    }

    public static void bai7(int n) {
        for (int i = 2; i < n; i++) {
            boolean laSoNguyenTo = true;
            for (int j = 2; j * j <= i; j++) {
                if (i % j == 0) {
                    laSoNguyenTo = false;
                    break;
                }
            }
            if (laSoNguyenTo) {
                System.out.print(i + " ");
            }
        }
        System.out.println();
    }

    public static double bai8a(double a) {
        double pi = 0;
        double temp = 1;
        int n = 0;
        while (Math.abs(temp) >= a) {
            pi += temp;
            n++;
            temp = Math.pow(-1, n) / (2.0 * n + 1);
        }
        return 4 * pi;
    }

    public static double bai8b(int n) {
        double e = 1;
        double aa = 1;
        for (int i = 1; i <= n; i++) {
            aa *= i;
            e += 1.0 / aa;
        }
        return e;
    }

    public static void bai9(int nam, int thuNgayDauNam) {
        int[] ngayTrongThang = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0) {
            ngayTrongThang[1] = 29;
        }

        String[] tenThu = { "Chu Nhat", "Thu Hai", "Thu Ba", "Thu Tu", "Thu Nam", "Thu Sau", "Thu Bay" };

        int thuHienTai = thuNgayDauNam;
        System.out.println("January 1, " + nam + " is " + tenThu[thuNgayDauNam - 1]);
        for (int i = 1; i < 12; i++) {
            thuHienTai = (thuHienTai + ngayTrongThang[i - 1]) % 7;
            if (thuHienTai == 0)
                thuHienTai = 7;
            System.out.println(getMonthName(i + 1) + " 1, " + nam + " la " + tenThu[thuHienTai - 1]);
        }
    }

    private static String getMonthName(int month) {
        String[] monthNames = { "January", "February", "March", "April", "May", "June", "July", "August", "September",
                "October", "November", "December" };
        return monthNames[month - 1];
    }

    public static void bai10(int sodiencu, int sodienmoi) {
        int sodiendung = sodienmoi - sodiencu;
        double thanhtien;
        if (sodiendung < 50) {
            thanhtien = sodiendung * 1.750;
        } else if (sodiendung < 100) {
            thanhtien = 49 * 1.750 + (sodiendung - 49) * 2.225;
        } else if (sodiendung < 200) {
            thanhtien = 49 * 1.750 + 50 * 2.225 + (sodiendung - 99) * 2.750;
        } else {
            thanhtien = 49 * 1.750 + 50 * 2.225 + 100 * 2.750 + (sodiendung - 199) * 3.250;
        }

        System.out.println("So ki dien ban dung la: " + sodiendung + "\n");
        System.out.println("So tien phai tra la: " + thanhtien + "\n");
    }
    public static void bai11(int ax, int ay, int bx, int by, int cx, int cy){
        double ab = Math.sqrt(Math.pow((ax-bx),2) + Math.pow((ay-by), 2));
        double ac = Math.sqrt(Math.pow((ax-cx),2) + Math.pow((ay-cy), 2));
        double bc = Math.sqrt(Math.pow((bx-cx),2) + Math.pow((by-cy), 2));
        bai2(ac, ab, bc);
        double p = (ab + bc + ac) / 2;
        double dientich = Math.sqrt(p*(p-ab)*(p-bc)*(p-ac));
        System.out.println("Dien tich la: " + dientich);
    }
}
