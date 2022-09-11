package unidad3.hilos;

import java.util.Scanner;

public class AnimalesRunnable implements Runnable {
    Scanner in;
    String nombre;

    public AnimalesRunnable() {
        in = new Scanner(System.in);
    }

    @Override
    public void run() {
        System.out.println("Ingrese el nombre del animal");
        nombre = in.next();
        System.out.println("El animal " + nombre + " arranca");
        for (int c = 1; c <= 50; c++) {
            System.out.println(c + "km " + nombre);
        }

        try {
            Thread.sleep(2345);
        } catch (InterruptedException e) {
            System.out.println(e.getMessage());
        }

        System.out.println("Llego a la meta " + nombre);
    }

    public static void main(String[] args) {
        Thread t1 = new Thread(new AnimalesRunnable());
        Thread t2 = new Thread(new AnimalesRunnable());
        Thread t3 = new Thread(new AnimalesRunnable());
        t1.start();
        t2.start();
        t3.start();
    }
}
