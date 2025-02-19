import java.util.*;

public class Bai5_3 {
       
    public static void main(String[] args){
        int [][] matran;
        int [][] matran2;
        int [][] tong;
        int [][] tich;
        matran = nhap();
        matran2 = nhap();
        tong = tinhtong(matran, matran2);
        xuat(tong);
        tich = tinhnhan(matran, matran2);
        xuat(tich);
    }
    
    public static int[][] nhap(){
        int dong = 0;
        int cot = 0;
        Scanner input = new Scanner(System.in);
        System.out.println("Nhap so dong cua B bang cot (A): ");
        dong = input.nextInt();
        System.out.println("Nhap so cot: ");
        cot = input.nextInt();
        int[][] a = new int[dong][cot];
        for (int i = 0; i < dong ; i++) {
            for (int j = 0; j < cot ; j++) {
                System.out.print("a["+i+"]["+j+"]: ");
                a[i][j] = input.nextInt();
            }    
        }
        return a;
    }

    public static void xuat(int [][] matran){
        for (int i = 0; i < matran.length ; i++) {            
            for (int j = 0; j < matran[0].length ; j++) {
                System.out.print( matran[i][j] + " ");
            }    
            System.out.println("");
        }
    }

    public static int[][] tinhtong(int [][] matran, int [][] matran2){
        int [][] a = new int[matran.length][matran[0].length];
        for (int i = 0; i < matran.length ; i++) {            
            for (int j = 0; j < matran[0].length ; j++) {
                a[i][j] = matran[i][j] + matran2[i][j];
            }    
        }
        return a;
    }
    public static int[][] tinhnhan(int[][] A, int[][] B) {
        int m = A.length;    // Số dòng của A
        int n = A[0].length; // Số cột của A (cũng là số dòng của B)
        int p = B[0].length; // Số cột của B
        int[][] C = new int[m][p];
        // Nhân ma trận
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < p; j++) {
                C[i][j] = 0;
                for (int k = 0; k < n; k++) {
                    C[i][j] += A[i][k] * B[k][j];
                }
            }
        }
        return C;
    }
}
