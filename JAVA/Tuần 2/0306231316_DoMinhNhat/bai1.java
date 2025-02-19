package bai1;
import java.util.Scanner;

public class bai1 {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
         
        double celsius = input.nextDouble() ; 
        double fahrenheit = (9.0 / 5) * celsius + 32;
        System.out.println(fahrenheit);
        input.close();
    }
}
