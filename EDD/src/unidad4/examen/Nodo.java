package unidad4.examen;

public class Nodo {

    public Nodo nodoSiguiente;
    public int clave;
    public String nombre;
    public int edad;
    public char genero; //Se agreg� para el ejercicio de diferenciar hombres de mujeres
    public String telefono;
    public String domicilio;

    public Nodo(int clave) {
        this.nodoSiguiente = null;
        this.clave = clave;
    }

    public Nodo(int clave, String nombre, int edad, char genero, String telefono, String domicilio) {
        this.nodoSiguiente = null;
        this.clave = clave;
        this.nombre = nombre;
        this.edad = edad;
        this.genero = genero;
        this.telefono = telefono;
        this.domicilio = domicilio;
    }

	@Override
    public String toString() {
        return "Nodo{" +
                "clave=" + clave +
                ", nombre='" + nombre + '\'' +
                ", edad=" + edad +
                ", g�nero=" + genero +
                ", telefono='" + telefono + '\'' +
                ", domicilio='" + domicilio + '\'' +
                '}';
    }
}
