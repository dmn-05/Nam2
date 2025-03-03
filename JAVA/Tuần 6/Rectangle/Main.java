import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);
    Rectangle rectangle = new Rectangle();
    rectangle.input(scanner);
    rectangle.output();
    System.out.println("Perimeter: " + rectangle.getPerimeter());
    System.out.println("Area: " + rectangle.getArea());
    scanner.close();
  }
}