/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package nccsoft.review1;

import java.util.Scanner;

/**
 *
 * @author KieuXuanToan
 */
public class Shapes {
    private int toaDoX;
    private int toaDoY;
    private String color;

    public Shapes() {
        super();
    }

    public Shapes(int toaDoX, int toaDoY, String color) {
        this.toaDoX = toaDoX;
        this.toaDoY = toaDoY;
        this.color = color;
    }
    
    public void InputData(){
        System.out.println("Nhap Toa Do Tam X: ");
        Scanner sc=new Scanner(System.in);
        toaDoX=sc.nextInt();
        System.out.println("Nhap Toa Do Tam Y: ");
        toaDoY=sc.nextInt();
        System.out.println("Nhap Mau Sac: ");
        color=sc.nextLine();
    }
    
    public String ShowData(){
        return String.format("Toa Do Tam: ("+"%-10s"+","+"%-10s"+")"+"\t"+"Mau Sac: %-10s",toaDoX, toaDoY, color );
    }
    
}
