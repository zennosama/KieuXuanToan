/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package simpledotcomgame;

/**
 *
 * @author KieuXuanToan
 */
public class SimpleDotCom {
    int[] locationCells;
    int numOfHits=0;
    
    void setLocationCells(int[] locs){
        locationCells=locs;
    }
    
    String checkYourself(String stringGuess){
        int guess=Integer.parseInt(stringGuess);
        String result = "Miss";
        for(int cell : locationCells){
            if (guess==cell) {
                result = "Hit";
                numOfHits++;
                break;
            }
        }
        if (numOfHits==locationCells.length) {
            result="Kill";
        }
        System.out.println(result);
        return result;
    }
}
