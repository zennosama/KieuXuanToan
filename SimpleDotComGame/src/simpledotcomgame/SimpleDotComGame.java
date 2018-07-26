/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package simpledotcomgame;

import java.util.Random;

/**
 *
 * @author KieuXuanToan
 */
public class SimpleDotComGame {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Random rd=new Random();
        int number=rd.nextInt(10);
        System.out.println("So Dau: "+number);
        
        int numOfGuess=0;
        
        GameHelper helper=new GameHelper();
        
        SimpleDotCom theDotCom = new SimpleDotCom();
        
        int randomNum = (int)(Math.random()*number);
        
        System.out.println("So sau: "+randomNum);
        
        int[] locations ={randomNum, randomNum+1, randomNum+2};
        
        theDotCom.setLocationCells(locations);
        
        boolean isAlive=true;
        
        while(isAlive==true){
            String guess=helper.getUserInput("Enter a Number: ");
            String result=theDotCom.checkYourself(guess);
            numOfGuess++;
            if (result.equals("Kill")) {
                isAlive=false;
                System.out.println("You took " + numOfGuess +" Guess");
            }
        }
    }
}
