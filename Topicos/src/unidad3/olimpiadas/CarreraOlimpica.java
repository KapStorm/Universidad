package unidad3.olimpiadas;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class CarreraOlimpica extends JFrame implements ActionListener {
    static JButton go;
    static JPanel finalistasPanel;
    private static final long serialVersionUID = 1L;
    private static final int tam = 10;
    private static JLabel[] names;
    private static JProgressBar[] bars;
    private Color ColorPorDefecto;

    public void abrirVentana() {
        setLayout(null);
        JLabel finalistasTitulo = new JLabel("Finalistas!");
        JLabel titulo = new JLabel("CARRERA DE LAS OLIMPIADAS");
        go = new JButton("GO!");
        bars = new JProgressBar[tam];
        names = new JLabel[tam];
        titulo.setFont(new Font("Comic Sans MS", Font.BOLD, 20));

        JPanel runnerPanel = new JPanel(new GridLayout(tam, 1, 1, 11));
        JPanel nombres = new JPanel(new GridLayout(tam, 1, 1, 11));
        finalistasPanel = new JPanel(new GridLayout(tam, 1, 1, 1));

        go.addActionListener(this);

        for (int i = 0; i < tam; i++) {
            bars[i] = new JProgressBar();
            runnerPanel.add(bars[i]);
            names[i] = new JLabel("…");
            nombres.add(names[i]);
        }

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

        setTitle("Enviador");
        setSize(1000, 519);
        setVisible(true);
        setResizable(false);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }

    public void actionPerformed(ActionEvent e) {
        go.setEnabled(false);
        finalistasPanel.removeAll();
        finalistasPanel.updateUI();

        for (JProgressBar bar: bars) {
            bar.setStringPainted(true);
            bar.setForeground(ColorPorDefecto);
            bar.setString("");
        }

        String[] country = seleccionador();

        for (int i = 0; i < tam; i++) {
            names[i].setText(country[i]);
        }

        for (int i = 0; i < tam; i++) {
            new Corredor(bars[i], country[i], i).execute();
        }
    }

    private String[] seleccionador() {
        String[] namesCountry = {"Argentina", "Panama", "Brasil", "United States", "Mexico", "United Kingdom",
                "Canada", "Venezuela", "Alemania", "China", "Jamaica", "Somalia", "Barbados", "Kenia", "Etiopia", "Sudafrica",
                "Australia", "Japon", "Uganda", "Francia", "Tanzania", "Letonia", "Honduras", "Haiti", "Portugal", "Israel",
                "Egipto", "Russia", "Tri.Tobago", "Noruega",};
        String[] country = new String[tam];

        for (int i = 0; i < tam; i++) {
            country[i] = namesCountry[((int) (Math.random() * (-29) + 29))];
        }
        return country;
    }

    public static void main(String[] args) {
        new CarreraOlimpica().abrirVentana();
    }

}
