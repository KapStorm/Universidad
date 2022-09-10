package unidad1.hilos.cajera;

public class CajeraRunnable implements Runnable {
    private Clientes cliente;
    private long init;
    private int total;

    public CajeraRunnable(Clientes cliente, long init) {
        this.cliente = cliente;
        this.init = init;
    }

    @Override
    public void run() {
        System.out.printf("La cajera %s comienza a procesar la compra del cliente %s en el tiempo: %d seg\n",
                Thread.currentThread().getName(), this.cliente.getNombre(), (System.currentTimeMillis() - this.init) / 1000);

        for (int i = 0; i < this.cliente.getProductos().size(); i++) {
            this.esperarXsegundos(cliente.getProductos().get(i).getNombre());
            System.out.printf("Procesando el producto %s con coste $%d del %s -> Tiempo: %d seg\n",
                    cliente.getProductos().get(i).getNombre(), cliente.getProductos().get(i).getValor(), this.cliente.getNombre(), (System.currentTimeMillis() - this.init) / 1000);
            total += cliente.getProductos().get(i).getValor();
        };

        System.out.printf("La cajera %s ha terminado de procesar %s en el tiempo: %d seg. Total: $%d\n",
                Thread.currentThread().getName(), this.cliente.getNombre(), (System.currentTimeMillis() - this.init) / 1000, total);
    }

    private void esperarXsegundos(int segundos) {
        try {
            Thread.sleep(segundos * 1000L);
        } catch (InterruptedException e) {
            Thread.currentThread().interrupt();
        }
    }
}
