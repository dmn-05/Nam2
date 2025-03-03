import java.util.Scanner;

public class Point {
    public double x;
    public double y;

    public void nhap() {
        Scanner input = new Scanner(System.in);
        System.out.print("Nhap toa do x: ");
        this.x = input.nextInt();
        System.out.print("Nhap toa do y: ");
        this.y = input.nextInt();
    }

    public double TinhKC(Point diem) {
        return Math.sqrt(Math.pow((diem.x - this.x), 2) + Math.pow((diem.y - this.y), 2));
    }
}
