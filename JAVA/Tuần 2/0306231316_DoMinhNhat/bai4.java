package bai4;

import java.util.Scanner;

public class bai4 {
    public static void main(String[] args) {
        Scanner input  = new Scanner(System.in);
        System.out.println("Nhap so found");
        double found = input.nextDouble();
        System.out.println("So kilogram: " + found * 0.454);
    }    
}
