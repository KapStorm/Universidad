package unidad1.tarea3;

public class PrioridadHilos extends Thread {
    int contar;

    static boolean stop = false;
    String actualNombre;

    public PrioridadHilos(String nombre) {
        super(nombre);
        this.actualNombre = nombre;
        contar = 0;
    }

    @Override
    public void run() {
        System.out.printf("%s iniciado\n", this.getName());
        while (!stop && contar < 10_000_000) {
            contar++;
            if (actualNombre.compareTo(this.getName()) != 0) {
                actualNombre = this.getName();
                System.out.printf("En %s\n", actualNombre);
            }
        }
        stop = true;
        System.out.printf("\n%s terminado.", this.getName());
    }

    public int getContar() {
        return contar;
    }
}
