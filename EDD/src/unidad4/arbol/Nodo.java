package unidad4.arbol;

public class Nodo {
	
	public int clave;
	public Nodo nodoIzq;
	public Nodo nodoDer;
	
	public Nodo(int clave) {
		this.clave = clave;
		nodoIzq = null;
		nodoDer = null;
	}
}
