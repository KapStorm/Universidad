package unidad1.hilos;

import java.util.Scanner;

// Herencia de la clase Thread, en este caso no
// heredaremos de otra clase (apate del Thread) por lo que no es
// necesario cambiarlo a implements Runnable
public class CicloDeVida extends Thread {
    private final int tiempoDeEspera;

    // Constructor para inicializar el atributo
    // tiempo de espera
    public CicloDeVida(int tiempoDeEspera) {
        this.tiempoDeEspera = tiempoDeEspera;
    }

    // Sobreescritura del metodo run() de la clase Thread
    @Override
    public void run() {
        int total = 0;
        for (int i = 0; i < 10; i++) {
            total += i;
            System.out.println("Acumulado: " + total);

            // Es necesario el try/catch para el metodo sleep
            // ya que es tiene como throweable la excepción
            // InterruptedException
            try {
                // El metodo wait() hace que
                // el hilo 'duerme' durante un tiempo
                // en micro segundos (ms)
                sleep(tiempoDeEspera);
            } catch (InterruptedException e) {
                System.out.println(e.getMessage());
            }
        }
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        System.out.print("¿Cuanto tiempo desea que el hilo espere entre suma (ms)? ");
        int tiempoDeEspera = in.nextInt();

        // Instanciacion de la clase Hilo e inicio de su
        // ejecucion
        System.out.print("¿Desea que el main espere al hilo (S/N)? ");
        char respuesta = in.next().charAt(0);

        CicloDeVida hilo = new CicloDeVida(tiempoDeEspera);
        hilo.start();

        if (respuesta == 'S') {
            // synchronized para la espera del hilo, haciendo
            // que el hilo Main espere a que termine el hilo
            // 'hilo'
            synchronized (hilo) {
                // Es necesario el try/catch ya que el metodo
                // wait() tiene como throweable la excepción
                // InterruptedException
                try {
                    // Hace que el hilo actual se quede
                    // en modo de espera, volverá a correr hasta que el hilo 'hilo'
                    // termine se ejecucion o se realize un notify() o notifyAll()
                    //
                    // En este caso hace que el hilo Main espere a que
                    // el hilo 'hilo' termine su ejecución
                    hilo.wait();
                } catch (InterruptedException e) {
                    System.out.println(e.getMessage());
                }
            }
        }

        System.out.println("Fin del metodo main");
    }
}