import java.util.Scanner;

public class Circle {
  private double radius;

  public Circle() {
    this.radius = 0;
  }

  public Circle(double radius) {
    this.radius = radius;
  }

  public void input(Scanner scanner) {
    this.radius = scanner.nextDouble();
  }

  public void output() {
    System.out.println("Radius: " + this.radius);
  }

  public double getPerimeter() {
    return 2 * Math.PI * radius;
  }

  public double getArea() {
    return Math.PI * Math.pow(radius, 2);
  }
}