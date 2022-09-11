package unidad3.hilos.cajera;

import java.util.Random;

public class Productos {
    private Integer nombre;
    private Integer valor;

    public Productos(Integer nombre) {
        this.nombre = nombre;
        valor = new Random().nextInt(100);
    }

    public Integer getNombre() {
        return nombre;
    }

    public Integer getValor() {
        return valor;
    }
}
