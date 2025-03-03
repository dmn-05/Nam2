public class Main {
    public static void main(String[] args) {
        System.out.println("Nhap toa do diem thu nhat: ");
        Point diem1 = new Point();
        System.out.println("Nhap toa do diem thu hai: ");
        Point diem2 = new Point();
        diem1.nhap();
        diem2.nhap();
        System.out.println("Khoang cach hai diem: " + diem1.TinhKC(diem2));
    }
}
