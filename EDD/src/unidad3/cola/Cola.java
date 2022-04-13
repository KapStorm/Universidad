package unidad3.cola;

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

public class Cola <T> {
	public T[] cola;
	private int inicio;
	private int fin;
	private T memoria;
	private int maxSize;
	
	public Cola(int size) {
		cola = (T[]) new Object[size];
		maxSize = size;
		inicio = -1;
		fin = -1;
	}
	public boolean colaLlena() {
		if ((inicio == 0 && fin == maxSize-1) || (fin == inicio-1))
			return true;
		return false;
	}
	public boolean colaVacia() {
		if (inicio == -1 && fin == -1)
			return true;
		return false;
	}
	public boolean insertar(T dato) {
		if (!colaLlena()) {
			if ( fin == maxSize-1 && inicio !=0 ) {
				fin = 0;
				cola[fin] = dato;
			} else {
				fin++;
				cola[fin] = dato;
				if (inicio == -1)
					inicio = 0;
			}
			System.out.println("> A�adiendo a la cola: " + dato);
			mostrarCola();
			return true;
		} System.out.println("No se pudo a�adir el dato: Cola llena");
		return false;
	}
	public boolean retirar() {
		if (!colaVacia()) {
			memoria = cola[inicio];
			System.out.println("> Retirando de la cola: " + memoria);
			if (!colaVacia()) {
				if (inicio == fin) {
					inicio = -1;
					fin = -1;
				}
				else if (inicio == maxSize-1 && fin<inicio) {
					inicio = 0;
				}
				else {
					inicio++;
				}
				mostrarCola();
				return true;
			} System.out.println("No se pudo retirar el dato: Cola vac�a");
		}return false;
	}
	public T mostrarFrente() {
		if (!colaVacia())
			return cola[inicio];
		System.out.println("No se pudo desplegar el valor al final de la cola: Cola vac�a");
		return null;
	}
	public void mostrarCola() {
		if (!colaVacia()) {
			if (inicio == fin)
				System.out.println(" | " + cola[inicio] + " | ");
			if (inicio < fin) {
				for (int i = inicio; i <= fin; i++) {
					System.out.print(" | "+cola[i] + " | " );
				}
			}
			if (fin < inicio) {
				for (int i = inicio; i < maxSize; i++) 
					System.out.print(" | "+cola[i]+" | ");
				
				for (int i = 0; i <=fin; i++) {
					System.out.print(" | "+cola[i]+" | ");
				}
				
			}
			System.out.println();
		} else
			System.out.println("No se pudo desplegar la cola: Cola vac�a");
	}
}