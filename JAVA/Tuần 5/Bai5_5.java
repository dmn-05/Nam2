import java.util.Scanner;

public class Bai5_5 {
    
    public static void nhapMaTran(int [][]a, int n, int m, Scanner input){
        
        for(int i = 0; i < n; i++){
            a[i] = new int [m];
            for(int j = 0; j < m; j++){
                System.out.println("nhap a["+i+"]"+"["+j+"]: ");
                a[i][j]= input.nextInt();
            }
        }
    }
    public static void xuatMaTran(int [][]a, int n, int m){
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                System.out.print(a[i][j]+ "  ");
            }
            System.out.println("");
        }   
    }
    public static int timPhanTuNhoNhat(int [][]a,int n, int m){
        int min = a[0][0];
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                if(min > a[i][j])
               {
                min = a[i][j];
               }
            }
        }
        return min;
    }
    public static int timPhanTuLeLonNhat(int [][]a,int n, int m){
        int max = a[0][0];
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                if(a[i][j]% 2 ==1){
                    if(max < a[i][j])
                    {
                     max = a[i][j];
                    }
                }
            }
        }
        return max;
    }
    public static int timDongCoTongLonNhat(int[][] a, int n, int m) {
        int maxTong = Integer.MIN_VALUE;
        int dongMax = -1;
        
        for (int i = 0; i < n; i++) {
            int tong = 0;
            for (int j = 0; j < m; j++) {
                tong += a[i][j];
            }
            if (tong > maxTong) {
                maxTong = tong;
                dongMax = i;
            }
        }
        return dongMax;
    }
    public static boolean  snt(int n){
        if(n > 2) return false;
        for(int i = 2; i <= Math.sqrt(n); i++){
            if(n % i == 0){
                return false;
            }
        }
        return true;
    }
    public  static int tinhTongSoKhongLaSNt(int [][]a, int n, int m){
        int kq =0;
            for(int i = 0; i < n; i++){
                for(int j = 0; j < m; j++){
                   if(!snt(a[i][j])){
                    kq += a[i][j];
                   }
                }
            }
         return kq;
    }
    public static void main(String[] args) {
        int dong;
        int cot;
        Scanner input = new Scanner(System.in);
        System.out.println("nhap dong la n: ");
        dong = input.nextInt();
        System.out.println("nhap cot la m: ");
        int [][] a = new int[100][100];
        cot = input.nextInt();
        nhapMaTran(a, dong, cot, input);
        xuatMaTran(a, dong, cot);

        //tim ra phan tu nho nhat
        int min;
        min = timPhanTuNhoNhat(a, dong, cot);
        System.out.println("Phan tu nho nhat: "+ min);

        //tim ra phan tu le lon nhat
        int maxle;
        maxle  = timPhanTuLeLonNhat(a, dong, cot);
        System.out.println("Phan tu le lon nhat: "+maxle);

        //tim dong co tong lon nhat
        int dongLonNhat;
        dongLonNhat = timDongCoTongLonNhat(a, dong, cot);
        System.out.println("Dong co tong lon nhat: "+ dongLonNhat);

        //tinh tong so khong la snt
        int kqkhonglasnt;
        kqkhonglasnt = tinhTongSoKhongLaSNt(a, dong , cot);
        System.out.println("Tong so khong la SNT: "+ kqkhonglasnt);
    }
}