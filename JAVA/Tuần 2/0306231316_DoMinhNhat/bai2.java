package baij2;
import java.util.Scanner;


public class bai2 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.println("Nhap ban kinh: ");
        double bk = input.nextDouble();
        System.out.println("chu vi la: " + 2*Math.PI * bk);
        System.out.println("dien tich la: " + bk*Math.pow( Math.PI,2));

    }
}
