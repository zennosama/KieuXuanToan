/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mainclass;

import java.util.Scanner;

/**
 *
 * @author KieuXuanToan
 */
public class Map {

    private String A[][] = {
        {"-", "-", "-", "-", "-"},
        {"-", "-", "-", "-", "-"},
        {"-", "-", "-", "-", "-"},
        {"-", "-", "-", "-", "-"},
        {"-", "-", "-", "-", "-"}
    };

    public Map() {
    }

    public String[][] getA() {
        return A;
    }

    public void setA(String[][] A) {
        this.A = A;
    }

    public void DisplayMap(Map map) {
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                System.out.print(A[i][j] + "\t");
            }
            System.out.println();
            System.out.println();
        }
    }

}
