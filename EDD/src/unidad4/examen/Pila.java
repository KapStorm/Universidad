package unidad4.examen;

/**
 *
 * Integrantes:
 * 	- Arellanes Beltrán Sebastián
 * 	- Celis Pérez Carlos Miguel
 * 	- Corrales Macías Emmanuel
 * 	- Laija Guzmán Juan José
 * 	- Moreno Millan Fernando Alonso
 *	- Valdés Manchado Victor Manuel
 *
 */

public class Pila<T> {

    private T [] arr;
    private Integer tope;
    private T memoria;

    public Pila(int size) {
        arr = (T[]) new Object[size];
        tope = -1;
        memoria = null;
    }

    public boolean esVacia() {
        return tope == -1;
    }

    public boolean estaLlena() {
        return tope == arr.length - 1;
    }

    public boolean insertar(T dato) {
        if (!estaLlena()) {
            tope += 1;
            arr[tope] = dato;
//            System.out.println("> Añadiendo a la pila el elemento: " + dato);
//            imprimir();
            return true;
        }
//        System.out.println("> No se puede insertar el elemento " + dato + ", pila llena");
        return false;
    }

    public T retirar() {
        if (!esVacia()) {
            memoria = arr[tope];
            arr[tope] = null;
            tope -= 1;
//            System.out.println("> Retirando de la pila el elemento: " + memoria);
//            imprimir();
            return memoria;
        }
//        System.out.println("> No se puede retirar, pila vacía");
        return null;
    }

    public T mostrarFrente() {
        return arr[tope];
    }

    public void imprimir() {
        System.out.println(this);
    }

    public Integer tamanio() {
        return arr.length;
    }

    @Override
    public String toString() {
        String str = "[";
        for (int i = 0; i < arr.length; i++) {
            if (i == arr.length - 1) str += arr[i];
            else str += arr[i] + ", ";
        }
        str += "]";
        return str;
    }

}
