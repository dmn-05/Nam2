import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        Bo conBo = new Bo();
        De conDe = new De();
        conBo.nhap(input);
        conBo.xuat();
        conDe.nhap(input);
        conDe.xuat();
        System.out.println(conBo.TinhLuongSua());
        System.out.println(conDe.TinhLuongSua());
        input.close();
    }
}
