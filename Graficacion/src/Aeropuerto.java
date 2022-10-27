import java.awt.BasicStroke;
import java.awt.Color;
import java.awt.GradientPaint;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.geom.CubicCurve2D;
import java.util.Iterator;
import javax.swing.JFrame;


    public class Aeropuerto extends JFrame{
	
	
    public Aeropuerto(){
       super("Aeropuerto - Graficacion - Murguia Quintero Maria Alexandra");
       setSize(1200, 700);
       setVisible(true);
   }
    
    public void paint(Graphics g){
       super.paint(g);
       
       Graphics2D g2 = (Graphics2D) g;
       g.setColor(new Color(130,187,217));
       g.fillRect(0, 0, 1200, 700);
       
       
       // Nubes
       g.setColor(new Color(171,216,239));    
       g.fillOval(270, 280, 130, 120);
       g.fillOval(180, 310, 130, 120);
       g.fillOval(350, 175, 220, 180);
       g.fillOval(500, 170, 120, 120);
       g.fillOval(550, 120, 240, 180);
       g.fillOval(730, 180, 150, 180);
       g.fillOval(855, 175, 170, 170);
       g.fillOval(1070, 210, 190, 170);
       g.fillOval(0, 210, 210, 170);
       g.fillRect(0, 270, 200, 500);
       
       g.fillRoundRect(180, 208, 45, 12, 25, 50);
       g.fillRoundRect(188, 202, 15, 12, 25, 50);
       g.fillRoundRect(198, 200, 15, 12, 25, 50);
        
       g.fillRoundRect(38, 80, 85, 15, 25, 50);
       g.fillOval(50, 65, 30, 30);
       g.fillOval(65, 60, 40, 30);
       g.fillOval(90, 73, 20, 15);
       
       g.fillRoundRect(488, 95, 85, 15, 25, 50);
       g.fillOval(500, 80, 30, 30);
       g.fillOval(515, 75, 40, 30);
       g.fillOval(540, 88, 20, 15);
       
       g.fillRoundRect(1013, 175, 85, 15, 25, 50);
       g.fillOval(1025, 160, 30, 30);
       g.fillOval(1040, 155, 40, 30);
       g.fillOval(1065, 168, 20, 15);
          
       g.fillRoundRect(970, 88, 45, 12, 25, 50);
       g.fillRoundRect(978, 82, 15, 12, 25, 50);
       g.fillRoundRect(988, 80, 15, 12, 25, 50);
       
       g.setColor(new Color(204,232,244));    
       g.fillOval(570, 200, 222, 120);
       
       g.fillOval(880, 253, 220, 160); 
       
       g.fillOval(0, 315, 220, 160); 
       g.fillRect(0, 380, 78, 126);
       
       g.fillOval(1050, 315, 180, 140); 
       g.fillRect(1100, 380, 180, 126);
       
       g.fillOval(360, 275, 140, 200);
       g.fillOval(725, 270, 130, 180);
       
       
       //Creacion del Edificio
       g.setColor(new Color (255, 255, 255));
       g.fillRect(77, 372, 1050, 132);
       g.fillRect(66, 355, 1073, 17);
       g.fillRect(87, 261, 169, 95);
       g.fillRect(82, 247, 179, 14);
       g.fillRect(948, 261, 170, 96);
       g.fillRect(943, 247, 180, 14);
       g.fillRect(410, 264, 384, 93);
       g.fillRect(834, 291, 53, 65);  
       g.fillRect(828, 284, 64, 7);
       g.fillRect(816, 253, 91, 31);
       g.fillRect(834,232,54,21);
       g.fillRect(831, 229, 60, 4);
       g.fillRect(838, 194, 46, 36);
       g.fillRect(831, 190, 60, 4);
       g.fillRect(854, 169, 14, 14);
    
       BasicStroke grosor1 = new BasicStroke(4);
    	   g2.setStroke(grosor1);
           g.setColor(new Color(255, 255, 255));
           g.drawLine(861, 144, 861, 174);  
      
           
       g.setColor(new Color(255, 255, 255));
       int[] x5={840, 847, 874, 881, 889};
       int[] y5={191, 183, 183, 191};
       g.fillPolygon(x5, y5, 4);
       
     
       
       // Ventana Circular
       g.setColor(new Color (58,91,180));
       g.fillOval(435, 363, 330, 330); 
       
       int lx1=479;
       BasicStroke grosor = new BasicStroke(4);
       for (int i=0; i<7; i++) {
    	   g2.setStroke(grosor);
           g.setColor(new Color(255, 255, 255));
           g.drawLine(lx1, 360, lx1, 502);  
           lx1+=40;
       }
       
       //reflejo
       g.setColor(new Color(255, 255, 255, 30));
       int[] rx1={461, 574, 723, 707, 688, 676};
       int[] ry1={504, 504, 417, 401, 387, 380};
       g.fillPolygon(rx1, ry1, 6);
    
       
       BasicStroke grosor2 = new BasicStroke(0);
       g2.setStroke(grosor2);
       
       
       
       //Carretera
       g.setColor(new Color (194, 194, 194));
       g.fillRect(0, 522, 1200, 178);
       
       
       //Lineas de Carretera Blancas
       int l1= 0;
       for (int i=0; i<6; i++) {
    	   g.setColor(new Color (255, 255, 255));
    	   g.fillRect(l1, 558, 180, 17);
    	   l1+=210;
       }
       
       
       //Lineas de Carretera Negras
       g.setColor(new Color(66,66,66));
       g.fillRect(0, 504, 1199, 17);
       
      //Sombra Taxi
       g.setColor(new Color(66,66,66,35));
       g.fillOval(700, 538, 190, 10);
       
       
       //Ventanas del edificio superior izquierdo.
       int v1= 98;
       for (int i=0; i<7; i++) {
    	   g.setColor(new Color (58,91,180));
    	   g.fillRect(v1, 268, 15, 80);
    	   v1+=22;
       }   
       
       //Ventanas del edificio superior derecho.
       int v2= 959;
       for (int i=0; i<7; i++) {
        	g.setColor(new Color (58,91,180));
        	g.fillRect(v2, 268, 15, 80 );
        	v2+=22;
       }
       
       //Ventanas del edificio superior central.
       int v3= 438;
       for (int i=0; i<6; i++) {
        	g.setColor(new Color (58,91,180));
        	g.fillRect(v3, 280, 42, 74 );
        	v3+=57;
       }
       
       //Ventanas del edificio superiores de la torre.
       int v4= 843;
       for (int i=0; i<2; i++) {
        	g.setColor(new Color (58,91,180));
        	g.fillRect(v4, 195, 15, 33 );
        	v4+=20;
       }
       //Ventanas del edificio centrales de la torre.
       int v5= 820;
       for (int i=0; i<4; i++) {
        	g.setColor(new Color (58,91,180));
        	g.fillRect(v5, 256, 16, 23 );
        	v5+=22;
       }
       //Ventanas del edificio inferior izquierdo.
       int v6= 94;
       for (int i=0; i<5; i++) {
        	g.setColor(new Color (58,91,180));
        	g.fillRect(v6, 388, 36, 29 );
        	v6+=50;
       }
       int v7= 94;
       for (int i=0; i<5; i++) {
        	g.setColor(new Color (58,91,180));
        	g.fillRect(v7, 424, 36, 29 );
        	v7+=50;
       }
       int v8= 94;
       for (int i=0; i<5; i++) {
        	g.setColor(new Color (58,91,180));
        	g.fillRect(v8, 460, 36, 30 );
        	v8+=50;
       }
       //Ventanas del edificio inferior derecho.
       int v9= 863;
       for (int i=0; i<5; i++) {
        	g.setColor(new Color (58,91,180));
        	g.fillRect(v9, 389, 36, 30 );
        	v9+=50;
       }
       int v10= 863;
       for (int i=0; i<5; i++) {
        	g.setColor(new Color (58,91,180));
        	g.fillRect(v10, 424, 36, 29 );
        	v10+=50;
       }
       int v11= 863;
       for (int i=0; i<5; i++) {
        	g.setColor(new Color (58,91,180));
        	g.fillRect(v11, 460, 36, 29  );
        	v11+=50;
       }
       
       
       
       //Creacion del Avion.
       g.setColor(new Color(255, 255, 255));
       int[] x1={212, 217, 232, 268, 299, 328, 355, 337, 404, 440, 459, 454, 461, 452, 462, 452, 423, 245, 234, 217};
       int[] y1={125, 130, 136, 143, 146, 172, 176, 150, 153, 151, 155, 148, 142, 137, 112, 112, 132, 110, 112, 119};
       g.fillPolygon(x1, y1, 20);
       
       g.setColor(new Color(41,67,177));
       int[] x2={308, 335, 351, 340};
       int[] y2={118, 112, 115, 122};
       g.fillPolygon(x2, y2, 4);
       
       g.setColor(new Color(41,67, 177));
       int[] x3={212, 217, 232, 268, 299, 328, 355, 337, 404, 440, 448, 454, 459, 459, 455, 461, 450, 440, 421, 403, 403, 401, 398, 395, 393, 393, 384, 355, 329, 309, 273, 274, 272, 268, 265, 264, 263, 239, 231, 217 };
       int[] y3={125, 130, 136, 143, 146, 172, 176, 150, 153, 151, 153, 155, 157, 155, 148, 142, 144, 146, 147, 147, 139, 137, 136, 137, 139, 147, 147, 145, 142, 140, 135, 124, 121, 121, 122, 123, 133, 129, 127, 119 };
       g.fillPolygon(x3, y3, 40);
       
       g.setColor(new Color(41,67,177));
       int[] x4={423, 452, 462, 452};
       int[] y4={132, 112, 112, 138};
       g.fillPolygon(x4, y4, 4);
       
       int vx4 = 283, vy4 = 122;
       for(int i = 0; i<8; i++) {
    	   g.setColor(new Color(186,208,215));
    	   g.fillRect(vx4, vy4, 7, 5);
    	   vx4 += 13;
    	   vy4 += 2;
       }
       
       int[] vx5={219, 234, 234};
       int[] vy5={118, 118, 112};
       g.fillPolygon(vx5, vy5, 3);
       
       int vx6 = 240, vy6 = 115;
       for(int i = 0; i<2; i++) {
    	   g.setColor(new Color(186,208,215));
    	   g.fillRect(vx6, vy6, 6, 5);
    	   vx6 += 13;
    	   vy6 += 2;
       }
       
       //Creacion del Taxi.
       g.setColor(new Color(66,66,66));
       int[] x6={700, 700, 701, 886, 887, 888, 888};
       int[] y6={521, 528, 529, 529, 528, 527, 521}; 
       g.fillPolygon(x6, y6, 7);
       
       g.setColor(new Color(249,196,22));
       int[] x7={700, 700, 702, 705, 713, 725, 809, 816, 824, 831, 845, 869, 884, 888, 888, 700};
       int[] y7={521, 497, 494, 493, 493, 472, 472, 475, 482, 491, 493, 501, 510, 514, 520, 521};
       g.fillPolygon(x7, y7, 16);
       
       g.setColor(new Color(173,116,111));
       int[] x8={740, 746, 788, 793};
       int[] y8={473, 459, 459, 473}; 
       g.fillPolygon(x8, y8, 4);
       
       g.setColor(new Color(66, 66, 66));
       int[] x9={728, 736, 767, 767};
       int[] y9={493, 477, 477, 493}; 
       g.fillPolygon(x9, y9, 4);
       
       g.setColor(new Color(66, 66, 66));
       int[] x10={772, 772, 818, 803};
       int[] y10={477, 493, 493, 477}; 
       g.fillPolygon(x10, y10, 4);
       
       g.setColor(new Color(66, 66, 66));
       int[] x11={805, 813, 813, 805};
       int[] y11={497, 497, 499, 499}; 
       g.fillPolygon(x11, y11, 4);
    
       g.setColor(new Color(66, 66, 66));
       int[] x12={750, 757, 757, 750};
       int[] y12={497, 497, 499, 499}; 
       g.fillPolygon(x12, y12, 4);
       
       int v12= 718;
       for (int i=0; i<20; i++) {
        	g.setColor(new Color (66, 66, 66));
        	g.fillRect(v12, 502, 3, 3);
        	v12+=6;
       }
       int v13= 721;
       for (int i=0; i<20; i++) {
        	g.setColor(new Color (66, 66, 66));
        	g.fillRect(v13, 505, 3, 3);
        	v13+=6;
       }
       g.setColor(new Color (253,210,116));
       g.fillOval(869, 508, 10, 10); 
       g.setColor(new Color (174,120,43));
       g.fillOval(871, 510, 6, 6);
  
        	

       //LLantas del Taxi
       g.setColor(new Color (66, 66, 66));
       g.fillOval(720, 513, 25, 25);
       g.setColor(new Color (255,255,255));
       g.fillOval(724, 517, 17, 17);
       g.setColor(new Color (66, 66, 66));
       g.fillOval(727, 521, 10, 10);
       
       g.setColor(new Color (66, 66, 66));
       g.fillOval(821, 513, 25, 25);
       g.setColor(new Color (255,255,255));
       g.fillOval(825, 517, 17, 17);
       g.setColor(new Color (66, 66, 66));
       g.fillOval(828, 521, 10, 10);
       
       //Arbol 1 
       g.setColor(new Color (94,129,54));
       g.fillOval(27, 394, 20, 20);
       g.fillOval(17, 404, 20, 20);//-10x +10y
       g.fillOval(37, 404, 20, 20);//+20x
       g.fillOval(47, 414, 20, 20);//+20x +10y
       g.fillOval(7, 414, 20, 20);//-30x +10y
       g.fillOval(20, 414, 30, 30);//el de en medio
       g.fillOval(5, 419, 20, 20);
       g.fillOval(40, 419, 20, 20);
       
       //parte derecha
       g.setColor(new Color (127,171,78));
       g.fillOval(50,426,12,12);
       g.fillOval(42,430,12,12);
       g.fillOval(35,438,12,12);
       g.fillOval(53,430,12,12);
       g.fillOval(58,438,12,12);
       g.fillOval(45,435,15,15);
       
       //parte izquierda
       g.fillOval(20,416,12,12);
       g.fillOval(12,420,12,12);
       g.fillOval(5,428,12,12);
       g.fillOval(23,420,12,12);
       g.fillOval(8,428,12,12);
       g.fillOval(15,425,15,15);
       g.fillOval(5,430,15,15);
       g.fillOval(15,431,15,15);
       g.fillOval(17,425,12,12);


       //tronco
       g.setColor(new Color (63,52,52));
       int[] Arb1X={32,  32, 14, 14, 20,20, 32,  32, 36, 36, 49, 49, 54, 54, 36, 36};
       int[] Arb1Y={494,452,452,440,440,449,449, 435,435,454,454,449,449,459,459,494};
       g.fillPolygon(Arb1X,Arb1Y,16);
       g.setColor(new Color (127,171,78));
       g.fillOval(25,428,12,12);

       //Arbol 2
       g.setColor(new Color (94,129,54));
       g.fillOval(167, 394, 20, 20);
       g.fillOval(157, 404, 20, 20);//-10x +10y
       g.fillOval(177, 404, 20, 20);//+20x
       g.fillOval(187, 414, 20, 20);//+20x +10y
       g.fillOval(147, 414, 20, 20);//-30x +10y
       g.fillOval(160, 414, 30, 30);//el de en medio
       g.fillOval(145, 419, 20, 20);
       g.fillOval(180, 419, 20, 20);
       
       //parte derecha
       g.setColor(new Color (127,171,78));
       g.fillOval(190,426,12,12);
       g.fillOval(182,430,12,12);
       g.fillOval(175,438,12,12);
       g.fillOval(191,430,12,12);
       g.fillOval(198,438,12,12);
       g.fillOval(185,435,15,15);
       
       //parte izquierda
       g.fillOval(160,416,12,12);
       g.fillOval(152,420,12,12);
       g.fillOval(145,428,12,12);
       g.fillOval(163,420,12,12);
       g.fillOval(148,428,12,12);
       g.fillOval(155,425,15,15);
       g.fillOval(145,430,15,15);
       g.fillOval(155,431,15,15);
       g.fillOval(157,425,12,12);
       g.fillOval(152,440,13,13);

       //tronco
       g.setColor(new Color (63,52,52));
       Arb1X=new int[]{172,172,156,156,160,160,172,172,177,177,189,189,194,194,177,177};
       Arb1Y=new int[]{493,455,455,449,449,452,452,438,438,446,446,442,442,449,449,493};
       g.fillPolygon(Arb1X,Arb1Y,16);
       g.setColor(new Color (127,171,78));
       g.fillOval(165,428,12,12);


       //Arbol 3
       g.setColor(new Color (94,129,54));
       g.fillOval(1011, 394, 20, 20);
       g.fillOval(1001, 404, 20, 20);//-10x +10y
       g.fillOval(1021, 404, 20, 20);//+20x
       g.fillOval(1031, 414, 20, 20);//+20x +10y
       g.fillOval(991, 414, 20, 20);//-30x +10y
       g.fillOval(1004, 414, 30, 30);//el de en medio
       g.fillOval(989, 419, 20, 20);
       g.fillOval(1024, 419, 20, 20);
       
       //parte derecha
       g.setColor(new Color (127,171,78));
       g.fillOval(1034,426,12,12);
       g.fillOval(1026,430,12,12);
       g.fillOval(1019,438,12,12);
       g.fillOval(1037,430,12,12);
       g.fillOval(1042,438,12,12);
       g.fillOval(1029,435,15,15);
       
       //parte izquierda
       g.fillOval(1004,416,12,12);
       g.fillOval(996,420,12,12);
       g.fillOval(989,428,12,12);
       g.fillOval(1007,420,12,12);
       g.fillOval(992,428,12,12);
       g.fillOval(999,425,15,15);
       g.fillOval(989,430,15,15);
       g.fillOval(999,431,15,15);
       g.fillOval(1001,425,12,12);

       //tronco
       g.setColor(new Color (63,52,52));
       Arb1X=new int[]{1016,  1016, 998, 998, 1004,1004, 1016,  1016, 1020, 1020, 1033, 1033, 1038, 1038, 1020, 1020};
       Arb1Y=new int[]{494,452,452,440,440,449,449, 435,435,454,454,449,449,459,459,494};
       g.fillPolygon(Arb1X,Arb1Y,16);
       g.setColor(new Color (127,171,78));
       g.fillOval(1009,428,12,12);

       
       //Arbol 4
       g.setColor(new Color (94,129,54));
       g.fillOval(1151, 394, 20, 20);
       g.fillOval(1141, 404, 20, 20);//-10x +10y
       g.fillOval(1161, 404, 20, 20);//+20x
       g.fillOval(1171, 414, 20, 20);//+20x +10y
       g.fillOval(1131, 414, 20, 20);//-30x +10y
       g.fillOval(1144, 414, 30, 30);//el de en medio
       g.fillOval(1129, 419, 20, 20);
       g.fillOval(1164, 419, 20, 20);
       
       //parte derecha
       g.setColor(new Color (127,171,78));
       g.fillOval(1174,426,12,12);
       g.fillOval(1166,430,12,12);
       g.fillOval(1159,438,12,12);
       g.fillOval(1177,430,12,12);
       g.fillOval(1182,438,12,12);
       g.fillOval(1169,435,15,15);
       
       //parte izquierda
       g.fillOval(1144,416,12,12);
       g.fillOval(1136,420,12,12);
       g.fillOval(1129,428,12,12);
       g.fillOval(1147,420,12,12);
       g.fillOval(1132,428,12,12);
       g.fillOval(1139,425,15,15);
       g.fillOval(1129,430,15,15);
       g.fillOval(1139,431,15,15);
       g.fillOval(1001,425,12,12);
       g.fillOval(1140,438,13,13);


       //tronco
       g.setColor(new Color (63,52,52));
       Arb1X=new int[]{1160,1160,1144,1144,1148,1148,1161,1161,1165,1165,1177,1177,1182,1182,1165,1165};
       Arb1Y=new int[]{493,455,455,449,449,452,452,438,438,446,446,442,442,449,449,493};
       g.fillPolygon(Arb1X,Arb1Y,16);
       g.setColor(new Color (127,171,78));
       g.fillOval(1153,428,12,12);
       
       //Arbustos Izquierdos Oscuros.
       g.setColor(new Color (94,130,58));
       g.fillOval(405, 622, 55, 50);
       g.fillOval(336, 599, 80 , 60);
       g.fillOval(322, 616, 50, 40);
       g.fillOval(295, 629, 23, 23);
       g.fillOval(215, 595, 92, 75);
       g.fillOval(160, 612, 95, 80);
       g.fillOval(144, 615, 30, 30);
       g.fillOval(80, 599, 80, 60);
       g.fillOval(59, 622, 50, 40);
       g.fillOval(10, 607, 59, 43);
       g.fillOval(-40, 598, 70, 70);
       
       //Arbustos Izquierdos Claros.  
       g.setColor(new Color (155, 186, 64));
       g.fillOval(430, 638, 33, 30);
       g.fillOval(378, 627, 57, 40);
       g.fillOval(343, 617, 52, 44);
    
       g.setColor(new Color(184,205,97));
       g.fillOval(17, 642, 20, 20);
       g.fillOval(31, 631, 40, 50);
       g.fillOval(17, 642, 20, 20);
       g.fillOval(55, 640, 28, 32);
       g.fillOval(67, 626, 60, 60);
       g.fillOval(120, 637, 30, 30);
       g.fillOval(140, 648, 10, 10);
       
       g.setColor(new Color (155, 186, 64));
       g.fillOval(145, 639, 40, 40);
       g.fillOval(160, 625, 55, 65);
       g.fillOval(200, 650, 30, 30);
       g.fillOval(205, 625, 47, 36);
       g.fillOval(3, 632, 30, 30);
       g.fillOval(5, 650, 10, 5);
       
       g.setColor(new Color(184,205,97));
       g.fillOval(320, 635, 40, 33);
       g.fillOval(290, 620, 50, 45);
       g.fillOval(278, 640, 22, 20);
       g.fillOval(237, 620, 50, 50);
       
     //Arbustos Derechos Oscuros. 335
       g.setColor(new Color (94,130,58));
       g.fillOval(740, 622, 55, 50);
       g.fillOval(773, 599, 80 , 60);
       g.fillOval(848, 616, 50, 40);
       g.fillOval(869, 629, 23, 23);
       g.fillOval(878, 595, 92, 75);
       g.fillOval(946, 612, 95, 80);
       g.fillOval(905, 615, 30, 30);
       g.fillOval(1009, 599, 80, 60);
       g.fillOval(1085, 622, 50, 40);
       g.fillOval(1119, 607, 59, 43);
       g.fillOval(1170, 598, 70, 70);
       
       
       //Arbustos Derechos Claros.  
       g.setColor(new Color (155, 186, 64));
       g.fillOval(734, 638, 33, 30);
       g.fillOval(758, 627, 57, 40);
       g.fillOval(799, 617, 52, 44);
    
       g.setColor(new Color(184,205,97));
       g.fillOval(835, 642, 45, 40);
       g.fillOval(859, 631, 50, 50);
       g.fillOval(890, 642, 30, 30);
       g.fillOval(897, 640, 38, 32);
       g.fillOval(910, 626, 70, 70);
       g.fillOval(950, 637, 40, 40);
       g.fillOval(970, 648, 20, 20);
       
       g.setColor(new Color (155, 186, 64));
       g.fillOval(970, 639, 40, 40);
       g.fillOval(985, 625, 55, 65);
       g.fillOval(1013, 650, 30, 30);
       g.fillOval(1020, 625, 47, 36);
       g.fillOval(1167, 632, 30, 30);
       g.fillOval(1109, 650, 10, 5);
       
       g.setColor(new Color(184,205,97));
       g.fillOval(1128, 635, 45, 35);
       g.fillOval(1104, 620, 45, 45);
       g.fillOval(1090, 640, 28, 20);
       g.fillOval(1050, 620, 50, 50);
       
       
       
       // MACETEROS
       g.setColor(new Color(66,66,66));
       int[] MX1={427, 439, 447, 454, 457, 457, 0, 0};
       int[] MY1={700, 695, 689, 683, 675, 658, 658, 700}; 
       g.fillPolygon(MX1, MY1, 8);
       
       g.setColor(new Color(66,66,66));
       int[] MX2={774, 763, 753, 747, 743, 743, 1200, 1200};
       int[] MY2={700, 695, 689, 683, 675, 658, 658, 700}; 
       g.fillPolygon(MX2, MY2, 8);
    }
    
    
       

   public static void main(String[] args) {
	   Aeropuerto application = new Aeropuerto();
      application.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
   }

}