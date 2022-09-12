package unidad3.hilos.autos;

public class CarrilDeLavadoRunnable implements Runnable {
    private String vehiculo;
    private long init;

    public CarrilDeLavadoRunnable(String auto, long init) {
        this.vehiculo = auto;
        this.init = init;
    }

    @Override
    public void run() {
        float precio;
        int tiempo;

        switch (vehiculo) {
            case "Moto":
                precio = 35f;
                tiempo = 2;
                break;
            case "Auto":
                precio = 50.3f;
                tiempo = 10;
                break;
            case "Camioneta":
                precio = 85.5f;
                tiempo = 15;
                break;
            case "Uber":
                precio = 40.2f;
                tiempo = 10;
                break;
            default:
                precio = 50f;
                tiempo = 8;
        }

        System.out.printf("%s lavando el vehiculo %s con coste $%.2f -> Tiempo transcurrido: %d seg\n",
                Thread.currentThread().getName(), vehiculo, precio, (System.currentTimeMillis() - init) / 1000);

        esperarXsegundos(tiempo);

        System.out.printf("%s terminó de lavar el vehiculo %s en el tiempo %d seg\n",
                Thread.currentThread().getName(), vehiculo, (System.currentTimeMillis() - init) / 1000);
    }

    private void esperarXsegundos(int segundos) {
        try {
            Thread.sleep(segundos * 1000L);
        } catch (InterruptedException e) {
            Thread.currentThread().interrupt();
        }
    }
}
