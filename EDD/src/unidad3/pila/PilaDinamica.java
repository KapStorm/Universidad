package unidad3.pila;

import java.util.ArrayList;

public class PilaDinamica <T> {

    private ArrayList<T> arr;

    public PilaDinamica() {
        arr = new ArrayList<>();
    }

    public void insertar(T dato) {
        arr.add(dato);
    }

    public T eliminar() {
        if (!esVacia()) {
            return arr.remove(arr.size() - 1);
        }
        return null;
    }

    public T ver() {
        if (!esVacia()) {
            return arr.get(arr.size() - 1);
        }
        return null;
    }

    public boolean esVacia() {
        return arr.isEmpty();
    }

    public Integer tamanio() {
        return arr.size();
    }

    public void imprimir() {
        System.out.println(this);
    }

    @Override
    public String toString() {
        String str = "[";
        for (int i = 0; i < arr.size(); i++) {
            if (i == arr.size() - 1) str += arr.get(i);
            else str += arr.get(i) + ", ";
        }
        str += "]";
        return str;
    }
}
