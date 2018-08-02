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
public class MainClass {

    public Map putShipOnMap(Player pl, Map map) {
        Ship ship = pl.getS();
        ArrayList<Coordinate> lstCoorShip = ship.getArr();
        String[][] arr = map.getA();
        for (int i = 0; i < lstCoorShip.size(); i++) {
            arr[lstCoorShip.get(i).getX()][lstCoorShip.get(i).getY()] = "H";
        }
        map.setA(arr);
        return map;
    }

    public Map CreateMap() {
        System.out.println(".: Map Created :. \n");
        Map newMap = new Map();
        newMap.DisplayMap(newMap);
        return newMap;
    }

    public Player CreatePlayer() {
        int x1, y1, x2, y2, x3, y3;
        Scanner sc = new Scanner(System.in);

        do {
            System.out.println("Nhap X1: ");
            x1 = sc.nextInt();
            System.out.println("Nhap Y1: ");
            y1 = sc.nextInt();
            if (x1 > 4 || y1 > 4) {
                System.out.println("Toa do nam ngoai Map. Moi Nhap Lai.");
            }
        } while (x1 > 4 && y1 > 4);
        Coordinate coor1 = new Coordinate(x1, y1);

        do {
            System.out.println("Nhap X2: ");
            x2 = sc.nextInt();
            System.out.println("Nhap Y2: ");
            y2 = sc.nextInt();
            if (x2 > 4 || y2 > 4) {
                System.out.println("Toa do nam ngoai Map. Moi Nhap Lai.");
            }
        } while (x2 > 4 && y2 > 4);
        Coordinate coor2 = new Coordinate(x2, y2);

        do {
            System.out.println("Nhap X3: ");
            x3 = sc.nextInt();
            System.out.println("Nhap Y3: ");
            y3 = sc.nextInt();
            if (x3>4 || y3>4) {
                System.out.println("Toa do nam ngoai Map. Moi Nhap Lai.");
            }
        } while (x3 > 4 && y3 > 4);
        Coordinate coor3 = new Coordinate(x3, y3);

        ArrayList<Coordinate> lstCoor = new ArrayList<>();
        lstCoor.add(coor1);
        lstCoor.add(coor2);
        lstCoor.add(coor3);
        Player pl = new Player(new Ship(lstCoor));
        return pl;
    }

    public boolean CheckEndGame(Player pl1, Player pl2) {
        if (pl1.getMark() == 0 || pl2.getMark() == 0) {
            return true;
        }
        return false;
    }

    public void Shoot(Map map, Player pl) {
        System.out.println("Nhap Toa Do Shoot: ");
        int x, y;
        Scanner sc = new Scanner(System.in);
        do {
            System.out.println("Toa Do X: ");
            x = sc.nextInt();
            System.out.println("Toa Do Y: ");
            y = sc.nextInt();
            if (x > 5 || y > 5) {
                System.out.println("Toa do nam ngoai Map. Xin Nhap Lai.");
            }
        } while (x > 5 && y > 5);
        Coordinate coor = new Coordinate(x, y);
        UpdateMap(map, coor, pl);
        UpdatePlayer(coor, pl);

    }

    public void UpdateMap(Map map, Coordinate coor, Player pl) {
        String A[][] = map.getA();
        if (CheckShoot(coor, pl) == true) {
            A[coor.getX()][coor.getY()] = "x"; //
            System.out.println("Hitt.");
        } else {
            A[coor.getX()][coor.getY()] = "o"; // 
            System.out.println("Misss.");
        }
        map.setA(A);
    }

    public void UpdatePlayer(Coordinate coor, Player pl) {
        if (CheckShoot(coor, pl) == true) {
            pl.setMark(pl.getMark() - 1);
        }
    }

    public boolean CheckShoot(Coordinate coor, Player pl) {
        ArrayList<Coordinate> lstCoor = pl.getS().getArr();
        for (int i = 0; i < lstCoor.size(); i++) {
            if (coor.getX() == lstCoor.get(i).getX() && coor.getY() == lstCoor.get(i).getY()) {
                return true;
            }
        }
        return false;
    }

    public void CheckWin(Player pl1, Player pl2) {
        if (CheckEndGame(pl1, pl2)) {
            if (pl1.getMark() > 0) {
                System.out.println("Player 1 WWin");
            } else {
                System.out.println("Player 2 WWin.");
            }
        }
    }

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        MainClass main = new MainClass();
        Map map = main.CreateMap();

        System.out.println("Player 1 Nhap Toa Do Thuyen.");
        Player pl1 = main.CreatePlayer();
        map = main.putShipOnMap(pl1, map);
        map.DisplayMap(map);

        System.out.println("Player 2 Nhap Toa Do Thuyen.");
        Player pl2 = main.CreatePlayer();
        map = main.putShipOnMap(pl2, map);
        map.DisplayMap(map);

        System.out.println(".: ------------GAME STARTING------------ :.");
        while (!main.CheckEndGame(pl1, pl2)) {
            System.out.println(".: ----------------------------------- :.");
            System.out.println("Player 1 Shoot: ");
            main.Shoot(map, pl2);
            map.DisplayMap(map);
            System.out.println(".: ----------------------------------- :.");
            System.out.println("Player 2 Shoot: ");
            main.Shoot(map, pl1);
            map.DisplayMap(map);
            System.out.println("Point 1: " + pl1.getMark());
            System.out.println("Point 2: " + pl2.getMark());
        }
        main.CheckWin(pl1, pl2);
        System.exit(0);

    }
}
