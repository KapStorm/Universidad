package unidad3.lista_ordenada;

public class Nodo {

    public Nodo nodoSiguiente;
    public int clave;
    public String nombre;
    public int edad;
    public String telefono;
    public String domicilio;

    public Nodo(int clave) {
        this.nodoSiguiente = null;
        this.clave = clave;
    }

    public Nodo(int clave, String nombre, int edad, String telefono, String domicilio) {
        this.nodoSiguiente = null;
        this.clave = clave;
        this.nombre = nombre;
        this.edad = edad;
        this.telefono = telefono;
        this.domicilio = domicilio;
    }

    @Override
    public String toString() {
        return "Nodo{" +
                "clave=" + clave +
                ", nombre='" + nombre + '\'' +
                ", edad=" + edad +
                ", telefono='" + telefono + '\'' +
                ", domicilio='" + domicilio + '\'' +
                '}';
    }
}
