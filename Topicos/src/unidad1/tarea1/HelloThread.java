package unidad1.tarea1;

public class HelloThread implements Runnable {
    private String nombre;

    public HelloThread(String nombre) {
        this.nombre = nombre;
    }

    @Override
    public void run() {
        for (int i = 0; i < 20; i++)
            System.out.println(i + " " + nombre);
        System.out.println("Termina runnable " + nombre);
    }

    public static void main(String[] args) {
        new HelloThread("Pepe").run();
        new HelloThread("Juan").run();
        System.out.println("Termina thread main");
    }
}
