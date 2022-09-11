package unidad3.hilos.cajera;

import java.util.List;

public class Clientes {
    private String nombre;
    private List<Productos> productos;

    public Clientes(String nombre, List<Productos> productos) {
        this.nombre = nombre;
        this.productos = productos;
    }

    public String getNombre() {
        return nombre;
    }

    public List<Productos> getProductos() {
        return productos;
    }
}
