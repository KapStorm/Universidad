package unidad1.hilos;

public class TestHilos implements Runnable {
    private String nombre;

    public TestHilos(String nombre) {
        this.nombre = nombre;
    }

    @Override
    public void run() {
        System.out.printf("El hilo %s está corriendo\n", nombre);
        for (int i = 1; i <= 100; i++) {
            System.out.printf("%s: %d\n", nombre, i);
        }
    }

    public static void main(String[] args) {
        TestHilos m1 = new TestHilos("Hilo 1");
        TestHilos m2 = new TestHilos("Hilo 2");
        Thread t1 = new Thread(m1);
        Thread t2 = new Thread(m2);

        t1.start();
        t2.start();

        System.out.println("Fin del main");
    }
}
