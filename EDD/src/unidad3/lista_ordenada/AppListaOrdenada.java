package unidad3.lista_ordenada;

public class AppListaOrdenada {

    public static void main(String[] args) {
        ListaOrdenada lista = new ListaOrdenada();
        lista.insertar(new Nodo(1, "Persona1", 20, "6671234567", "Culiacan"));
        lista.insertar(new Nodo(4, "Persona4", 90, "5519423421", "CDMX"));
        lista.insertar(new Nodo(3, "Persona3", 12, "6679382130", "Mazatlan"));
        lista.insertar(new Nodo(2, "Persona2", 40, "6674123424", "Nogales"));
        lista.imprimir();
        System.out.println();

        lista.retirar(4);
        lista.imprimir();
        System.out.println();

        lista.retirar(2);
        lista.imprimir();
        System.out.println();

        lista.retirar(1);
        lista.imprimir();
        System.out.println();

        lista.retirar(3);
        lista.imprimir();
    }
}
