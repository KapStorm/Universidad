import javax.swing.*;
import java.awt.*;
import java.io.File;

public class App extends JFrame {
    private final int WIDTH;
    private final int HEIGHT;
    private final float W_SCALE;
    private final float H_SCALE;

    public App() {
        // Titulo
        super("Proyecto 1 - Arellanes Beltrán Sebastián");

        // Tamaño de la pantalla
        Dimension tamanioPantalla = Toolkit.getDefaultToolkit().getScreenSize();

        // Variables para el ancho y altura
        WIDTH = tamanioPantalla.width;
        HEIGHT = tamanioPantalla.height;

        // Escalados, por si se requiere cambiar el tamaño de la pantalla
        // W_SCALE = WIDTH SCALE = ESCALA DEL ANCHO
        W_SCALE = (float) (Math.floor((float) WIDTH / 1024 * 1000) / 1000);
        // H_SCALE = HEIGHT SCALE = ESCALA DE LA ALTURA
        H_SCALE = (float) (Math.floor((float) HEIGHT / 698 * 1000) / 1000);

        // Configuración del frame
        this.setSize(WIDTH, HEIGHT);
        this.setDefaultCloseOperation(EXIT_ON_CLOSE);
        this.setResizable(false);
        this.setExtendedState(MAXIMIZED_BOTH);
        this.setVisible(true);
    }

    public static void main(String[] args) {
        // Inicialización de la aplicación
        new App();
    }

    @Override
    public void paint(Graphics g) {
        super.paint(g);
        // Métodos para dibujar el gráfico
        dibujarFondo(g);
        dibujarEdificiosFondo(g);
        dibujarNubes(g);
        dibujarCarretera(g);
        dibujarArboles(g);
        dibujarSupermercado(g);
        dibujarVentanasSupermercado(g);
        dibujarPuertaSupermercado(g);
        dibujarLetreroSupermercado(g);
    }

    public void dibujarFondo(Graphics g) {
        Color colorAzul = new Color(79, 200, 243);
        GradientPaint gradiente = new GradientPaint(0, 0, colorAzul, 0, (float) HEIGHT / 2, Color.WHITE);

        Graphics2D g2d = (Graphics2D) g;
        g2d.setPaint(gradiente);
        g2d.fillRect(0, 0, WIDTH, HEIGHT);
    }

    public void dibujarEdificiosFondo(Graphics g) {
        Color colorEdificioTop = new Color(59, 187, 222);
        Color colorEdificioButtom = new Color(148, 206, 218);
        GradientPaint gradient = new GradientPaint(0, 57 * H_SCALE, colorEdificioTop, 0, 552 * H_SCALE, colorEdificioButtom);
        Graphics2D g2d = (Graphics2D) g;
        g2d.setPaint(gradient);
        int[] coordsX, coordsY;

        // Edificio 1
        g2d.fillRect((int) (71 * W_SCALE), (int) (322 * H_SCALE), (int) (91 * W_SCALE), (int) (23 * H_SCALE));
        g2d.fillRect((int) (71 * W_SCALE), (int) (322 * H_SCALE), (int) (14 * W_SCALE), HEIGHT);
        g2d.fillRect((int) (111 * W_SCALE), (int) (322 * H_SCALE), (int) (10 * W_SCALE), HEIGHT);
        g2d.fillRect((int) (148 * W_SCALE), (int) (322 * H_SCALE), (int) (14 * W_SCALE), HEIGHT);

        for (int i = 0; i <= 14 * 8; i += 14) {
            g2d.fillRect((int) (71 * W_SCALE), (int) ((355 + i) * H_SCALE), (int) (90 * W_SCALE), (int) (5 * H_SCALE));
        }
        g2d.fillRect((int) (71 * W_SCALE), (int) (465 * H_SCALE), (int) (91 * W_SCALE), HEIGHT);

        // Edificio 2
        coordsX = new int[]{
                (int) (277 * W_SCALE),
                (int) (192 * W_SCALE),
                (int) (177 * W_SCALE),
                (int) (177 * W_SCALE),
                (int) (277 * W_SCALE)
        };
        coordsY = new int[]{
                (int) (240 * H_SCALE),
                (int) (240 * H_SCALE),
                (int) (255 * H_SCALE),
                HEIGHT,
                HEIGHT
        };
        Polygon edif2 = new Polygon(coordsX, coordsY, 5);
        g2d.fillPolygon(edif2);

        // Edificio 3
        coordsX = new int[]{
                (int) (286 * W_SCALE),
                (int) (358 * W_SCALE),
                (int) (376 * W_SCALE),
                (int) (376 * W_SCALE),
                (int) (286 * W_SCALE)
        };
        coordsY = new int[]{
                (int) (101 * H_SCALE),
                (int) (101 * H_SCALE),
                (int) (120 * H_SCALE),
                HEIGHT,
                HEIGHT
        };
        Polygon edif3 = new Polygon(coordsX, coordsY, 5);
        g2d.fillPolygon(edif3);

        // Edificio 4
        g2d.fillRect((int) (385 * W_SCALE), (int) (153 * H_SCALE), (int) (166 * W_SCALE), (int) (34 * H_SCALE));
        g2d.fillRect((int) (385 * W_SCALE), (int) (153 * H_SCALE), (int) (21 * W_SCALE), HEIGHT);
        g2d.fillRect((int) (530 * W_SCALE), (int) (153 * H_SCALE), (int) (21 * W_SCALE), HEIGHT);

        for (int i = 0; i < 25 * 4; i += 25) {
            g2d.fillRect((int) ((427 + i) * W_SCALE), (int) (153 * H_SCALE), (int) (7 * W_SCALE), HEIGHT);
        }

        for (int i = 0; i < 23 * 20; i += 23) {
            g2d.fillRect((int) (385 * W_SCALE), (int) ((204 + i) * H_SCALE), (int) (166 * W_SCALE), (int) (6 * H_SCALE));
        }

        // Edificio 5
        g2d.fillRect((int) (560 * W_SCALE), (int) (57 * H_SCALE), (int) (126 * W_SCALE), (int) (18 * H_SCALE));
        g2d.fillRect((int) (560 * W_SCALE), (int) (57 * H_SCALE), (int) (18 * W_SCALE), HEIGHT);
        g2d.fillRect((int) (619 * W_SCALE), (int) (57 * H_SCALE), (int) (12 * W_SCALE), HEIGHT);
        g2d.fillRect((int) (670 * W_SCALE), (int) (57 * H_SCALE), (int) (18 * W_SCALE), HEIGHT);

        for (int i = 0; i <= 25 * 20; i += 25) {
            g2d.fillRect((int) (560 * W_SCALE), (int) ((91 + i) * H_SCALE), (int) (126 * W_SCALE), (int) (9 * H_SCALE));
        }

        // Edificio 6
        g2d.fillRect((int) (698 * W_SCALE), (int) (250 * H_SCALE), (int) (14 * W_SCALE), HEIGHT);
        g2d.fillRect((int) (828 * W_SCALE), (int) (250 * H_SCALE), (int) (14 * W_SCALE), HEIGHT);
        g2d.fillRect((int) (698 * W_SCALE), (int) (250 * H_SCALE), (int) (144 * W_SCALE), (int) (20 * W_SCALE));
        g2d.fillRect((int) (698 * W_SCALE), (int) (287 * H_SCALE), (int) (144 * W_SCALE), (int) (10 * W_SCALE));

        // Edificio 7
        coordsX = new int[]{
                (int) (860 * W_SCALE),
                (int) (925 * W_SCALE),
                (int) (961 * W_SCALE),
                (int) (961 * W_SCALE),
                (int) (860 * W_SCALE)
        };
        coordsY = new int[]{
                (int) (204 * H_SCALE),
                (int) (204 * H_SCALE),
                (int) (240 * H_SCALE),
                HEIGHT,
                HEIGHT
        };
        g2d.fillPolygon(coordsX, coordsY, 5);

    }

    public void dibujarNubes(Graphics g) {
        Graphics2D g2d = (Graphics2D) g;
        GradientPaint gradiente;
        Color colorNubeGrande = new Color(175, 226, 247);
        Color colorNubeChica = new Color(207, 246, 255);

        // Nube grande izq.
        gradiente = new GradientPaint(110 * W_SCALE, 100 * H_SCALE, Color.WHITE, 200 * W_SCALE, 100 * H_SCALE, colorNubeGrande);
        g2d.setPaint(gradiente);
        g2d.fillArc((int) (134 * W_SCALE), (int) (72 * H_SCALE), (int) (70 * W_SCALE), (int) (106 * H_SCALE), 0, 180);
        g2d.fillArc((int) (110 * W_SCALE), (int) (100 * H_SCALE), (int) (50 * W_SCALE), (int) (50 * H_SCALE), 0, 180);
        g2d.fillArc((int) (185 * W_SCALE), (int) (90 * H_SCALE), (int) (50 * W_SCALE), (int) (70 * H_SCALE), 0, 180);

        // Nube grande derecho
        gradiente = new GradientPaint(830 * W_SCALE, 100 * H_SCALE, Color.WHITE, 920 * W_SCALE, 100 * H_SCALE, colorNubeGrande);
        g2d.setPaint(gradiente);
        g2d.fillArc((int) ((110+720) * W_SCALE), (int) (85 * H_SCALE), (int) (50 * W_SCALE), (int) (50 * H_SCALE), 0, 180);
        g2d.fillArc((int) ((134+720) * W_SCALE), (int) (57 * H_SCALE), (int) (70 * W_SCALE), (int) (106 * H_SCALE), 0, 180);
        g2d.fillArc((int) ((185+720) * W_SCALE), (int) (75 * H_SCALE), (int) (50 * W_SCALE), (int) (70 * H_SCALE), 0, 180);

        // Nube chica izq.
        gradiente = new GradientPaint(48 * W_SCALE, 100 * H_SCALE, Color.WHITE, 150 * W_SCALE, 100 * H_SCALE, colorNubeChica);
        g2d.setPaint(gradiente);
        g2d.fillArc((int) (48 * W_SCALE), (int) (177 * H_SCALE), (int) (74 * W_SCALE), (int) (35 * H_SCALE), 0, 180);
        g2d.fillArc((int) (58 * W_SCALE), (int) (170 * H_SCALE), (int) (20 * W_SCALE), (int) (20 * H_SCALE), 0, 360);
        g2d.fillArc((int) (70 * W_SCALE), (int) (157 * H_SCALE), (int) (40 * W_SCALE), (int) (50 * H_SCALE), -30, 210);

        // Nube grande derecho
        gradiente = new GradientPaint(748 * W_SCALE, 100 * H_SCALE, Color.WHITE, 850 * W_SCALE, 100 * H_SCALE, colorNubeChica);
        g2d.setPaint(gradiente);
        g2d.fillArc((int) ((48+700) * W_SCALE), (int) (157 * H_SCALE), (int) (68 * W_SCALE), (int) (30 * H_SCALE), 0, 180);
        g2d.fillArc((int) ((58+700) * W_SCALE), (int) (150 * H_SCALE), (int) (18 * W_SCALE), (int) (18 * H_SCALE), 0, 360);
        g2d.fillArc((int) ((70+700) * W_SCALE), (int) (140 * H_SCALE), (int) (36 * W_SCALE), (int) (38 * H_SCALE), -30, 210);
    }

    public void dibujarCarretera(Graphics g) {
        Color colorAsfalto = new Color(83, 76, 68);
        Color colorBanqueta = new Color(139, 142, 149);

        // Banqueta
        g.setColor(colorBanqueta);
        g.fillRect(0, (int) (552 * H_SCALE), WIDTH, (int) (12 * H_SCALE));

        // Carretera
        g.setColor(colorAsfalto);
        g.fillRect(0, (int) (563 * H_SCALE), WIDTH, HEIGHT);

        // Linea blanca de tránsito
        g.setColor(Color.WHITE);
        g.fillRect(0, (int) (632 * H_SCALE), WIDTH, (int) (14 * H_SCALE));
    }

    public void dibujarArboles(Graphics g)  {
        Color colorVerde1 = new Color(83, 189, 89);
        Color colorVerde2 = new Color(137, 196, 86);
        Color colorVerde3 = new Color(13, 155, 81);
        Color colorTronco = new Color(94, 48, 22);
        int[] coordsX, coordsY;

        // Primer árbol
        g.setColor(colorVerde1);
        g.fillOval((int) (30 * W_SCALE), (int) (445 * H_SCALE), (int) (44 * W_SCALE), (int) (87 * H_SCALE));

        // Tercer árbol, va aquí para poder ponerlo en primer plano
        g.setColor(colorVerde3);
        g.fillOval((int) (135 * W_SCALE), (int) (490 * H_SCALE), (int) (40 * W_SCALE), (int) (40 * H_SCALE));
        g.fillOval((int) (150 * W_SCALE), (int) (465 * H_SCALE), (int) (27 * W_SCALE), (int) (40 * H_SCALE));
        g.fillOval((int) (115 * W_SCALE), (int) (448 * H_SCALE), (int) (40 * W_SCALE), (int) (60 * H_SCALE));
        g.fillOval((int) (100 * W_SCALE), (int) (488 * H_SCALE), (int) (50 * W_SCALE), (int) (40 * H_SCALE));
        coordsX = new int[]{
                (int) (135 * W_SCALE),
                (int) (138 * W_SCALE),
                (int) (141 * W_SCALE),
                (int) (143 * W_SCALE),
                (int) (145 * W_SCALE),
                (int) (147 * W_SCALE),
                (int) (151 * W_SCALE),
                (int) (155 * W_SCALE),
                (int) (158 * W_SCALE),
                (int) (160 * W_SCALE),
                (int) (160 * W_SCALE),
                (int) (158 * W_SCALE),
                (int) (155 * W_SCALE),
                (int) (152 * W_SCALE),
                (int) (146 * W_SCALE),
                (int) (143 * W_SCALE),
                (int) (140 * W_SCALE),
                (int) (140 * W_SCALE),
                (int) (139 * W_SCALE),
                (int) (137 * W_SCALE),
                (int) (135 * W_SCALE),
                (int) (131 * W_SCALE),
                (int) (129 * W_SCALE),
                (int) (137 * W_SCALE),
                (int) (136 * W_SCALE),
                (int) (131 * W_SCALE),
                (int) (123 * W_SCALE)
        };
        coordsY = new int[]{
                (int) (552 * H_SCALE),
                (int) (545 * H_SCALE),
                (int) (537 * H_SCALE),
                (int) (527 * H_SCALE),
                (int) (519 * H_SCALE),
                (int) (506 * H_SCALE),
                (int) (504 * H_SCALE),
                (int) (500 * H_SCALE),
                (int) (495 * H_SCALE),
                (int) (491 * H_SCALE),
                (int) (486 * H_SCALE),
                (int) (490 * H_SCALE),
                (int) (495 * H_SCALE),
                (int) (498 * H_SCALE),
                (int) (500 * H_SCALE),
                (int) (490 * H_SCALE),
                (int) (490 * H_SCALE),
                (int) (503 * H_SCALE),
                (int) (512 * H_SCALE),
                (int) (518 * H_SCALE),
                (int) (518 * H_SCALE),
                (int) (514 * H_SCALE),
                (int) (519 * H_SCALE),
                (int) (523 * H_SCALE),
                (int) (527 * H_SCALE),
                (int) (540 * H_SCALE),
                (int) (552 * H_SCALE)
        };
        g.setColor(colorTronco);
        g.fillPolygon(coordsX, coordsY, coordsX.length);

        // Segundo árbol
        g.setColor(colorTronco);
        coordsX = new int[]{
                (int) (48 * W_SCALE),
                (int) (49 * W_SCALE),
                (int) (37 * W_SCALE),
                (int) (49 * W_SCALE),
                (int) (50 * W_SCALE),
                (int) (42 * W_SCALE),
                (int) (50 * W_SCALE),
                (int) (51 * W_SCALE),
                (int) (52 * W_SCALE),
                (int) (59 * W_SCALE),
                (int) (52 * W_SCALE),
                (int) (55 * W_SCALE),
                (int) (67 * W_SCALE),
                (int) (55 * W_SCALE),
                (int) (58 * W_SCALE)
        };
        coordsY = new int[]{
                (int) (553 * H_SCALE),
                (int) (525 * H_SCALE),
                (int) (504 * H_SCALE),
                (int) (520 * H_SCALE),
                (int) (491 * H_SCALE),
                (int) (474 * H_SCALE),
                (int) (487 * H_SCALE),
                (int) (459 * H_SCALE),
                (int) (474 * H_SCALE),
                (int) (467 * H_SCALE),
                (int) (477 * H_SCALE),
                (int) (504 * H_SCALE),
                (int) (492 * H_SCALE),
                (int) (509 * H_SCALE),
                (int) (553 * H_SCALE)
        };
        g.fillPolygon(new Polygon(coordsX, coordsY, coordsX.length));
        g.setColor(colorVerde2);
        g.fillOval((int) (71 * W_SCALE), (int) (405 * H_SCALE), (int) (77 * W_SCALE), (int) (125 * H_SCALE));

        // Quinto árbol
        g.setColor(colorVerde3);
        g.fillOval((int) ((135 + 838) * W_SCALE), (int) (490 * H_SCALE), (int) (40 * W_SCALE), (int) (40 * H_SCALE));
        g.fillOval((int) ((145 + 838) * W_SCALE), (int) (465 * H_SCALE), (int) (30 * W_SCALE), (int) (40 * H_SCALE));
        g.fillOval((int) ((115 + 838) * W_SCALE), (int) (448 * H_SCALE), (int) (40 * W_SCALE), (int) (60 * H_SCALE));
        g.fillOval((int) ((100 + 838) * W_SCALE), (int) (488 * H_SCALE), (int) (50 * W_SCALE), (int) (40 * H_SCALE));
        coordsX = new int[]{
                (int) ((135 + 838) * W_SCALE),
                (int) ((138 + 838) * W_SCALE),
                (int) ((141 + 838) * W_SCALE),
                (int) ((143 + 838) * W_SCALE),
                (int) ((145 + 838) * W_SCALE),
                (int) ((147 + 838) * W_SCALE),
                (int) ((151 + 838) * W_SCALE),
                (int) ((155 + 838) * W_SCALE),
                (int) ((158 + 838) * W_SCALE),
                (int) ((160 + 838) * W_SCALE),
                (int) ((160 + 838) * W_SCALE),
                (int) ((158 + 838) * W_SCALE),
                (int) ((155 + 838) * W_SCALE),
                (int) ((152 + 838) * W_SCALE),
                (int) ((146 + 838) * W_SCALE),
                (int) ((143 + 838) * W_SCALE),
                (int) ((140 + 838) * W_SCALE),
                (int) ((140 + 838) * W_SCALE),
                (int) ((139 + 838) * W_SCALE),
                (int) ((137 + 838) * W_SCALE),
                (int) ((135 + 838) * W_SCALE),
                (int) ((131 + 838) * W_SCALE),
                (int) ((129 + 838) * W_SCALE),
                (int) ((137 + 838) * W_SCALE),
                (int) ((136 + 838) * W_SCALE),
                (int) ((131 + 838) * W_SCALE),
                (int) ((123 + 838) * W_SCALE)
        };
        coordsY = new int[]{
                (int) (552 * H_SCALE),
                (int) (545 * H_SCALE),
                (int) (537 * H_SCALE),
                (int) (527 * H_SCALE),
                (int) (519 * H_SCALE),
                (int) (506 * H_SCALE),
                (int) (504 * H_SCALE),
                (int) (500 * H_SCALE),
                (int) (495 * H_SCALE),
                (int) (491 * H_SCALE),
                (int) (486 * H_SCALE),
                (int) (490 * H_SCALE),
                (int) (495 * H_SCALE),
                (int) (498 * H_SCALE),
                (int) (500 * H_SCALE),
                (int) (490 * H_SCALE),
                (int) (490 * H_SCALE),
                (int) (503 * H_SCALE),
                (int) (512 * H_SCALE),
                (int) (518 * H_SCALE),
                (int) (518 * H_SCALE),
                (int) (514 * H_SCALE),
                (int) (519 * H_SCALE),
                (int) (523 * H_SCALE),
                (int) (527 * H_SCALE),
                (int) (540 * H_SCALE),
                (int) (552 * H_SCALE)
        };
        g.setColor(colorTronco);
        g.fillPolygon(coordsX, coordsY, coordsX.length);

        // Cuarto árbol, va aquí para poder ponerlo en primer plano
        g.setColor(colorVerde2);
        g.fillOval((int) (905 * W_SCALE), (int) (405 * H_SCALE), (int) (77 * W_SCALE), (int) (135 * H_SCALE));

        g.setColor(colorTronco);
        coordsX = new int[]{
                (int) (101 * W_SCALE),
                (int) (102 * W_SCALE),
                (int) (86 * W_SCALE),
                (int) (103 * W_SCALE),
                (int) (104 * W_SCALE),
                (int) (93 * W_SCALE),
                (int) (104 * W_SCALE),
                (int) (106 * W_SCALE),
                (int) (108 * W_SCALE),
                (int) (117 * W_SCALE),
                (int) (108 * W_SCALE),
                (int) (111 * W_SCALE),
                (int) (128 * W_SCALE),
                (int) (111 * W_SCALE),
                (int) (116 * W_SCALE)
        };
        coordsY = new int[]{
                (int) (564 * H_SCALE),
                (int) (525 * H_SCALE),
                (int) (494 * H_SCALE),
                (int) (516 * H_SCALE),
                (int) (476 * H_SCALE),
                (int) (451 * H_SCALE),
                (int) (470 * H_SCALE),
                (int) (430 * H_SCALE),
                (int) (452 * H_SCALE),
                (int) (441 * H_SCALE),
                (int) (455 * H_SCALE),
                (int) (496 * H_SCALE),
                (int) (477 * H_SCALE),
                (int) (502 * H_SCALE),
                (int) (564 * H_SCALE)
        };
        g.fillPolygon(new Polygon(coordsX, coordsY, coordsX.length));
        coordsX = new int[]{
                (int) ((101+838) * W_SCALE),
                (int) ((102+838) * W_SCALE),
                (int) ((86+838) * W_SCALE),
                (int) ((103+838) * W_SCALE),
                (int) ((104+838) * W_SCALE),
                (int) ((93+838) * W_SCALE),
                (int) ((104+838) * W_SCALE),
                (int) ((106+838) * W_SCALE),
                (int) ((108+838) * W_SCALE),
                (int) ((117+838) * W_SCALE),
                (int) ((108+838) * W_SCALE),
                (int) ((111+838) * W_SCALE),
                (int) ((128+838) * W_SCALE),
                (int) ((111+838) * W_SCALE),
                (int) ((116+838) * W_SCALE)
        };
        g.fillPolygon(new Polygon(coordsX, coordsY, coordsX.length));
    }

    public void dibujarSupermercado(Graphics g) {
        Color colorRojoClaroTecho = new Color(240, 80, 68);
        Color colorRojoOscuroTecho = new Color(213, 66, 48);
        Color colorTechoGris1 = new Color(225, 227, 226);
        Color colorTechoGris2 = new Color(169, 171, 170);
        Color colorParedEdificio = new Color(216, 215, 211);
        Color colorSueloGris1 = new Color(228, 230, 229);
        Color colorSueloGris2 = new Color(208, 210, 209);
        int[] coordsX, coordsY;

        // Techo 1
        g.setColor(colorRojoClaroTecho);
        g.fillRect((int) (147 * W_SCALE), (int) (311 * H_SCALE), (int) (773 * W_SCALE), (int) (30 * H_SCALE));

        // Techo 2
        g.setColor(colorRojoOscuroTecho);
        coordsX = new int[]{
                (int) (147 * W_SCALE),
                (int) (155 * W_SCALE),
                (int) (911 * W_SCALE),
                (int) (919 * W_SCALE)
        };
        coordsY = new int[]{
                (int) (340 * H_SCALE),
                (int) (368 * H_SCALE),
                (int) (368 * H_SCALE),
                (int) (340 * H_SCALE),
        };
        Polygon pol1 = new Polygon(coordsX, coordsY, 4);
        g.fillPolygon(pol1);

        // Rectangulo blanco del techo
        g.setColor(Color.WHITE);
        g.fillRect((int) (155 * W_SCALE), (int) (366 * H_SCALE), (int) (757 * W_SCALE), (int) (5 * H_SCALE));

        // Rectangulo gris del techo
        g.setColor(colorTechoGris1);
        g.fillRect((int) (159 * W_SCALE), (int) (370 * H_SCALE), (int) (749 * W_SCALE), (int) (5 * H_SCALE));

        // Rectangulo de la sombra del techo
        g.setColor(colorTechoGris2);
        g.fillRect((int) (173 * W_SCALE), (int) (374 * H_SCALE), (int) (723 * W_SCALE), (int) (8 * H_SCALE));

        // Pared del edificio
        g.setColor(colorParedEdificio);
        g.fillRect((int) (173 * W_SCALE), (int) (381 * H_SCALE), (int) (723 * W_SCALE), (int) (165 * H_SCALE));

        // Rectangulo gris del suelo del edificio
        g.setColor(colorSueloGris1);
        g.fillRect((int) (167 * W_SCALE), (int) (545 * H_SCALE), (int) (735 * W_SCALE), (int) (9 * H_SCALE));

        // Rectangulo gris oscuro del suelo del edifico
        g.setColor(colorSueloGris2);
        g.fillRect((int) (158 * W_SCALE), (int) (553 * H_SCALE), (int) (753 * W_SCALE), (int) (10 * H_SCALE));

    }

    public void dibujarVentanasSupermercado(Graphics g) {
        Color colorVentanas = new Color(48, 191, 199);
        Color colorSombreadoVentanas = new Color(13, 175, 188);
        Color colorSombra = new Color(0, 0, 0, 0.275f);
        Color colorLinea = new Color(161, 158, 165);
        int[] coordsX, coordsY;
        Graphics2D g2d = (Graphics2D) g;

        // Marco de las ventanas
        g.setColor(Color.WHITE);
        g.fillRect((int) (184 * W_SCALE), (int) (391 * H_SCALE), (int) (39 * W_SCALE), (int) (142 * H_SCALE));
        g.fillRect((int) (232 * W_SCALE), (int) (391 * H_SCALE), (int) (76 * W_SCALE), (int) (142 * H_SCALE));
        g.fillRect((int) (318 * W_SCALE), (int) (391 * H_SCALE), (int) (76 * W_SCALE), (int) (142 * H_SCALE));
        g.fillRect((int) (404 * W_SCALE), (int) (391 * H_SCALE), (int) (39 * W_SCALE), (int) (142 * H_SCALE));

        g.fillRect((int) (627 * W_SCALE), (int) (391 * H_SCALE), (int) (39 * W_SCALE), (int) (142 * H_SCALE));
        g.fillRect((int) (674 * W_SCALE), (int) (391 * H_SCALE), (int) (76 * W_SCALE), (int) (142 * H_SCALE));
        g.fillRect((int) (761 * W_SCALE), (int) (391 * H_SCALE), (int) (76 * W_SCALE), (int) (142 * H_SCALE));
        g.fillRect((int) (847 * W_SCALE), (int) (391 * H_SCALE), (int) (39 * W_SCALE), (int) (142 * H_SCALE));

        // Cristal de las ventanas
        g.setColor(colorVentanas);
        g.fillRect((int) (190 * W_SCALE), (int) (397 * H_SCALE), (int) (28 * W_SCALE), (int) (130 * H_SCALE));
        g.fillRect((int) (238 * W_SCALE), (int) (397 * H_SCALE), (int) (64 * W_SCALE), (int) (130 * H_SCALE));
        g.fillRect((int) (324 * W_SCALE), (int) (397 * H_SCALE), (int) (64 * W_SCALE), (int) (130 * H_SCALE));
        g.fillRect((int) (410 * W_SCALE), (int) (397 * H_SCALE), (int) (28 * W_SCALE), (int) (130 * H_SCALE));

        g.fillRect((int) (633 * W_SCALE), (int) (397 * H_SCALE), (int) (28 * W_SCALE), (int) (130 * H_SCALE));
        g.fillRect((int) (680 * W_SCALE), (int) (397 * H_SCALE), (int) (64 * W_SCALE), (int) (130 * H_SCALE));
        g.fillRect((int) (767 * W_SCALE), (int) (397 * H_SCALE), (int) (64 * W_SCALE), (int) (130 * H_SCALE));
        g.fillRect((int) (853 * W_SCALE), (int) (397 * H_SCALE), (int) (28 * W_SCALE), (int) (130 * H_SCALE));

        // Sombreado de las ventanas
        g.setColor(colorSombreadoVentanas);
        coordsX = new int[]{
                (int) (218 * W_SCALE),
                (int) (190 * W_SCALE),
                (int) (218 * W_SCALE)
        };
        coordsY = new int[]{
                (int) (396 * H_SCALE),
                (int) (527 * H_SCALE),
                (int) (527 * H_SCALE)
        };
        Polygon ventana1 = new Polygon(coordsX, coordsY, 3);

        coordsX = new int[]{
                (int) (302 * W_SCALE),
                (int) (302 * W_SCALE),
                (int) (238 * W_SCALE)
        };
        coordsY = new int[]{
                (int) (396 * H_SCALE),
                (int) (527 * H_SCALE),
                (int) (527 * H_SCALE)
        };
        Polygon ventana2 = new Polygon(coordsX, coordsY, 3);

        coordsX = new int[]{
                (int) (388 * W_SCALE),
                (int) (388 * W_SCALE),
                (int) (324 * W_SCALE)
        };
        coordsY = new int[]{
                (int) (396 * H_SCALE),
                (int) (527 * H_SCALE),
                (int) (527 * H_SCALE)
        };
        Polygon ventana3 = new Polygon(coordsX, coordsY, 3);

        coordsX = new int[]{
                (int) (437 * W_SCALE),
                (int) (437 * W_SCALE),
                (int) (410 * W_SCALE)
        };
        coordsY = new int[]{
                (int) (396 * H_SCALE),
                (int) (527 * H_SCALE),
                (int) (527 * H_SCALE)
        };
        Polygon ventana4 = new Polygon(coordsX, coordsY, 3);

        coordsX = new int[]{
                (int) (660 * W_SCALE),
                (int) (660 * W_SCALE),
                (int) (633 * W_SCALE)
        };
        coordsY = new int[]{
                (int) (396 * H_SCALE),
                (int) (527 * H_SCALE),
                (int) (527 * H_SCALE)
        };
        Polygon ventana5 = new Polygon(coordsX, coordsY, 3);

        coordsX = new int[]{
                (int) (744 * W_SCALE),
                (int) (744 * W_SCALE),
                (int) (680 * W_SCALE)
        };
        coordsY = new int[]{
                (int) (396 * H_SCALE),
                (int) (527 * H_SCALE),
                (int) (527 * H_SCALE)
        };
        Polygon ventana6 = new Polygon(coordsX, coordsY, 3);

        coordsX = new int[]{
                (int) (830 * W_SCALE),
                (int) (830 * W_SCALE),
                (int) (766 * W_SCALE)
        };
        coordsY = new int[]{
                (int) (396 * H_SCALE),
                (int) (527 * H_SCALE),
                (int) (527 * H_SCALE)
        };
        Polygon ventana7 = new Polygon(coordsX, coordsY, 3);

        coordsX = new int[]{
                (int) (880 * W_SCALE),
                (int) (880 * W_SCALE),
                (int) (853 * W_SCALE)
        };
        coordsY = new int[]{
                (int) (396 * H_SCALE),
                (int) (527 * H_SCALE),
                (int) (527 * H_SCALE)
        };
        Polygon ventana8 = new Polygon(coordsX, coordsY, 3);

        g.fillPolygon(ventana1);
        g.fillPolygon(ventana2);
        g.fillPolygon(ventana3);
        g.fillPolygon(ventana4);
        g.fillPolygon(ventana5);
        g.fillPolygon(ventana6);
        g.fillPolygon(ventana7);
        g.fillPolygon(ventana8);

        // Sombra ventana 1
        g.setColor(colorSombra);
        coordsX = new int[]{
                (int) (184 * W_SCALE),
                (int) (223 * W_SCALE),
                (int) (223 * W_SCALE),
                (int) (212 * W_SCALE),
                (int) (212 * W_SCALE),
                (int) (184 * W_SCALE)
        };
        coordsY = new int[]{
                (int) (391 * H_SCALE),
                (int) (391 * H_SCALE),
                (int) (532 * H_SCALE),
                (int) (532 * H_SCALE),
                (int) (403 * H_SCALE),
                (int) (403 * H_SCALE)
        };
        g.fillPolygon(new Polygon(coordsX, coordsY, 6));

        // Sombra ventana 2
        coordsX = new int[]{
                (int) (232 * W_SCALE),
                (int) (308 * W_SCALE),
                (int) (308 * W_SCALE),
                (int) (296 * W_SCALE),
                (int) (296 * W_SCALE),
                (int) (232 * W_SCALE)
        };
        coordsY = new int[]{
                (int) (391 * H_SCALE),
                (int) (391 * H_SCALE),
                (int) (532 * H_SCALE),
                (int) (532 * H_SCALE),
                (int) (403 * H_SCALE),
                (int) (403 * H_SCALE)
        };
        g.fillPolygon(new Polygon(coordsX, coordsY, 6));

        // Sombra ventana 3
        coordsX = new int[]{
                (int) (318 * W_SCALE),
                (int) (394 * W_SCALE),
                (int) (394 * W_SCALE),
                (int) (382 * W_SCALE),
                (int) (382 * W_SCALE),
                (int) (318 * W_SCALE)
        };
        coordsY = new int[]{
                (int) (391 * H_SCALE),
                (int) (391 * H_SCALE),
                (int) (532 * H_SCALE),
                (int) (532 * H_SCALE),
                (int) (403 * H_SCALE),
                (int) (403 * H_SCALE)
        };
        g.fillPolygon(new Polygon(coordsX, coordsY, 6));

        // Sombra ventana 4
        coordsX = new int[]{
                (int) (404 * W_SCALE),
                (int) (443 * W_SCALE),
                (int) (443 * W_SCALE),
                (int) (431 * W_SCALE),
                (int) (431 * W_SCALE),
                (int) (404 * W_SCALE)
        };
        coordsY = new int[]{
                (int) (391 * H_SCALE),
                (int) (391 * H_SCALE),
                (int) (532 * H_SCALE),
                (int) (532 * H_SCALE),
                (int) (403 * H_SCALE),
                (int) (403 * H_SCALE)
        };
        g.fillPolygon(new Polygon(coordsX, coordsY, 6));

        // Sombra ventana 5
        coordsX = new int[]{
                (int) (627 * W_SCALE),
                (int) (666 * W_SCALE),
                (int) (666 * W_SCALE),
                (int) (654 * W_SCALE),
                (int) (654 * W_SCALE),
                (int) (627 * W_SCALE)
        };
        coordsY = new int[]{
                (int) (391 * H_SCALE),
                (int) (391 * H_SCALE),
                (int) (532 * H_SCALE),
                (int) (532 * H_SCALE),
                (int) (403 * H_SCALE),
                (int) (403 * H_SCALE)
        };
        g.fillPolygon(new Polygon(coordsX, coordsY, 6));

        // Sombra ventana 6
        coordsX = new int[]{
                (int) (674 * W_SCALE),
                (int) (750 * W_SCALE),
                (int) (750 * W_SCALE),
                (int) (735 * W_SCALE),
                (int) (735 * W_SCALE),
                (int) (674 * W_SCALE)
        };
        coordsY = new int[]{
                (int) (391 * H_SCALE),
                (int) (391 * H_SCALE),
                (int) (532 * H_SCALE),
                (int) (532 * H_SCALE),
                (int) (403 * H_SCALE),
                (int) (403 * H_SCALE)
        };
        g.fillPolygon(new Polygon(coordsX, coordsY, 6));

        // Sombra ventana 7
        coordsX = new int[]{
                (int) (761 * W_SCALE),
                (int) (837 * W_SCALE),
                (int) (837 * W_SCALE),
                (int) (822 * W_SCALE),
                (int) (822 * W_SCALE),
                (int) (761 * W_SCALE)
        };
        coordsY = new int[]{
                (int) (391 * H_SCALE),
                (int) (391 * H_SCALE),
                (int) (532 * H_SCALE),
                (int) (532 * H_SCALE),
                (int) (403 * H_SCALE),
                (int) (403 * H_SCALE)
        };
        g.fillPolygon(new Polygon(coordsX, coordsY, 6));

        // Sombra ventana 8
        coordsX = new int[]{
                (int) (847 * W_SCALE), // 846
                (int) (887 * W_SCALE),
                (int) (887 * W_SCALE),
                (int) (872 * W_SCALE),
                (int) (872 * W_SCALE),
                (int) (847 * W_SCALE)
        };
        coordsY = new int[]{
                (int) (391 * H_SCALE),
                (int) (391 * H_SCALE),
                (int) (532 * H_SCALE),
                (int) (532 * H_SCALE),
                (int) (403 * H_SCALE),
                (int) (403 * H_SCALE)
        };
        g.fillPolygon(new Polygon(coordsX, coordsY, 6));

        // Lineas de los marcos
        g2d.setColor(colorLinea);
        g2d.setStroke(new BasicStroke(2f * W_SCALE));

        g2d.drawLine((int) (185 * W_SCALE), (int) (390 * H_SCALE), (int) (222 * W_SCALE), (int) (390 * H_SCALE));
        g2d.drawLine((int) (222 * W_SCALE), (int) (390 * H_SCALE), (int) (222 * W_SCALE), (int) (531 * H_SCALE));

        g2d.drawLine((int) (233 * W_SCALE), (int) (390 * H_SCALE), (int) (307 * W_SCALE), (int) (390 * H_SCALE));
        g2d.drawLine((int) (307 * W_SCALE), (int) (390 * H_SCALE), (int) (307 * W_SCALE), (int) (531 * H_SCALE));

        g2d.drawLine((int) (319 * W_SCALE), (int) (390 * H_SCALE), (int) (393 * W_SCALE), (int) (390 * H_SCALE));
        g2d.drawLine((int) (393 * W_SCALE), (int) (390 * H_SCALE), (int) (393 * W_SCALE), (int) (531 * H_SCALE));

        g2d.drawLine((int) (405 * W_SCALE), (int) (390 * H_SCALE), (int) (442 * W_SCALE), (int) (390 * H_SCALE));
        g2d.drawLine((int) (442 * W_SCALE), (int) (390 * H_SCALE), (int) (442 * W_SCALE), (int) (531 * H_SCALE));

        g2d.drawLine((int) (628 * W_SCALE), (int) (390 * H_SCALE), (int) (665 * W_SCALE), (int) (390 * H_SCALE));
        g2d.drawLine((int) (665 * W_SCALE), (int) (390 * H_SCALE), (int) (665 * W_SCALE), (int) (531 * H_SCALE));

        g2d.drawLine((int) (675 * W_SCALE), (int) (390 * H_SCALE), (int) (750 * W_SCALE), (int) (390 * H_SCALE));
        g2d.drawLine((int) (750 * W_SCALE), (int) (390 * H_SCALE), (int) (750 * W_SCALE), (int) (531 * H_SCALE));

        g2d.drawLine((int) (762 * W_SCALE), (int) (390 * H_SCALE), (int) (837 * W_SCALE), (int) (390 * H_SCALE));
        g2d.drawLine((int) (837 * W_SCALE), (int) (390 * H_SCALE), (int) (837 * W_SCALE), (int) (531 * H_SCALE));

        g2d.drawLine((int) (848 * W_SCALE), (int) (390 * H_SCALE), (int) (886 * W_SCALE), (int) (390 * H_SCALE));
        g2d.drawLine((int) (886 * W_SCALE), (int) (390 * H_SCALE), (int) (886 * W_SCALE), (int) (531 * H_SCALE));
    }

    public void dibujarPuertaSupermercado(Graphics g) {
        Color colorVentana1 = new Color(48, 191, 199);
        Color colorVentana2 = new Color(13, 175, 188);
        Color colorLineasVentanas = new Color(22, 120, 121);
        Color colorLineasMarcoDePuerta = new Color(120, 124, 125);
        Color colorRojo1 = new Color(218, 62, 39);
        Color colorRojo2 = new Color(241, 82, 63);
        Color colorBlanco2 = new Color(222, 226, 227);
        Color colorSombra = new Color(0, 0, 0, 0.2f);
        Color colorManijaPuertas = colorSombra;
        Color colorEscaleras = new Color(196, 198, 197);
        Graphics2D g2d = (Graphics2D) g;

        // Pared de la puerta
        g.setColor(Color.WHITE);
        g.fillRect((int) (462 * W_SCALE), (int) (429 * H_SCALE), (int) (144 * W_SCALE), (int) (117 * H_SCALE));

        // Ventanas
        g.setColor(colorVentana1);
        g.fillRect((int) (467 * W_SCALE), (int) (434 * H_SCALE), (int) (12 * W_SCALE), (int) (108 * H_SCALE));
        g.fillRect((int) (488 * W_SCALE), (int) (455 * H_SCALE), (int) (42 * W_SCALE), (int) (87 * H_SCALE));
        g.fillRect((int) (539 * W_SCALE), (int) (455 * H_SCALE), (int) (42 * W_SCALE), (int) (87 * H_SCALE));

        g.setColor(colorVentana2);
        g.fillRect((int) (589 * W_SCALE), (int) (434 * H_SCALE), (int) (12 * W_SCALE), (int) (108 * H_SCALE));
        g.fillRect((int) (539 * W_SCALE), (int) (434 * H_SCALE), (int) (42 * W_SCALE), (int) (12 * H_SCALE));
        g.fillRect((int) (488 * W_SCALE), (int) (434 * H_SCALE), (int) (42 * W_SCALE), (int) (12 * H_SCALE));

        // Manija de las puertas
        g2d.setColor(colorManijaPuertas);
        g2d.setStroke(new BasicStroke(W_SCALE));
        g2d.drawLine((int) (532 * W_SCALE), (int) (487 * H_SCALE), (int) (532 * W_SCALE), (int) (509 * H_SCALE));
        g2d.drawLine((int) (537 * W_SCALE), (int) (487 * H_SCALE), (int) (537 * W_SCALE), (int) (509 * H_SCALE));

        // Lineas del marco de la puerta
        g2d.setColor(colorLineasMarcoDePuerta);
        g2d.setStroke(new BasicStroke(1.8f * W_SCALE));
        g2d.drawLine((int) (461 * W_SCALE), (int) (544 * H_SCALE), (int) (461 * W_SCALE), (int) (428 * H_SCALE));
        g2d.drawLine((int) (461 * W_SCALE), (int) (428 * H_SCALE), (int) (606 * W_SCALE), (int) (428 * H_SCALE));
        g2d.drawLine((int) (606 * W_SCALE), (int) (544 * H_SCALE), (int) (606 * W_SCALE), (int) (428 * H_SCALE));

        // Sombreado
        g.setColor(colorVentana2);
        g.fillPolygon(new Polygon(new int[]{(int) (488 * W_SCALE), (int) (530 * W_SCALE), (int) (530 * W_SCALE)},
                new int[]{(int) (541 * H_SCALE), (int) (458 * H_SCALE), (int) (541 * H_SCALE)},
                3));

        g.fillPolygon(new Polygon(new int[]{(int) (539 * W_SCALE), (int) (580 * W_SCALE), (int) (580 * W_SCALE)},
                new int[]{(int) (541 * H_SCALE), (int) (458 * H_SCALE), (int) (541 * H_SCALE)},
                3));

        g.fillPolygon(new Polygon(
                new int[]{(int) (468 * W_SCALE), (int) (478 * W_SCALE), (int) (478 * W_SCALE)},
                new int[]{(int) (541 * H_SCALE), (int) (458 * H_SCALE), (int) (541 * H_SCALE)},
                3));

        // Lineas de las ventanas
        g2d.setColor(colorLineasVentanas);
        g2d.setStroke(new BasicStroke(W_SCALE));
        g2d.drawLine((int) (489 * W_SCALE), (int) (456 * H_SCALE), (int) (489 * W_SCALE), (int) (541 * H_SCALE));
        g2d.drawLine((int) (539 * W_SCALE), (int) (456 * H_SCALE), (int) (539 * W_SCALE), (int) (541 * H_SCALE));
        g2d.drawLine((int) (489 * W_SCALE), (int) (456 * H_SCALE), (int) (529 * W_SCALE), (int) (456 * H_SCALE));
        g2d.drawLine((int) (539 * W_SCALE), (int) (456 * H_SCALE), (int) (579 * W_SCALE), (int) (456 * H_SCALE));

        g2d.drawLine((int) (489 * W_SCALE), (int) (435 * H_SCALE), (int) (489 * W_SCALE), (int) (445 * H_SCALE));
        g2d.drawLine((int) (539 * W_SCALE), (int) (435 * H_SCALE), (int) (539 * W_SCALE), (int) (445 * H_SCALE));

        g2d.drawLine((int) (467 * W_SCALE), (int) (435 * H_SCALE), (int) (467 * W_SCALE), (int) (541 * H_SCALE));
        g2d.drawLine((int) (589 * W_SCALE), (int) (435 * H_SCALE), (int) (589 * W_SCALE), (int) (541 * H_SCALE));

        // Sombras marquesina
        g.setColor(colorSombra);
        for (double i = 0; i < 14.94 * 13; i += 14.95) {
            g.fillRect((int) ((437 + i) * W_SCALE), (int) (422 * H_SCALE), (int) (15 * W_SCALE), (int) (12 * H_SCALE));
            g.fillArc((int) ((437 + i) * W_SCALE), (int) (421 * H_SCALE), (int) (15 * W_SCALE), (int) (25 * H_SCALE), 180, 180);
        }

        g.fillPolygon(new Polygon(
                new int[]{(int) (455 * W_SCALE), (int) (462 * W_SCALE), (int) (462 * W_SCALE), (int) (606 * W_SCALE), (int) (606 * W_SCALE), (int) (613 * W_SCALE)},
                new int[]{(int) (420 * H_SCALE), (int) (497 * H_SCALE), (int) (438 * H_SCALE), (int) (438 * H_SCALE), (int) (497 * H_SCALE), (int) (420 * H_SCALE)},
                6));

        g.fillRect((int) (596 * W_SCALE), (int) (438 * H_SCALE), (int) (11 * W_SCALE), (int) (108 * H_SCALE));

        // Marquesina
        for (double i = 0, j = 0; i < 15 * 13; i += 15, j += 13.9) {
            g.setColor(i % 2 == 0 ? colorRojo2 : colorBlanco2);
            g.fillPolygon(new Polygon(
                    new int[]{(int) ((444 + j) * W_SCALE), (int) ((459 + j) * W_SCALE), (int) ((452 + i) * W_SCALE), (int) ((437 + i) * W_SCALE)},
                    new int[]{(int) (381 * H_SCALE), (int) (381 * H_SCALE), (int) (412 * H_SCALE), (int) (412 * H_SCALE)},
                    4));

            g.setColor(i % 2 == 0 ? colorRojo1 : Color.WHITE);
            g.fillRect((int) ((437 + i) * W_SCALE), (int) (412 * H_SCALE), (int) (15 * W_SCALE), (int) (10 * H_SCALE));
            g.fillArc((int) ((437 + i) * W_SCALE), (int) (406 * H_SCALE), (int) (15 * W_SCALE), (int) (25 * H_SCALE), 180, 180);
        }

        // Escaleras
        g.setColor(Color.WHITE);
        g.fillRect((int) (434 * W_SCALE), (int) (561 * H_SCALE), (int) (200 * W_SCALE), (int) (4 * H_SCALE));
        g.fillRect((int) (440 * W_SCALE), (int) (553 * H_SCALE), (int) (188 * W_SCALE), (int) (4 * H_SCALE));
        g.setColor(colorEscaleras);
        g.fillRect((int) (437 * W_SCALE), (int) (557 * H_SCALE), (int) (195 * W_SCALE), (int) (4 * H_SCALE));
        g.fillRect((int) (442 * W_SCALE), (int) (549 * H_SCALE), (int) (184 * W_SCALE), (int) (4 * H_SCALE));
    }

    public void dibujarLetreroSupermercado(Graphics g) {
        Font fuenteChica, fuenteGrande;
        try {
            fuenteChica = Font.createFont(Font.TRUETYPE_FONT, new File("HurleySans.ttf")).deriveFont(50 * H_SCALE);
        } catch (Exception e) {
            System.out.println(e.getMessage());
            fuenteChica = new Font("", Font.BOLD, (int) (50 * H_SCALE));
        }
        fuenteGrande = new Font("", Font.BOLD, (int) (52 * H_SCALE));
        Color colorLetras = new Color(39, 43, 98);

        // Contorno artificial de las letras
        g.setColor(Color.WHITE);
        g.fillRect((int) (360 * W_SCALE), (int) (288 * H_SCALE), (int) (350 * W_SCALE), (int) (40 * H_SCALE));
        g.setFont(fuenteGrande);

        for (int i = 0; i < 14; i++) {
            for (int j = 0; j < 14; j++) {
                g.drawString("S", (int) ((360 - i) * W_SCALE), (int) ((321 + j) * H_SCALE));
                g.drawString("U", (int) ((392 - i) * W_SCALE), (int) ((321 + j) * H_SCALE));
                g.drawString("P", (int) ((425 - i) * W_SCALE), (int) ((321 + j) * H_SCALE));
                g.drawString("E", (int) ((459 - i) * W_SCALE), (int) ((321 + j) * H_SCALE));
                g.drawString("R", (int) ((490 - i) * W_SCALE), (int) ((321 + j) * H_SCALE));
                g.drawString("M", (int) ((524 - i) * W_SCALE), (int) ((321 + j) * H_SCALE));
                g.drawString("A", (int) ((566 - i) * W_SCALE), (int) ((321 + j) * H_SCALE));
                g.drawString("R", (int) ((601 - i) * W_SCALE), (int) ((321 + j) * H_SCALE));
                g.drawString("K", (int) ((634 - i) * W_SCALE), (int) ((321 + j) * H_SCALE));
                g.drawString("E", (int) ((669 - i) * W_SCALE), (int) ((321 + j) * H_SCALE));
                g.drawString("T", (int) ((700 - i) * W_SCALE), (int) ((321 + j) * H_SCALE));
            }
        }

        // Letras del supermercado
        g.setColor(colorLetras);
        g.setFont(fuenteChica);
        g.drawString("S", (int) ((355) * W_SCALE), (int) (325 * H_SCALE));
        g.drawString("U", (int) ((387) * W_SCALE), (int) (325 * H_SCALE));
        g.drawString("P", (int) ((421) * W_SCALE), (int) (325 * H_SCALE));
        g.drawString("E", (int) ((454) * W_SCALE), (int) (325 * H_SCALE));
        g.drawString("R", (int) ((485) * W_SCALE), (int) (325 * H_SCALE));
        g.drawString("M", (int) ((519) * W_SCALE), (int) (325 * H_SCALE));
        g.drawString("A", (int) ((558) * W_SCALE), (int) (325 * H_SCALE));
        g.drawString("R", (int) ((596) * W_SCALE), (int) (325 * H_SCALE));
        g.drawString("K", (int) ((629) * W_SCALE), (int) (325 * H_SCALE));
        g.drawString("E", (int) ((664) * W_SCALE), (int) (325 * H_SCALE));
        g.drawString("T", (int) ((695) * W_SCALE), (int) (325 * H_SCALE));
    }
}
