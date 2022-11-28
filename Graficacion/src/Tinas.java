import java.util.Random;
import java.util.Scanner;

public class Tinas {

    public static Scanner leer = new Scanner(System.in);
    public static Random rng = new Random();

    public static void main(String[] args){
        System.out.println("Teclee el número de veces a simular");
        int numSimulaciones = leer.nextInt();
        double costeFinal = 0;
        final int DIASLABORALES = 260;

        for (int simActual = 1; simActual <= numSimulaciones; simActual++) {
            System.out.println("--------\tNÚMERO DE CORRIDA: "+simActual+"\t--------");
            System.out.println();
            double costeTotal = 0;

            for (int diaActual = 1; diaActual <= DIASLABORALES; diaActual++){
                System.out.println("\tDÍA "+diaActual+"\t");
                double sumaPeso = 0;
                System.out.println("#aleR \t Peso Simulado \t Peso Sim. Acumulado");
                for (int numTina = 1; numTina <= 5; numTina++){
                    float numRandom = rng.nextFloat();
                    double pesoSimulado = RegresaPeso(numRandom);
                    sumaPeso += pesoSimulado;
                    System.out.println(numRandom+" \t "+pesoSimulado+" \t "+sumaPeso);
                }
                if (sumaPeso > 1000) {
                    System.out.println("EXCEDE CAPACIDAD. ACUMULA $200.");
                    costeTotal += 200;
                }
                else System.out.println("NO EXCEDE CAPACIDAD");
            }
            costeFinal += costeTotal;
        }
        double costePromedio = costeFinal/numSimulaciones;
        System.out.println("Coste promedio de "+numSimulaciones+" simulaciones: " + costePromedio);
    }

    public static double RegresaPeso(float numRandom){
        if (numRandom < .5)
            return Math.round(190 + Math.sqrt(800*numRandom));
        if (numRandom > .5)
            return Math.round(230- Math.sqrt(800*(1-numRandom)));
        return 210;
    }
}