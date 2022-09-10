package unidad1.hilos.cajera;

import java.util.List;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class EjecutorHilosCajera {
    private static final int numCajeros = 3;

    public static void main(String[] args) {
        List<Clientes> clientes = List.of(
                new Clientes("Cliente 1", List.of(
                        new Productos(2),
                        new Productos(2),
                        new Productos(1),
                        new Productos(5),
                        new Productos(2))
                ),
                new Clientes("Cliente 2", List.of(
                        new Productos(1),
                        new Productos(1),
                        new Productos(5),
                        new Productos(1),
                        new Productos(1))
                ),
                new Clientes("Cliente 3", List.of(
                        new Productos(5),
                        new Productos(3),
                        new Productos(1),
                        new Productos(5),
                        new Productos(2))
                ),
                new Clientes("Cliente 4", List.of(
                        new Productos(2),
                        new Productos(4),
                        new Productos(3),
                        new Productos(2),
                        new Productos(5))
                ),
                new Clientes("Cliente 5", List.of(
                        new Productos(1),
                        new Productos(3),
                        new Productos(2),
                        new Productos(2),
                        new Productos(3))
                ),
                new Clientes("Cliente 6", List.of(
                        new Productos(4),
                        new Productos(2),
                        new Productos(1),
                        new Productos(3),
                        new Productos(1))
                ),
                new Clientes("Cliente 7", List.of(
                        new Productos(3),
                        new Productos(3),
                        new Productos(2),
                        new Productos(4),
                        new Productos(7))
                ),
                new Clientes("Cliente 8", List.of(
                        new Productos(6),
                        new Productos(1),
                        new Productos(3),
                        new Productos(1),
                        new Productos(3))
                )
        );

        long init = System.currentTimeMillis();

        ExecutorService executor = Executors.newFixedThreadPool(numCajeros);
        for (Clientes cliente : clientes) {
            Runnable cajera = new CajeraRunnable(cliente, init);
            executor.execute(cajera);
        }
        executor.shutdown();

        while (!executor.isTerminated());

        long fin = System.currentTimeMillis();
        System.out.printf("Tiempo total de procesamiento: %d segundos\n", (fin - init) / 1000);
    }
}
