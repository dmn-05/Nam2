import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);
    Circle circle = new Circle();
    circle.input(scanner);
    circle.output();
    System.out.println("Perimeter: " + circle.getPerimeter());
    System.out.println("Area: " + circle.getArea());
    scanner.close();
  }
}