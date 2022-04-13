package unidad3.calculadora;

public class AppCalculadora {

    public static void main(String[] args) {
        Calculadora cal = new Calculadora();
        System.out.println(cal.convertir("51*(64+22)-12/12"));
        System.out.println(cal.convertir("(52+12)*(12/24)"));
        System.out.println(cal.convertir("(52+1*334+3242-4124412*(434-100*321/123))/100000"));
    }

}
