public class Main {
    public static void main(String[] args) {
        student hs = new student();
        hs.nhap();
        System.out.println("Diem trung binh: " + hs.diemtb());
        System.out.println("Xep loai: " + hs.xeploai(hs.diemtb()));
    }
}
