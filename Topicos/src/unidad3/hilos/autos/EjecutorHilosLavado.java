package unidad3.hilos.autos;

import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class EjecutorHilosLavado {
    public static void main(String[] args) {
        /**
         * Mi idea es que tengamos un autolavado con principalmente
         * 2 espacios para lavar los autos, mientras se termine
         * de lavar un auto este dejará un espacio libre
         * y otro auto se podrá lavar en ese espacio
         *
         * En resumen es un problema de colas
         */
        int espaciosParaLavado = 2;

        // Arreglo de autos
        String[] autos = new String[]{
                "Camioneta",
                "Uber",
                "Auto",
                "Moto",
                "Uber",
                "Uber",
                "Camioneta",
                "Auto",
                "Auto",
                "Moto",
                "Camioneta",
                "Moto",
                "Camioneta"
        };

        long init = System.currentTimeMillis();
        // Instanciación de la interfáz ExecutorService
        // con el método estático newFixedThreadPool
        // de la clase Executors
        ExecutorService executor = Executors.newFixedThreadPool(espaciosParaLavado);

        // Ordenamos que el executor ejecute todos los autos
        // con la ayuda de la clase Runnable del carril de lavado
        for (String auto : autos) {
            Runnable runnable = new CarrilDeLavadoRunnable(auto, init);
            executor.execute(runnable);
        }
        // Mandamos la instrucción de apagado despues de que se iteren
        // todos los autos
        executor.shutdown();

        // Mientras el ejecutor no esté apagado entre en un while
        while (!executor.isTerminated()) ;

        // Impresión de cuanto tiempo tardó en terminar el programa
        long fin = System.currentTimeMillis();
        System.out.printf("Tiempo total de procesamiento: %d segundos\n", (fin - init) / 1000);
    }
}
