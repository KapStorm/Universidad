package unidad4.examen;

public class ListaOrdenada {

    Nodo inicio;
    Nodo fin;

    public ListaOrdenada() {
        this.inicio = this.fin = null;
    }

    public boolean estaVacia() {
        return this.inicio == null;
    }

    public Nodo buscar(int clave) {
        if (estaVacia()) {
            return null;
        }

        Nodo auxiliar = this.inicio;

        do {
            if (auxiliar.clave == clave) {
                return auxiliar;
            }
            auxiliar = auxiliar.nodoSiguiente;
        } while (auxiliar != inicio);

        return null;
    }

    public void insertar(Nodo insertar) {
        if (estaVacia()) {
            insertar.nodoSiguiente = insertar;
            this.inicio = this.fin = insertar;
            return;
        }

        if (buscar(insertar.clave) != null) {
            return;
        }

        if (this.inicio.clave > insertar.clave) {
            this.fin.nodoSiguiente = insertar;
            insertar.nodoSiguiente = this.inicio;
            this.inicio = insertar;
            return;
        }

        if (this.fin.clave < insertar.clave) {
            this.fin.nodoSiguiente = insertar;
            insertar.nodoSiguiente = this.inicio;
            this.fin = insertar;
            return;
        }

        Nodo auxiliar = this.inicio;
        while (true) {
            if (auxiliar.nodoSiguiente.clave > insertar.clave) {
                insertar.nodoSiguiente = auxiliar.nodoSiguiente;
                auxiliar.nodoSiguiente = insertar;
                return;
            }
            auxiliar = auxiliar.nodoSiguiente;
        }
    }

    public Nodo retirar() {
        if (estaVacia()) return null;

        return retirar(this.inicio.clave);
    }

    public Nodo retirar(int clave) {
        if (buscar(clave) == null) {
            return null;
        }

        if (this.inicio == this.fin) {
            Nodo auxiliar = new Nodo(this.inicio.clave, this.inicio.nombre, this.inicio.edad, this.inicio.genero, this.inicio.telefono, this.inicio.domicilio);
            this.inicio.nodoSiguiente = null;
            this.inicio = this.fin = null;

            return auxiliar;
        }

        Nodo auxiliar = this.inicio;

        if (this.inicio.clave == clave) {
            this.inicio = this.inicio.nodoSiguiente;
            this.fin.nodoSiguiente = inicio;
            auxiliar.nodoSiguiente = null;

            return auxiliar;
        }

        while (true) {
            if (auxiliar.nodoSiguiente.clave == clave) {
                Nodo auxiliar2 = auxiliar.nodoSiguiente;
                auxiliar.nodoSiguiente = auxiliar2.nodoSiguiente;

                if (auxiliar2 == this.fin) {
                    this.fin = auxiliar;
                }

                return auxiliar2;
            }
            auxiliar = auxiliar.nodoSiguiente;
        }
    }

    public void imprimir() {
        if (estaVacia()) {
            System.out.println("Lista vacia");
            return;
        }

        Nodo auxiliar = this.inicio;

        do {
            System.out.println(auxiliar);
            auxiliar = auxiliar.nodoSiguiente;
        } while (auxiliar != this.inicio);
    }
}
