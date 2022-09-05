package unidad1.hilos;

import java.util.Scanner;

import static java.lang.Thread.sleep;

public class AtletaRunnable implements Runnable {
    Scanner in;
    String nombre;

    public AtletaRunnable() {
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
        Thread eje = new Thread(new AtletaHilos());
        eje.start();
        Thread eje2 = new Thread(new AtletaHilos());
        eje2.start();
    }
}
