package unidad2;

import java.util.Scanner;

public class AppRecursividad {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        System.out.println("1. Buscar el elemento de un arreglo de forma recursiva");
        int[] arreglo = {3, 5, 10, 2, 45, 1};
        System.out.print("Ingrese el elemento: ");
        int posicion = input.nextInt();
        System.out.println("Posicion: " + busquedaRecursiva(arreglo, posicion));
        System.out.println();

        System.out.println("2. Tabla de multiplicar de un numero entre 1 al 10");
        System.out.print("Ingrese el numero: ");
        int num = input.nextInt();
        tablaDeMultiplicar(num);
        System.out.println();

        System.out.println("3. Mostrar nombre introducido por teclado de forma inversa");
        System.out.print("Ingrese el nombre: ");
        String nombre = input.next();
        System.out.println(invertirPalabra(nombre));
        System.out.println();

        System.out.println("4. Una division");
        System.out.print("Ingrese el numerador: ");
        int numerador = input.nextInt();
        System.out.print("Ingrese el denominador: ");
        int denominador = input.nextInt();
        System.out.println(divison(numerador, denominador));
    }

    public static int divison(int numerador, int denominador) {
        if (denominador == 0) {
            return -1;
        }

        if (denominador < 0) {
            denominador *= -1;
            return (1 + divison(numerador - denominador, denominador)) * -1;
        }

        if (numerador < 0) {
            numerador *= -1;
            return (1 + divison(numerador - denominador, denominador)) * -1;
        }

        if (denominador > numerador) {
            return 0;
        }

        return 1 + divison(numerador - denominador, denominador);
    }

    public static void tablaDeMultiplicar(int n) {
        tablaDeMultiplicar(n, 10);
    }

    public static void tablaDeMultiplicar(int n, int i) {
        if (i > 1) {
            tablaDeMultiplicar(n, i - 1);
        }
        System.out.println(n + " x " + i + " = " + n * i);
    }

    public static String invertirPalabra(String palabra) {
        if (palabra.length() == 0) return "";
        return invertirPalabra(palabra, palabra.length() - 1);
    }

    public static String invertirPalabra(String palabra, int longitud) {
        if (longitud < 0) {
            return "";
        }
        return palabra.charAt(longitud) + invertirPalabra(palabra, longitud - 1);
    }

    public static int busquedaRecursiva(int arreglo[], int num) {
        return busquedaRecursiva(arreglo, num, 0);
    }

    public static int busquedaRecursiva(int arreglo[], int num, int pos) {
        if (pos == arreglo.length) {
            return -1;
        }
        if (arreglo[pos] == num) {
            return pos + 1;
        }
        return busquedaRecursiva(arreglo, num, pos + 1);
    }

}



