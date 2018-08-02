/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mainclass;

import java.util.ArrayList;
import java.util.Scanner;

/**
 *
 * @author KieuXuanToan
 */
public class Ship {
   private  ArrayList<Coordinate> arr=new ArrayList<>();

    public Ship() {
    }

    Ship(ArrayList<Coordinate> lstCoor) {
        this.arr=lstCoor;
    }

    public ArrayList<Coordinate> getArr() {
        return arr;
    }

    public void setArr(ArrayList<Coordinate> arr) {
        this.arr = arr;
    }
    
    
    
}
