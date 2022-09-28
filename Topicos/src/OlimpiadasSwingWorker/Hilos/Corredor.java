/*
 * ARELLANES BELTRÁN SEBASTIAN
 * BAÑUELOS IBARRA JESÚS MANUEL
 * HERNÁNDEZ MORENO YESENIA ABIGAIL
 * SHIMIZU AGUILAR KIYOSHI MIGUEL
 */

package OlimpiadasSwingWorker.Hilos;

import OlimpiadasSwingWorker.MetodoMain.CarreraOlimpica;

import javax.swing.*;
import java.awt.*;
import java.util.concurrent.ExecutionException;

public class Corredor extends SwingWorker<String, String> {
    private static int posicion = 1; // Se inicializa las posiciones en 1
    private final JProgressBar bar; // Constante para recibir a la barra de progreso a utilizar
    private final String pais; // Constante para el país del corredor
    private final int colors; // Constante para el color
    private final Color[] colores = {Color.BLUE, Color.CYAN, Color.GRAY,
            Color.GREEN, Color.MAGENTA, Color.ORANGE,
            Color.PINK, Color.RED, Color.WHITE, Color.YELLOW};

    /* 
     *  Constructor que recibe la barra de progreso, el país y el color
     *  que va a utilizar para el corredor
     */
    public Corredor(JProgressBar bar, String pais, int colors) {
        this.bar = bar; // Se recibe la barra de progreso que utilizará
        this.pais = pais; // Se recibe el nombre del país
        this.colors = colors; // Se recibe el color asignado
    }

    /* 
     *  Método doInBackground del SwingWorker
     */
    @Override
    protected String doInBackground() {
        bar.setStringPainted(true);
        bar.setForeground(colores[colors]); // Se cambia el color de la barra de progreso
        int y = 0; // se inicializa y

        while (y <= 100) {
            int t = (int) (Math.random() * (3 - 10) + 10); // Se genera un número aleatorio de tiempo que se dormirá el hilo del corredor
            y = y + (int) (Math.random() * (1 - 5) + 5); // Se genera un número aleatorio de la cantidad de pista que se correrá
            bar.setValue(y); // Se asigna el nuevo valor a la barra de progreso
            bar.repaint(); // Se actualiza la barra de progreso
            if (y != 100) {
                try {
                    Thread.sleep(t * 100L); // Mientras que y sea diferente de 100, se duerme al hilo por el tiempo generado previamente
                } catch (InterruptedException e) {
                    e.getStackTrace();
                }
            }
        }

        return pais;
    }

    /*
     * Método done para cuando termina de ejecutar el doInBackground
     */
    @Override
    protected void done() {
        bar.setForeground(Color.BLACK); // Se cambia el color de la barra de progreso a negro
        bar.setString(pais + " finalizó!"); // Se pone el textó de final en la barra de progreso
        try {
            CarreraOlimpica.finalistasPanel.add(new JLabel(posicion + " " + get())); // Se agrega al país en la lista de finalistas junto con su posición
            CarreraOlimpica.finalistasPanel.updateUI(); // Se actualiza el panel para que salga el país
            posicion++; // Se actualiza la siguiente posición
            if (posicion > 10) {
                CarreraOlimpica.go.setEnabled(true); // Ya que todos los corredores llegaron se habilita el botón para iniciar la siguiente carrera
                posicion = 1; // Se reinician las posiciones
            }
        } catch (InterruptedException | ExecutionException e) {
            throw new RuntimeException(e);
        }
    }
}