/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package simpledotcomgame;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.*;

/**
 *
 * @author KieuXuanToan
 */
public class GameHelper {
    public String getUserInput(String prompt){
        String inputLine =null;
        System.out.println(prompt+" ");
        try {
            BufferedReader is=new BufferedReader(new InputStreamReader(System.in));
            inputLine=is.readLine();
            if(inputLine.length()==0) return null;
            
        } catch (IOException e) {
            System.out.println("IOException: "+e);
        }
        return inputLine;
    }
}
