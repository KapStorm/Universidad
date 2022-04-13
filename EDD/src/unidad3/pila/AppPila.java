package unidad3.pila;

public class AppPila {

    public static void main(String[] args) {
        Pila<Integer> pila = new Pila<>(5);
        pila.insertar(3);
        pila.insertar(54534);
//        pila.insertar(54534);
//        pila.insertar(54534);
        pila.insertar(54534);
        pila.insertar(4444);
        pila.imprimir();
        System.out.println(pila.mostrarFrente());
        pila.insertar(33333);
        pila.insertar(33333);
        System.out.println(pila.mostrarFrente());
        pila.imprimir();
        pila.retirar();
        pila.retirar();
        pila.retirar();
        pila.retirar();
        pila.retirar();
        pila.retirar();
    }

}
