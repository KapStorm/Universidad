package simulacion;

import org.jfree.chart.ChartFactory;
import org.jfree.chart.ChartFrame;
import org.jfree.chart.JFreeChart;
import org.jfree.data.general.DefaultPieDataset;

import javax.imageio.ImageIO;
import javax.swing.*;
import java.awt.*;
import java.io.File;
import java.io.IOException;
import java.util.Random;
import java.util.Scanner;
import java.util.Timer;
import java.util.TimerTask;

public class BarajaSave extends JFrame {
    Scanner leer = new Scanner(System.in);

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            BarajaSave app = new BarajaSave();
            app.baraja();
        });
    }

    public void baraja() {
        DefaultPieDataset pastel = new DefaultPieDataset();
        double valorminimo = 0, valormaximo = 1, aleatoriotipo, aleatorionumero;
        String[][] cartasgeneradas = new String[2][40];
        Random generador = new Random();
        int juegos, vj1 = 0, vj2 = 0, vj3 = 0, vj4 = 0;
        Timer timer = new Timer();

        juegos = Integer.parseInt(JOptionPane.showInputDialog(null, "Ingrese los juegos"));

        for (int i = 0; i < juegos; i++) {
            String[][] baraja1 = new String[2][10];
            String[][] baraja2 = new String[2][10];
            String[][] baraja3 = new String[2][10];
            String[][] baraja4 = new String[2][10];

            int vm1 = 0, vm2 = 0, vm3 = 0, vm4 = 0;
            int oro = 0, copa = 0, espada = 0, palo = 0;
            int unos = 0, dos = 0, tres = 0, cuatros = 0, cincos = 0, seis = 0, sietes = 0, dieces = 0, onces = 0, doces = 0;
            int unosc = 0, dosc = 0, tresc = 0, cuatrosc = 0, cincosc = 0, seisc = 0, sietesc = 0, diecesc = 0, oncesc = 0, docesc = 0;
            int unose = 0, dose = 0, trese = 0, cuatrose = 0, cincose = 0, seise = 0, sietese = 0, diecese = 0, oncese = 0, docese = 0;
            int unosp = 0, dosp = 0, tresp = 0, cuatrosp = 0, cincosp = 0, seisp = 0, sietesp = 0, diecesp = 0, oncesp = 0, docesp = 0;

            // ------------------------------------------------------------------------------------------------------------------------------------------------------------------
            for (int j = 0; j < 40; j++) {        //-----------------------------------------Cartas Genradas----------------------------------------
                do {
                    aleatoriotipo = valorminimo + (valormaximo - valorminimo) * generador.nextDouble();

                    if (aleatoriotipo > 0 && aleatoriotipo <= .25 && oro < 10) { //ORO
                        cartasgeneradas[0][j] = "Oro";
                        oro++;

                        do {
                            aleatorionumero = valorminimo + (valormaximo - valorminimo) * generador.nextDouble();
                            if (aleatorionumero > 0 && aleatorionumero <= .1 && unos < 1) {
                                cartasgeneradas[1][j] = "As";
                                unos++;
                            } else if (aleatorionumero > .1 && aleatorionumero <= .2 && doces < 1) {
                                cartasgeneradas[1][j] = 12 + "";
                                doces++;
                            } else if (aleatorionumero > .2 && aleatorionumero <= .3 && onces < 1) {
                                cartasgeneradas[1][j] = 11 + "";
                                onces++;
                            } else if (aleatorionumero > .3 && aleatorionumero <= .4 && dieces < 1) {
                                cartasgeneradas[1][j] = 10 + "";
                                dieces++;
                            } else if (aleatorionumero > .4 && aleatorionumero <= .5 && sietes < 1) {
                                cartasgeneradas[1][j] = 7 + "";
                                sietes++;
                            } else if (aleatorionumero > .5 && aleatorionumero <= .6 && seis < 1) {
                                cartasgeneradas[1][j] = 6 + "";
                                seis++;
                            } else if (aleatorionumero > .6 && aleatorionumero <= .7 && cincos < 1) {
                                cartasgeneradas[1][j] = 5 + "";
                                cincos++;
                            } else if (aleatorionumero > .7 && aleatorionumero <= .8 && cuatros < 1) {
                                cartasgeneradas[1][j] = 4 + "";
                                cuatros++;
                            } else if (aleatorionumero > .8 && aleatorionumero <= .9 && tres < 1) {
                                cartasgeneradas[1][j] = 3 + "";
                                tres++;
                            } else if (aleatorionumero > .9 && aleatorionumero <= 1 && dos < 1) {
                                cartasgeneradas[1][j] = 2 + "";
                                dos++;
                            }
                        } while (cartasgeneradas[1][j] == null);

                    } else if (aleatoriotipo > .25 && aleatoriotipo <= .5 && copa < 10) { //COPAS
                        cartasgeneradas[0][j] = "Copas";
                        copa++;

                        do {
                            aleatorionumero = valorminimo + (valormaximo - valorminimo) * generador.nextDouble();
                            if (aleatorionumero > 0 && aleatorionumero <= .1 && unosc < 1) {
                                cartasgeneradas[1][j] = "As";
                                unosc++;
                            } else if (aleatorionumero > .1 && aleatorionumero <= .2 && docesc < 1) {
                                cartasgeneradas[1][j] = 12 + "";
                                docesc++;
                            } else if (aleatorionumero > .2 && aleatorionumero <= .3 && oncesc < 1) {
                                cartasgeneradas[1][j] = 11 + "";
                                oncesc++;
                            } else if (aleatorionumero > .3 && aleatorionumero <= .4 && diecesc < 1) {
                                cartasgeneradas[1][j] = 10 + "";
                                diecesc++;
                            } else if (aleatorionumero > .4 && aleatorionumero <= .5 && sietesc < 1) {
                                cartasgeneradas[1][j] = 7 + "";
                                sietesc++;
                            } else if (aleatorionumero > .5 && aleatorionumero <= .6 && seisc < 1) {
                                cartasgeneradas[1][j] = 6 + "";
                                seisc++;
                            } else if (aleatorionumero > .6 && aleatorionumero <= .7 && cincosc < 1) {
                                cartasgeneradas[1][j] = 5 + "";
                                cincosc++;
                            } else if (aleatorionumero > .7 && aleatorionumero <= .8 && cuatrosc < 1) {
                                cartasgeneradas[1][j] = 4 + "";
                                cuatrosc++;
                            } else if (aleatorionumero > .8 && aleatorionumero <= .9 && tresc < 1) {
                                cartasgeneradas[1][j] = 3 + "";
                                tresc++;
                            } else if (aleatorionumero > .9 && aleatorionumero <= 1 && dosc < 1) {
                                cartasgeneradas[1][j] = 2 + "";
                                dosc++;
                            }
                        } while (cartasgeneradas[1][j] == null);

                    } else if (aleatoriotipo > .5 && aleatoriotipo <= .75 && espada < 10) { //ESPADAS
                        cartasgeneradas[0][j] = "Espadas";
                        espada++;

                        do {
                            aleatorionumero = valorminimo + (valormaximo - valorminimo) * generador.nextDouble();
                            if (aleatorionumero > 0 && aleatorionumero <= .1 && unose < 1) {
                                cartasgeneradas[1][j] = "As";
                                unose++;
                            } else if (aleatorionumero > .1 && aleatorionumero <= .2 && docese < 1) {
                                cartasgeneradas[1][j] = 12 + "";
                                docese++;
                            } else if (aleatorionumero > .2 && aleatorionumero <= .3 && oncese < 1) {
                                cartasgeneradas[1][j] = 11 + "";
                                oncese++;
                            } else if (aleatorionumero > .3 && aleatorionumero <= .4 && diecese < 1) {
                                cartasgeneradas[1][j] = 10 + "";
                                diecese++;
                            } else if (aleatorionumero > .4 && aleatorionumero <= .5 && sietese < 1) {
                                cartasgeneradas[1][j] = 7 + "";
                                sietese++;
                            } else if (aleatorionumero > .5 && aleatorionumero <= .6 && seise < 1) {
                                cartasgeneradas[1][j] = 6 + "";
                                seise++;
                            } else if (aleatorionumero > .6 && aleatorionumero <= .7 && cincose < 1) {
                                cartasgeneradas[1][j] = 5 + "";
                                cincose++;
                            } else if (aleatorionumero > .7 && aleatorionumero <= .8 && cuatrose < 1) {
                                cartasgeneradas[1][j] = 4 + "";
                                cuatrose++;
                            } else if (aleatorionumero > .8 && aleatorionumero <= .9 && trese < 1) {
                                cartasgeneradas[1][j] = 3 + "";
                                trese++;
                            } else if (aleatorionumero > .9 && aleatorionumero <= 1 && dose < 1) {
                                cartasgeneradas[1][j] = 2 + "";
                                dose++;
                            }
                        } while (cartasgeneradas[1][j] == null);

                    } else if (aleatoriotipo > .75 && aleatoriotipo <= 1 && palo < 10) { //PALOS
                        cartasgeneradas[0][j] = "Bastos";
                        palo++;

                        do {
                            aleatorionumero = valorminimo + (valormaximo - valorminimo) * generador.nextDouble();

                            if (aleatorionumero > 0 && aleatorionumero <= .1 && unosp < 1) {
                                cartasgeneradas[1][j] = "As";
                                unosp++;
                            } else if (aleatorionumero > .1 && aleatorionumero <= .2 && docesp < 1) {
                                cartasgeneradas[1][j] = 12 + "";
                                docesp++;
                            } else if (aleatorionumero > .2 && aleatorionumero <= .3 && oncesp < 1) {
                                cartasgeneradas[1][j] = 11 + "";
                                oncesp++;
                            } else if (aleatorionumero > .3 && aleatorionumero <= .4 && diecesp < 1) {
                                cartasgeneradas[1][j] = 10 + "";
                                diecesp++;
                            } else if (aleatorionumero > .4 && aleatorionumero <= .5 && sietesp < 1) {
                                cartasgeneradas[1][j] = 7 + "";
                                sietesp++;
                            } else if (aleatorionumero > .5 && aleatorionumero <= .6 && seisp < 1) {
                                cartasgeneradas[1][j] = 6 + "";
                                seisp++;
                            } else if (aleatorionumero > .6 && aleatorionumero <= .7 && cincosp < 1) {
                                cartasgeneradas[1][j] = 5 + "";
                                cincosp++;
                            } else if (aleatorionumero > .7 && aleatorionumero <= .8 && cuatrosp < 1) {
                                cartasgeneradas[1][j] = 4 + "";
                                cuatrosp++;
                            } else if (aleatorionumero > .8 && aleatorionumero <= .9 && tresp < 1) {
                                cartasgeneradas[1][j] = 3 + "";
                                tresp++;
                            } else if (aleatorionumero > .9 && aleatorionumero <= 1 && dosp < 1) {
                                cartasgeneradas[1][j] = 2 + "";
                                dosp++;
                            }
                        } while (cartasgeneradas[1][j] == null);
                    }
                } while (cartasgeneradas[0][j] == null);
            }
            //---------------------------------------------------------------

            int b1 = 0, b2 = 0, b3 = 0, b4 = 0;
            for (int j = 0; j < 40; j += 4) { //-----------------------------Asigancion baraja del jugador 1
                baraja1[0][b1] = cartasgeneradas[0][j];
                baraja1[1][b1] = cartasgeneradas[1][j];
                b1++;
                baraja2[0][b2] = cartasgeneradas[0][j + 1];
                baraja2[1][b2] = cartasgeneradas[1][j + 1];
                b2++;
                baraja3[0][b3] = cartasgeneradas[0][j + 2];
                baraja3[1][b3] = cartasgeneradas[1][j + 2];
                b3++;
                baraja4[0][b4] = cartasgeneradas[0][j + 3];
                baraja4[1][b4] = cartasgeneradas[1][j + 3];
                b4++;
            }

            System.out.println("\n");
            for (int j = 10; j > 0; j--) {   //------------------------------------------------------ Manos
                int n1, n2, n3, n4;
                if (baraja1[1][j - 1].equals("As")) {
                    n1 = 13;
                } else {
                    n1 = Integer.parseInt(baraja1[1][j - 1]);
                }

                if (baraja2[1][j - 1].equals("As")) {
                    n2 = 13;
                } else {
                    n2 = Integer.parseInt(baraja2[1][j - 1]);
                }

                if (baraja3[1][j - 1].equals("As")) {
                    n3 = 13;
                } else {
                    n3 = Integer.parseInt(baraja3[1][j - 1]);
                }

                if (baraja4[1][j - 1].equals("As")) {
                    n4 = 13;
                } else {
                    n4 = Integer.parseInt(baraja4[1][j - 1]);
                }

                if (n1 >= n2 && n1 >= n3 && n1 >= n4) {
                    vm1++;
                } else if (n2 >= n1 && n2 >= n3 && n2 >= n4) {
                    vm2++;
                } else if (n3 >= n1 && n3 >= n1 && n3 >= n4) {
                    vm3++;
                } else if (n4 >= n1 && n4 >= n2 && n4 >= n3) {
                    vm4++;
                }
            }

            String ganador = "";
            if (vm1 > vm2 && vm1 > vm3 && vm1 == vm4) { //----------------------------JUgador victorioso
                ganador = "Ganador jugador 1 y 4";
                vj1++;
                vj4++;
            } else if (vm1 == vm2 && vm1 > vm3 && vm1 > vm4) {
                ganador = "Ganador jugador 1 y 2";
                vj1++;
                vj2++;
            } else if (vm1 > vm2 && vm1 == vm3 && vm1 > vm4) {
                ganador = "Ganador jugador 1 y 3";
                vj1++;
                vj3++;
            } else if (vm1 > vm2 && vm1 > vm3 && vm1 > vm4) {
                ganador = "Ganador jugador 1";
                vj1++;
            } else if (vm2 > vm1 && vm2 == vm3 && vm2 > vm4) {
                ganador = "Ganador jugador 2 y 3";
                vj2++;
                vj3++;
            } else if (vm2 > vm1 && vm2 > vm3 && vm2 == vm4) {
                ganador = "Ganador jugador 2 y 4";
                vj2++;
                vj4++;
            } else if (vm2 > vm1 && vm2 > vm3 && vm2 > vm4) {
                ganador = "Ganador jugador 2";
                vj2++;
            } else if (vm3 > vm1 && vm3 > vm1 && vm3 == vm4) {
                ganador = "Ganador jugador 3 y 4";
                vj3++;
                vj4++;
            } else if (vm3 > vm1 && vm3 > vm1 && vm3 > vm4) {
                ganador = "Ganador jugador 3";
                vj3++;
            } else if (vm4 > vm1 && vm4 > vm2 && vm4 > vm3) {
                ganador = "Ganador jugador 4";
                vj4++;
            }

            String finalGanador = ganador;
            TimerTask timerTask = new TimerTask() {
                String ganadorMetodo = finalGanador;

                @Override
                public void run() {
                    dibujarTablero(baraja1, baraja2, baraja3, baraja4, ganadorMetodo);
                }
            };
            timer.schedule(timerTask, 10000 * i);
        }

        pastel.setValue("Jugador 1: " + vj1, vj1);
        pastel.setValue("Jugador 2: " + vj2, vj2);
        pastel.setValue("Jugador 3: " + vj3, vj3);
        pastel.setValue("Jugador 4: " + vj4, vj4);

        JFreeChart chart = ChartFactory.createPieChart(
                "Baraja",
                pastel,
                true,
                true,
                false
        );

        ChartFrame frame = new ChartFrame("Baraja", chart);
        frame.pack();
        frame.setDefaultCloseOperation(EXIT_ON_CLOSE);

        timer.schedule(new TimerTask() {
            @Override
            public void run() {
                frame.setVisible(true);
                timer.cancel();
            }
        }, 10000 * juegos);
    }

    private void dibujarTablero(String[][] baraja1, String[][] baraja2, String[][] baraja3, String[][] baraja4, String ganador) {
        JFrame frame = new JFrame("Juego");
        frame.setSize(56 * 13, 69 * 13);
        frame.setDefaultCloseOperation(EXIT_ON_CLOSE);
        frame.setLayout(null);
        frame.setVisible(true);

        ImageIcon barajaTrasera = null;
        try {
            barajaTrasera = new ImageIcon(ImageIO.read(new File("C:\\baraja1.jpg")));
        } catch (IOException e) {

        }
        Timer timer1 = new Timer();
        Timer timer2 = new Timer();
        Timer timer3 = new Timer();
        Timer timer4 = new Timer();
        Timer timer5 = new Timer();
        Timer timer6 = new Timer();
        Timer timer7 = new Timer();
        Timer timer8 = new Timer();
        Timer timer9 = new Timer();
        Timer timer10 = new Timer();
        Timer timerFinal = new Timer();

        JLabel cartaJ1 = new JLabel();
        cartaJ1.setBounds(150, 150, 100, 153);
        frame.add(cartaJ1);

        JLabel cartaJ2 = new JLabel();
        cartaJ2.setBounds(420, 150, 100, 153);
        frame.add(cartaJ2);

        JLabel cartaJ3 = new JLabel();
        cartaJ3.setBounds(150, 500, 100, 153);
        frame.add(cartaJ3);

        JLabel cartaJ4 = new JLabel();
        cartaJ4.setBounds(420, 500, 100, 153);
        frame.add(cartaJ4);

        // Jugador 1
        JLabel imgJ1_1 = new JLabel();
        imgJ1_1.setIcon(barajaTrasera);
        imgJ1_1.setBounds(56, 0, 56, 69);
        frame.add(imgJ1_1);

        JLabel imgJ1_2 = new JLabel();
        imgJ1_2.setIcon(barajaTrasera);
        imgJ1_2.setBounds(56 * 2, 0, 56, 69);
        frame.add(imgJ1_2);

        JLabel imgJ1_3 = new JLabel();
        imgJ1_3.setIcon(barajaTrasera);
        imgJ1_3.setBounds(56 * 3, 0, 56, 69);
        frame.add(imgJ1_3);

        JLabel imgJ1_4 = new JLabel();
        imgJ1_4.setIcon(barajaTrasera);
        imgJ1_4.setBounds(56 * 4, 0, 56, 69);
        frame.add(imgJ1_4);

        JLabel imgJ1_5 = new JLabel();
        imgJ1_5.setIcon(barajaTrasera);
        imgJ1_5.setBounds(56 * 5, 0, 56, 69);
        frame.add(imgJ1_5);

        JLabel imgJ1_6 = new JLabel();
        imgJ1_6.setIcon(barajaTrasera);
        imgJ1_6.setBounds(56 * 6, 0, 56, 69);
        frame.add(imgJ1_6);

        JLabel imgJ1_7 = new JLabel();
        imgJ1_7.setIcon(barajaTrasera);
        imgJ1_7.setBounds(56 * 7, 0, 56, 69);
        frame.add(imgJ1_7);

        JLabel imgJ1_8 = new JLabel();
        imgJ1_8.setIcon(barajaTrasera);
        imgJ1_8.setBounds(56 * 8, 0, 56, 69);
        frame.add(imgJ1_8);

        JLabel imgJ1_9 = new JLabel();
        imgJ1_9.setIcon(barajaTrasera);
        imgJ1_9.setBounds(56 * 9, 0, 56, 69);
        frame.add(imgJ1_9);

        JLabel imgJ1_10 = new JLabel();
        imgJ1_10.setIcon(barajaTrasera);
        imgJ1_10.setBounds(56 * 10, 0, 56, 69);
        frame.add(imgJ1_10);

        // Jugador 2
        JLabel imgJ2_1 = new JLabel();
        imgJ2_1.setIcon(barajaTrasera);
        imgJ2_1.setBounds(56 * 11, 69, 56, 69);
        frame.add(imgJ2_1);

        JLabel imgJ2_2 = new JLabel();
        imgJ2_2.setIcon(barajaTrasera);
        imgJ2_2.setBounds(56 * 11, 69 * 2, 56, 69);
        frame.add(imgJ2_2);

        JLabel imgJ2_3 = new JLabel();
        imgJ2_3.setIcon(barajaTrasera);
        imgJ2_3.setBounds(56 * 11, 69 * 3, 56, 69);
        frame.add(imgJ2_3);

        JLabel imgJ2_4 = new JLabel();
        imgJ2_4.setIcon(barajaTrasera);
        imgJ2_4.setBounds(56 * 11, 69 * 4, 56, 69);
        frame.add(imgJ2_4);

        JLabel imgJ2_5 = new JLabel();
        imgJ2_5.setIcon(barajaTrasera);
        imgJ2_5.setBounds(56 * 11, 69 * 5, 56, 69);
        frame.add(imgJ2_5);

        JLabel imgJ2_6 = new JLabel();
        imgJ2_6.setIcon(barajaTrasera);
        imgJ2_6.setBounds(56 * 11, 69 * 6, 56, 69);
        frame.add(imgJ2_6);

        JLabel imgJ2_7 = new JLabel();
        imgJ2_7.setIcon(barajaTrasera);
        imgJ2_7.setBounds(56 * 11, 69 * 7, 56, 69);
        frame.add(imgJ2_7);

        JLabel imgJ2_8 = new JLabel();
        imgJ2_8.setIcon(barajaTrasera);
        imgJ2_8.setBounds(56 * 11, 69 * 8, 56, 69);
        frame.add(imgJ2_8);

        JLabel imgJ2_9 = new JLabel();
        imgJ2_9.setIcon(barajaTrasera);
        imgJ2_9.setBounds(56 * 11, 69 * 9, 56, 69);
        frame.add(imgJ2_9);

        JLabel imgJ2_10 = new JLabel();
        imgJ2_10.setIcon(barajaTrasera);
        imgJ2_10.setBounds(56 * 11, 69 * 10, 56, 69);
        frame.add(imgJ2_10);

        // Jugador 3
        JLabel imgJ3_1 = new JLabel();
        imgJ3_1.setIcon(barajaTrasera);
        imgJ3_1.setBounds(56 * 10, 69 * 11, 56, 69);
        frame.add(imgJ3_1);

        JLabel imgJ3_2 = new JLabel();
        imgJ3_2.setIcon(barajaTrasera);
        imgJ3_2.setBounds(56 * 9, 69 * 11, 56, 69);
        frame.add(imgJ3_2);

        JLabel imgJ3_3 = new JLabel();
        imgJ3_3.setIcon(barajaTrasera);
        imgJ3_3.setBounds(56 * 8, 69 * 11, 56, 69);
        frame.add(imgJ3_3);

        JLabel imgJ3_4 = new JLabel();
        imgJ3_4.setIcon(barajaTrasera);
        imgJ3_4.setBounds(56 * 7, 69 * 11, 56, 69);
        frame.add(imgJ3_4);

        JLabel imgJ3_5 = new JLabel();
        imgJ3_5.setIcon(barajaTrasera);
        imgJ3_5.setBounds(56 * 6, 69 * 11, 56, 69);
        frame.add(imgJ3_5);

        JLabel imgJ3_6 = new JLabel();
        imgJ3_6.setIcon(barajaTrasera);
        imgJ3_6.setBounds(56 * 5, 69 * 11, 56, 69);
        frame.add(imgJ3_6);

        JLabel imgJ3_7 = new JLabel();
        imgJ3_7.setIcon(barajaTrasera);
        imgJ3_7.setBounds(56 * 4, 69 * 11, 56, 69);
        frame.add(imgJ3_7);

        JLabel imgJ3_8 = new JLabel();
        imgJ3_8.setIcon(barajaTrasera);
        imgJ3_8.setBounds(56 * 3, 69 * 11, 56, 69);
        frame.add(imgJ3_8);

        JLabel imgJ3_9 = new JLabel();
        imgJ3_9.setIcon(barajaTrasera);
        imgJ3_9.setBounds(56 * 2, 69 * 11, 56, 69);
        frame.add(imgJ3_9);

        JLabel imgJ3_10 = new JLabel();
        imgJ3_10.setIcon(barajaTrasera);
        imgJ3_10.setBounds(56, 69 * 11, 56, 69);
        frame.add(imgJ3_10);

        // Jugador 4
        JLabel imgJ4_1 = new JLabel();
        imgJ4_1.setIcon(barajaTrasera);
        imgJ4_1.setBounds(0, 69 * 10, 56, 69);
        frame.add(imgJ4_1);

        JLabel imgJ4_2 = new JLabel();
        imgJ4_2.setIcon(barajaTrasera);
        imgJ4_2.setBounds(0, 69 * 9, 56, 69);
        frame.add(imgJ4_2);

        JLabel imgJ4_3 = new JLabel();
        imgJ4_3.setIcon(barajaTrasera);
        imgJ4_3.setBounds(0, 69 * 8, 56, 69);
        frame.add(imgJ4_3);

        JLabel imgJ4_4 = new JLabel();
        imgJ4_4.setIcon(barajaTrasera);
        imgJ4_4.setBounds(0, 69 * 7, 56, 69);
        frame.add(imgJ4_4);

        JLabel imgJ4_5 = new JLabel();
        imgJ4_5.setIcon(barajaTrasera);
        imgJ4_5.setBounds(0, 69 * 6, 56, 69);
        frame.add(imgJ4_5);

        JLabel imgJ4_6 = new JLabel();
        imgJ4_6.setIcon(barajaTrasera);
        imgJ4_6.setBounds(0, 69 * 5, 56, 69);
        frame.add(imgJ4_6);

        JLabel imgJ4_7 = new JLabel();
        imgJ4_7.setIcon(barajaTrasera);
        imgJ4_7.setBounds(0, 69 * 4, 56, 69);
        frame.add(imgJ4_7);

        JLabel imgJ4_8 = new JLabel();
        imgJ4_8.setIcon(barajaTrasera);
        imgJ4_8.setBounds(0, 69 * 3, 56, 69);
        frame.add(imgJ4_8);

        JLabel imgJ4_9 = new JLabel();
        imgJ4_9.setIcon(barajaTrasera);
        imgJ4_9.setBounds(0, 69 * 2, 56, 69);
        frame.add(imgJ4_9);

        JLabel imgJ4_10 = new JLabel();
        imgJ4_10.setIcon(barajaTrasera);
        imgJ4_10.setBounds(0, 69, 56, 69);
        frame.add(imgJ4_10);

        TimerTask timerT1 = new TimerTask() {
            @Override
            public void run() {
                frame.remove(imgJ1_1);
                frame.remove(imgJ2_1);
                frame.remove(imgJ3_1);
                frame.remove(imgJ4_1);

                try {
                    cartaJ1.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja1[1][0], baraja1[0][0])))));
                    cartaJ2.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja2[1][0], baraja2[0][0])))));
                    cartaJ3.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja3[1][0], baraja3[0][0])))));
                    cartaJ4.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja4[1][0], baraja4[0][0])))));
                } catch (IOException ex) {

                }

                frame.repaint();
                timer1.cancel();
            }
        };

        TimerTask timerT2 = new TimerTask() {
            @Override
            public void run() {
                frame.remove(imgJ1_2);
                frame.remove(imgJ2_2);
                frame.remove(imgJ3_2);
                frame.remove(imgJ4_2);

                try {
                    cartaJ1.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja1[1][1], baraja1[0][1])))));
                    cartaJ2.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja2[1][1], baraja2[0][1])))));
                    cartaJ3.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja3[1][1], baraja3[0][1])))));
                    cartaJ4.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja4[1][1], baraja4[0][1])))));
                } catch (IOException ex) {

                }
                frame.repaint();
                timer2.cancel();
            }
        };

        TimerTask timerT3 = new TimerTask() {
            @Override
            public void run() {
                frame.remove(imgJ1_3);
                frame.remove(imgJ2_3);
                frame.remove(imgJ3_3);
                frame.remove(imgJ4_3);

                try {
                    cartaJ1.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja1[1][2], baraja1[0][2])))));
                    cartaJ2.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja2[1][2], baraja2[0][2])))));
                    cartaJ3.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja3[1][2], baraja3[0][2])))));
                    cartaJ4.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja4[1][2], baraja4[0][2])))));
                } catch (IOException ex) {

                }

                frame.repaint();
                timer3.cancel();
            }
        };

        TimerTask timerT4 = new TimerTask() {
            @Override
            public void run() {
                frame.remove(imgJ1_4);
                frame.remove(imgJ2_4);
                frame.remove(imgJ3_4);
                frame.remove(imgJ4_4);

                try {
                    cartaJ1.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja1[1][3], baraja1[0][3])))));
                    cartaJ2.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja2[1][3], baraja2[0][3])))));
                    cartaJ3.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja3[1][3], baraja3[0][3])))));
                    cartaJ4.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja4[1][3], baraja4[0][3])))));
                } catch (IOException ex) {

                }
                frame.repaint();
                timer4.cancel();
            }
        };

        TimerTask timerT5 = new TimerTask() {
            @Override
            public void run() {
                frame.remove(imgJ1_5);
                frame.remove(imgJ2_5);
                frame.remove(imgJ3_5);
                frame.remove(imgJ4_5);

                try {
                    cartaJ1.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja1[1][4], baraja1[0][4])))));
                    cartaJ2.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja2[1][4], baraja2[0][4])))));
                    cartaJ3.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja3[1][4], baraja3[0][4])))));
                    cartaJ4.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja4[1][4], baraja4[0][4])))));
                } catch (IOException ex) {

                }
                frame.repaint();
                timer5.cancel();
            }
        };

        TimerTask timerT6 = new TimerTask() {
            @Override
            public void run() {
                frame.remove(imgJ1_6);
                frame.remove(imgJ2_6);
                frame.remove(imgJ3_6);
                frame.remove(imgJ4_6);
                try {
                    cartaJ1.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja1[1][5], baraja1[0][5])))));
                    cartaJ2.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja2[1][5], baraja2[0][5])))));
                    cartaJ3.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja3[1][5], baraja3[0][5])))));
                    cartaJ4.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja4[1][5], baraja4[0][5])))));
                } catch (IOException ex) {

                }
                frame.repaint();
                timer6.cancel();
            }
        };

        TimerTask timerT7 = new TimerTask() {
            @Override
            public void run() {
                frame.remove(imgJ1_7);
                frame.remove(imgJ2_7);
                frame.remove(imgJ3_7);
                frame.remove(imgJ4_7);

                try {
                    cartaJ1.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja1[1][6], baraja1[0][6])))));
                    cartaJ2.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja2[1][6], baraja2[0][6])))));
                    cartaJ3.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja3[1][6], baraja3[0][6])))));
                    cartaJ4.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja4[1][6], baraja4[0][6])))));
                } catch (IOException ex) {

                }
                frame.repaint();
                timer7.cancel();
            }
        };

        TimerTask timerT8 = new TimerTask() {
            @Override
            public void run() {
                frame.remove(imgJ1_8);
                frame.remove(imgJ2_8);
                frame.remove(imgJ3_8);
                frame.remove(imgJ4_8);

                try {
                    cartaJ1.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja1[1][7], baraja1[0][7])))));
                    cartaJ2.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja2[1][7], baraja2[0][7])))));
                    cartaJ3.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja3[1][7], baraja3[0][7])))));
                    cartaJ4.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja4[1][7], baraja4[0][7])))));

                } catch (IOException ex) {

                }

                frame.repaint();
                timer8.cancel();
            }
        };

        TimerTask timerT9 = new TimerTask() {
            @Override
            public void run() {
                frame.remove(imgJ1_9);
                frame.remove(imgJ2_9);
                frame.remove(imgJ3_9);
                frame.remove(imgJ4_9);

                try {
                    cartaJ1.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja1[1][8], baraja1[0][8])))));
                    cartaJ2.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja2[1][8], baraja2[0][8])))));
                    cartaJ3.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja3[1][8], baraja3[0][8])))));
                    cartaJ4.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja4[1][8], baraja4[0][8])))));
                } catch (IOException ex) {

                }

                frame.repaint();
                timer9.cancel();
            }
        };

        TimerTask timerT10 = new TimerTask() {
            @Override
            public void run() {
                frame.remove(imgJ1_10);
                frame.remove(imgJ2_10);
                frame.remove(imgJ3_10);
                frame.remove(imgJ4_10);

                try {
                    cartaJ1.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja1[1][9], baraja1[0][9])))));
                    cartaJ2.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja2[1][9], baraja2[0][9])))));
                    cartaJ3.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja3[1][9], baraja3[0][9])))));
                    cartaJ4.setIcon(new ImageIcon(ImageIO.read(new File(String.format("C:\\%s_%s.png", baraja4[1][9], baraja4[0][9])))));
                } catch (IOException ex) {

                }

                JLabel ganadorLabel = new JLabel();
                ganadorLabel.setFont(new Font("Arial", Font.BOLD, 45));
                ganadorLabel.setText(ganador);
                ganadorLabel.setBounds(100, 300, 5000, 200);
                frame.add(ganadorLabel);

                frame.repaint();
                timer10.cancel();
            }
        };

        timer1.schedule(timerT1, 0);
        timer2.schedule(timerT2, 1000);
        timer3.schedule(timerT3, 2000);
        timer4.schedule(timerT4, 3000);
        timer5.schedule(timerT5, 4000);
        timer6.schedule(timerT6, 5000);
        timer7.schedule(timerT7, 6000);
        timer8.schedule(timerT8, 7000);
        timer9.schedule(timerT9, 8000);
        timer10.schedule(timerT10, 9000);
        timerFinal.schedule(new TimerTask() {
            @Override
            public void run() {
                frame.setVisible(false);
                timerFinal.cancel();
            }
        }, 10000);
    }
}