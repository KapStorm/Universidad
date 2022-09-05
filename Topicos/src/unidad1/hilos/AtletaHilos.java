package unidad1.hilos;

import java.util.Scanner;

public class AtletaHilos extends Thread {
    Scanner in;
    String nombre;

    public AtletaHilos() {
        in = new Scanner(System.in);
    }

    @Override
    public void run() {
        System.out.print("Ingrese el nombre del atleta: ");
        nombre = in.next();
        for (int c = 1; c <= 50; c++) {
            System.out.println(c + "km");
        }

        try {
            sleep(3500);
        } catch (InterruptedException e) {
            e.printStackTrace();
        }

        System.out.println("\nLlego a la meta " + nombre);
    }

    public static void main(String[] args) {
        AtletaHilos eje = new AtletaHilos();
        eje.start();
        AtletaHilos eje2 = new AtletaHilos();
        eje2.start();
    }
}
