
package chuong3;
import java.util.Scanner;

public class Chuong3 {

   
    public static void main(String[] args) {
        Scanner input  = new Scanner(System.in);
          System.out.print("Nhap a: ");
          double a = input.nextInt();
          System.out.print("Nhap b: ");
          double b = input.nextInt();
          System.out.print("Nhap c: ");
          double c = input.nextInt();
          bai1(a,b);
    }
    public static int bai01(int a, int b){
       while (b!=0){
           int temp = a%b;
           a = b;
           b = temp;
       }
       return a;
    }
    public static void bai02(double a, double b, double c){
        if (a<=0 || b<=0) {
            
        }
        if (a+b>c && a+c>b && b+c>a) {
            if (a==b && b==c) {
                System.out.println("Tam giac deu");
            }
            else if (a==b || a==c || b==c){
                 System.out.println("Tam giac can");
            }
            else if (a*a + b*b == c*c || a*a + c*c == b*b || b*b + c*c == a*a) {
                System.out.println("Tam giac vuong");
            }
            
        }
    }
}
