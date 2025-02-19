import java.util.*;

public class Bai5_2 {
    public static char[] mang = new char[100];
    public static int n = 100;
    public static char [] mangchu = new char[26];

    public static void main(String[] args) {
        nhap(mang);
        xuat(mang);
        ganmangchu();
        System.out.print("\nTan so xuat hien:\n");
        for (int i = 0; i < mangchu.length; i++) {
            int ts = TanSoXuatHien(mangchu[i]);
            System.out.println(mangchu[i] + ": " + ts); 
        }
    }

    public static void ganmangchu() {
        // Gán giá trị cho mảng ký tự từ 'a' đến 'z'
        for (int i = 0; i < 26; i++) {
            mangchu[i] = (char)(97 + i);
        }
    }

    public static void nhap(char []a) {
        Random rand = new Random();

        for (int i = 0; i < mang.length; i++) {
            mang[i] = (char)(rand.nextInt(26) + 'a');
        }
    }

    public static void xuat(char []mang){
        for (int i = 0; i < mang.length; i++) {
           System.out.print(mang[i] + " "); 
        }
       
    }
    public static int TanSoXuatHien(char a){
        int dem = 0;
        for (int i = 0; i < mang.length; i++) {
            if (a == mang[i]) {
                dem++;
            }
        }
        return dem;
    }
}

