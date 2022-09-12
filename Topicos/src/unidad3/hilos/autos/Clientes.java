package unidad3.hilos.autos;

import java.util.List;

public class Clientes {
    private String nombre;
    private String[] autos;

    public Clientes(String nombre, String[] autos) {
        this.nombre = nombre;
        this.autos = autos;
    }

    public String getNombre() {
        return nombre;
    }

    public String[] getAutos() {
        return autos;
    }
}
