package unidad1.tarea3;

public class DemoPrioridadMain {
    public static void main(String[] args) {
        PrioridadHilos ph1 = new PrioridadHilos("Prioridad 10");
        PrioridadHilos ph2 = new PrioridadHilos("Prioridad 9");
        PrioridadHilos ph3 = new PrioridadHilos("Prioridad 4");
        PrioridadHilos ph4 = new PrioridadHilos("Prioridad 3");
        PrioridadHilos ph5 = new PrioridadHilos("Prioridad 1");

        ph1.setPriority(10);
        ph2.setPriority(9);
        ph3.setPriority(4);
        ph4.setPriority(3);
        ph5.setPriority(1);

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

        System.out.printf("\nHilo de prioridad 10 contó hasta %d\n", ph1.getContar());
        System.out.printf("Hilo de prioridad 9 contó hasta %d\n", ph2.getContar());
        System.out.printf("Hilo de prioridad 4 contó hasta %d\n", ph3.getContar());
        System.out.printf("Hilo de prioridad 3 contó hasta %d\n", ph4.getContar());
        System.out.printf("Hilo de prioridad 1 contó hasta %d\n", ph5.getContar());
    }
}
