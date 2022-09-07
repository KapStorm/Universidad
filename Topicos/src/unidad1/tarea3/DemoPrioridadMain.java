package unidad1.tarea3;

public class DemoPrioridadMain {
    public static void main(String[] args) {
        PrioridadHilos ph1 = new PrioridadHilos("Prioridad Alta");
        PrioridadHilos ph2 = new PrioridadHilos("Prioridad Baja");
        PrioridadHilos ph3 = new PrioridadHilos("Prioridad Normal #1");
        PrioridadHilos ph4 = new PrioridadHilos("Prioridad Normal #2");
        PrioridadHilos ph5 = new PrioridadHilos("Prioridad Normal #3");

        ph1.setPriority(Thread.NORM_PRIORITY + 2);
        ph2.setPriority(Thread.NORM_PRIORITY - 2);

        ph1.start();
        ph2.start();
        ph3.start();
        ph4.start();
        ph5.start();
        try {
            ph1.join();
            ph2.join();
            ph3.join();
            ph4.join();
            ph5.join();
        } catch (InterruptedException e) {
            System.out.println("Hilo principal interrumpido");
        }

        System.out.printf("\nHilo de alta prioridad hasta %d\n", ph1.getContar());
        System.out.printf("Hilo de baja prioridad contó hasta %d\n", ph2.getContar());
        System.out.printf("Hilo de normal prioridad #1 contó hasta %d\n", ph3.getContar());
        System.out.printf("Hilo de normal prioridad #2 contó hasta %d\n", ph4.getContar());
        System.out.printf("Hilo de normal prioridad #3 contó hasta %d\n", ph5.getContar());
    }
}
