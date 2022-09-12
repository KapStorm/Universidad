package unidad3.hilos.autos;

import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class EjecutorHilosLavado {
    public static void main(String[] args) {
        int espaciosParaLavado = 2;

        String[] autos = new String[]{
                "Camioneta", "Uber", "Auto", "Moto", "Uber", "Uber", "Camioneta", "Auto", "Auto", "Moto", "Camioneta", "Moto", "Camioneta"
        };

        long init = System.currentTimeMillis();
        ExecutorService executors = Executors.newFixedThreadPool(espaciosParaLavado);

        for (String auto : autos) {
            Runnable runnable = new CarrilDeLavadoRunnable(auto, init);
            executors.execute(runnable);
        }
        executors.shutdown();

        while (!executors.isTerminated()) ;

        long fin = System.currentTimeMillis();
        System.out.printf("Tiempo total de procesamiento: %d segundos\n", (fin - init) / 1000);
    }
}
