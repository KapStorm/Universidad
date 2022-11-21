import java.util.Scanner;

public class Examen {
    public static void main(String[] args) {
        Scanner leer = new Scanner(System.in);

        System.out.println("Cantidad de simulaciones");
        int simulaciones = leer.nextInt();

        int existencia = 0;
        int gananciaEsperada = 0;

        System.out.println(" n \t\t# Alea\t\tLitros Vendidos\tCosto Preparacion\tIngreso x venta\t\tUtilidad");
        for (int i = 1; i <= simulaciones; i++) {
            double aleatorio = Math.random();

            int litros = 0;
            if (aleatorio <= 0.025) {
                litros = 10;
            } else if (aleatorio <= 0.1) {
                litros = 12;
            } else if (aleatorio <= 0.225) {
                litros = 14;
            } else if (aleatorio <= 0.625) {
                litros = 16;
            } else if (aleatorio <= 0.7875) {
                litros = 18;
            } else if (aleatorio <= 0.9) {
                litros = 20;
            } else if (aleatorio <= 0.975) {
                litros = 22;
            } else {
                litros = 24;
            }
            existencia += litros;

            int costo = litros * 25;
            int venta = litros * 40;
            int utilidad = venta - costo;
            gananciaEsperada += utilidad;

            System.out.printf("%3d\t\t%.4f\t\t%d\t\t\t\t\t%d\t\t\t\t\t%d\t\t\t\t\t%d\n", i, aleatorio, litros, costo, venta, utilidad);
        }

        System.out.println("Existencia necesaria: " + existencia);
        System.out.println("Ganancia en promedio " + (gananciaEsperada / simulaciones));
    }
}
