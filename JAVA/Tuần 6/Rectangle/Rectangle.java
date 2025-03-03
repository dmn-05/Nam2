import java.util.Scanner;

public class Rectangle {
  private double width;
  private double height;

  public Rectangle() {
    this.width = 0;
    this.height = 0;
  }

  public Rectangle(double width, double height) {
    this.width = width;
    this.height = height;
  }

  public void input(Scanner scanner) {
    this.width = scanner.nextDouble();
    this.height = scanner.nextDouble();
  }

  public void output() {
    System.out.println("Width: " + this.width);
    System.out.println("Height: " + this.height);
  }

  public double getPerimeter() {
    return (width + height) * 2;
  }

  public double getArea() {
    return width * height;
  }
}