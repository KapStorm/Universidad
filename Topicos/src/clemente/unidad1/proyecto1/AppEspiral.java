package clemente.unidad1.proyecto1;

import java.util.Scanner;

public class AppEspiral {
    Scanner in;
    Espiral espiral;

    public AppEspiral() {
        in = new Scanner(System.in);
    }

    public static void main(String[] args) {
        new AppEspiral().menu();
    }

    public void menu() {
        System.out.println("1. Definir tamanio");
        System.out.println("2. Tamanio aleatorio (10 - 100)");
        System.out.println("0. Salir");
        System.out.print(">>> ");
        switch (in.nextInt()) {
            case 1:
                System.out.print("Tamanio: ");
                espiral = new Espiral(in.nextInt());
                espiral.formar();
                espiral.imprimir();
                break;
            case 2:
                espiral = new Espiral();
                espiral.formar();
                espiral.imprimir();
                break;
            case 0:
                return;
        }
        menu();
    }
}
