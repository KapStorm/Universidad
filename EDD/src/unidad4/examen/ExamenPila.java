package unidad4.examen;

public class ExamenPila {

    public static void main(String[] args) {
        Pila<String> pila;

        pila = inicializar();
        System.out.println("Remplazo");
        remplazar(pila, "Remplazo", "Test");
        pila.imprimir();

        pila = inicializar();
        System.out.println("\nOrdenamiento descendiente");
        pila = ordenamientoDescendiente(pila);
        pila.imprimir();
    }

    public static Pila<String> inicializar() {
        Pila<String> pila = new Pila<>(5);
        pila.insertar("Hola");
        pila.insertar("Test");
        pila.insertar("Kappa");
        pila.insertar("Adios");
        pila.insertar("Examen");
        return pila;
    }

    public static Pila<String> ordenamientoDescendiente(Pila<String> pila) {
        Pila<String> auxiliar = new Pila<>(pila.tamanio());

        while (!pila.esVacia()) {
            String temp = pila.retirar();

            while (!auxiliar.esVacia() && auxiliar.mostrarFrente().charAt(0) > temp.charAt(0)) {
                pila.insertar(auxiliar.retirar());
            }

            auxiliar.insertar(temp);
        }

        return auxiliar;
    }

    public static void remplazar(Pila<String> pila, String remplazo, String objetivo) {
        Pila<String> auxiliar = new Pila<>(pila.tamanio());
        while (!pila.esVacia()) {
            String aux = pila.retirar();

            if (aux.equals(objetivo)) {
                auxiliar.insertar(remplazo);
                break;
            }

            auxiliar.insertar(aux);
        }

        while (!auxiliar.esVacia()) {
            pila.insertar(auxiliar.retirar());
        }

    }

}
