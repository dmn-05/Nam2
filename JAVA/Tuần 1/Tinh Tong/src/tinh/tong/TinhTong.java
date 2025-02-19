/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tinh.tong;

import java.util.Scanner;

/**
 *
 * @author SV
 */
public class TinhTong {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        Scanner input = new Scanner(System.in);
        System.out.print("Nhap so thu nhat: ");
        int sothunhat = Integer.parseInt(input.nextLine());
        System.out.print("Nhap so thu hai: ");
        int sothuhai = Integer.parseInt(input.nextLine());
        int tong = sothunhat + sothuhai;
        int hieu = sothunhat - sothuhai;
        int tich = sothunhat * sothuhai;
        float thuong = (float) sothunhat / sothuhai;
        
        System.out.println("Tong: " + tong);
        System.out.println("Hieu: " + hieu);
        System.out.println("Tich: " + tich);
        System.out.println("Thuong: " + thuong);
        
    }
    
}
