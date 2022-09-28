/*
 * ARELLANES BELTRÁN SEBASTIAN
 * BAÑUELOS IBARRA JESÚS MANUEL
 * HERNÁNDEZ MORENO YESENIA ABIGAIL
 * SHIMIZU AGUILAR KIYOSHI MIGUEL
 */

package OlimpiadasSwingWorker.MetodoMain;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import OlimpiadasSwingWorker.Hilos.Corredor;

public class CarreraOlimpica extends JFrame implements ActionListener {
    public static JButton go; // Se crea el botón
    public static JPanel finalistasPanel; // Se crea el panel de finalistas
    private static final long serialVersionUID = 1L;
    private static final int tam = 10; // Se asigna la cantidad de corredores
    private static JLabel[] names; // Arreglo para los nombres de los países finalistas
    private static JProgressBar[] bars; // Arreglo para las barras de progreso
    private Color ColorPorDefecto;

    /*
     * Método para crear la ventana de la carrera
     */
    public void abrirVentana() {
        setLayout(null);
        JLabel finalistasTitulo = new JLabel("Finalistas!");
        JLabel titulo = new JLabel("CARRERA DE LAS OLIMPIADAS"); // El título en la ventana
        go = new JButton("GO!"); // Se crea el botón GO!
        bars = new JProgressBar[tam]; // Se crean las barras de progreso
        names = new JLabel[tam]; // Se crean las etiquetas con los nombres de los países
        titulo.setFont(new Font("Times New Roman", Font.BOLD, 20)); // Se le da formato al título en la ventana

        JPanel runnerPanel = new JPanel(new GridLayout(tam, 1, 1, 11)); // Se crea el panel para las barras de progreso
        JPanel nombres = new JPanel(new GridLayout(tam, 1, 1, 11)); // Se crea el panel para los nombres de los países
        finalistasPanel = new JPanel(new GridLayout(tam, 1, 1, 1)); // Se crea el panel de finalistas

        go.addActionListener(this);

        for (int i = 0; i < tam; i++) {
            bars[i] = new JProgressBar(); // Se crea una nueva barra de progreso
            runnerPanel.add(bars[i]); // Se agrega la barra en el panel de barras
            names[i] = new JLabel("…"); // Se crea la etiqueta para el nombre del país sin el nombre
            nombres.add(names[i]); // Se agrega el nombre del país
        }

        // Se editan los bordes, tamaños y colores de las etiquetas, botónes, barras de progreso y de los paneles
        titulo.setBounds(325, 25, 500, 30);
        finalistasTitulo.setBounds(750, 100, 70, 20);
        go.setBounds(75, 100, 70, 20);
        nombres.setBounds(75, 130, 90, 300);
        runnerPanel.setBounds(200, 130, 500, 300);
        finalistasPanel.setBounds(750, 130, 200, 250);
        add(titulo);
        add(finalistasTitulo);
        add(nombres);
        add(runnerPanel);
        add(finalistasPanel);
        add(go);

        ColorPorDefecto = bars[0].getForeground(); 

        setTitle("Olimpiadas");
        setSize(1000, 519);
        setVisible(true);
        setResizable(false);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

    }

    /*
     * Método actionPerfomen para cuando se presiona el botón de inicio
     */
    public void actionPerformed(ActionEvent e) {
        go.setEnabled(false); // Se deshabilita el botón
        finalistasPanel.removeAll(); // Se vacía el panel de finalistas
        finalistasPanel.updateUI(); // Se muestran los cambios del panel de finalistas

        for (JProgressBar bar: bars) { // Por cada barra de progreso...
            bar.setStringPainted(true); // Se muestra
            bar.setForeground(ColorPorDefecto); // Se cambia el color
            bar.setString(""); // Se borra el texto de la barra
        }

        String[] country = seleccionador(); // Se seleccionan los países a participar

        for (int i = 0; i < tam; i++) {
            names[i].setText(country[i]); // Se asignan los nombres a las etiquetas
        }

        for (int i = 0; i < tam; i++) {
            new Corredor(bars[i], country[i], i).execute(); // Se crean los corredores y se ejecutan
        }
    }

    private String[] seleccionador() {
        String[] namesCountry = {"Argentina", "Panamá", "Brasil", "Estados Unidos", "México", "Reino Unido",
                "Canadá", "Venezuela", "Alemania", "China", "Jamaica", "Somalia", "Barbados", "Kenia", "Etiopía", "Sudafrica",
                "Australia", "Japón", "Uganda", "Francia", "Tanzania", "Letonia", "Honduras", "Haití", "Portugal", "Israel",
                "Egipto", "Corea del Sur", "Tri.Tobago", "Noruega",}; // Lista de posibles paises
        String[] country = new String[tam]; // Arreglo en el que se almacenan los países escogidos

        for (int i = 0; i < tam; i++) {
            country[i] = namesCountry[((int) (Math.random() * (-29) + 29))]; // Se escoge un país al azar
        }

        return country; // Se retorna el arreglo con los países
    }

    public static void main(String[] args) {
        new CarreraOlimpica().abrirVentana(); // Método main que abre la ventana de la carrera
    }
}
