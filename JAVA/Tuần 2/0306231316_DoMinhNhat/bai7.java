package bai7;

import java.util.Scanner;

public class bai7 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        double a1 = input.nextDouble();
        double a2 = input.nextDouble();
        double b1 = input.nextDouble();
        double b2 = input.nextDouble();
        double c1 = input.nextDouble();
        double c2 = input.nextDouble();
        double sab = Math.sqrt(Math.pow(a1 - b1, 2) + Math.pow(a2 - b2, 2));
        double sac = Math.sqrt(Math.pow(a1 - c1, 2) + Math.pow(a2 - c2, 2));
        double sbc = Math.sqrt(Math.pow(b1 - c1, 2) + Math.pow(b2 - c2, 2));
        double p = (sab + sac + sbc) / 2;
        double dientich = Math.sqrt(p * (p - sab) * (p - sac) * (p - sbc));

        System.out.println("do dai sab: " + sab);
        System.out.println("do dai sac: " + sac);
        System.out.println("do dai sbc: " + sbc);

        System.out.println("nua tam giac: " + p);

        System.out.println("dien tich: " + dientich);
    }
}
