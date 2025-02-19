
import java.util.Scanner;

public class DemoMang1Chieu {
    public static int[] mang = new int[100];
    public static int n = 0;

    public static void main(String[] args) {
        nhap(mang);
        xuat(mang);
        int Tong = tinhtong();
        System.out.println("Tong: " + Tong);
    }

    public static void nhap(int []a) {
        Scanner input = new Scanner(System.in);
        System.out.println("Nhap so luong mang 1 chieu: ");
        n = input.nextInt();
        for (int i = 0; i < n; i++) {
            mang[i] = input.nextInt();
        }
    }
    public static void xuat(int []a){
        for (int i = 0; i < n; i++) {
            System.out.println("Phan Tu vi tri " + i + " la: " + mang[i] + "\n");
        }
    }
    public static int tinhtong(){
        int tong = 0;
        for (int i = 0; i < n; i++) {
             tong += mang[i]; 
        }
        return tong;
    }
}
