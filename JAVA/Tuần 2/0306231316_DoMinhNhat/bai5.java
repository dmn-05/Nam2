package bai5;

import java.util.Scanner;

public class bai5 {
    public static void main(String[] args) {
        Scanner input =  new Scanner(System.in);
        System.out.println("Nhap so phut: ");
        long phut = input.nextLong();
        System.out.println(phut/525600 + " nam");
        System.out.println((phut%525600) / 1440 + "ngay");
    }    
}
