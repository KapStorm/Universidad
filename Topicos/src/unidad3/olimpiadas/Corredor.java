package unidad3.olimpiadas;

import javax.swing.*;
import java.awt.*;
import java.util.concurrent.ExecutionException;

public class Corredor extends SwingWorker<String, String> {
    private static int posicion = 1;
    private final JProgressBar bar;
    private final String pais;
    private final int colors;
    private final Color[] colores = {Color.BLUE, Color.CYAN, Color.GRAY,
            Color.GREEN, Color.MAGENTA, Color.ORANGE,
            Color.PINK, Color.RED, Color.WHITE, Color.YELLOW};

    public Corredor(JProgressBar bar, String pais, int colors) {
        this.bar = bar;
        this.pais = pais;
        this.colors = colors;
    }

    @Override
    protected String doInBackground() {
        bar.setStringPainted(true);
        bar.setForeground(colores[colors]);
        int y = 0;

        while (y <= 100) {
            int t = (int) (Math.random() * (3 - 10) + 10);
            y = y + (int) (Math.random() * (1 - 5) + 5);
            bar.setValue(y);
            bar.repaint();
            if (y != 100) {
                try {
                    Thread.sleep(t * 100L);
                } catch (InterruptedException e) {
                    e.getStackTrace();
                }
            }
        }

        return pais;
    }

    @Override
    protected void done() {
        bar.setForeground(Color.BLACK);
        bar.setString(pais + " finalizo!");
        try {
            CarreraOlimpica.finalistasPanel.add(new JLabel(posicion + " " + get()));
            CarreraOlimpica.finalistasPanel.updateUI();
            posicion++;
            if (posicion > 10) {
                CarreraOlimpica.go.setEnabled(true);
                posicion = 1;
            }
        } catch (InterruptedException | ExecutionException e) {
            throw new RuntimeException(e);
        }
    }
}