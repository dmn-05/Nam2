import java.util.Scanner;

public class Bai5_1 {
    public static int[] mang = new int[100];
    public static int n = 6;

    public static void main(String[] args) {
        nhap(mang);
        xuat(mang);
        double sln = solonnhat(mang);
        int solanxh = solanxuathien(mang, sln);
        System.out.println("So lon nhat la: " + sln + "\nSo lan xuat hien: " + solanxh);
    }

    public static void nhap(int []a) {
        Scanner input = new Scanner(System.in);
        for (int i = 0; i < n; i++) {
            mang[i] = input.nextInt();
        }
    }
    public static void xuat(int []a){
        for (int i = 0; i < n; i++) {
            System.out.println("Phan Tu vi tri " + i + " la: " + mang[i] + "\n");
        }
    }
    public static double solonnhat(int [] mang){
        double max = mang[0];
        for (int i = 1; i < n; i++) {
             if (max < mang[i]) {
                max = mang[i];
             }
        }
        return max;
    }
    public static int solanxuathien( int [] mang, double max){
        int dem = 0;
        for (int i = 1; i < n; i++) {
            if (max == mang[i]) {
               dem++;
            }
       }
        return dem;
    }
}
