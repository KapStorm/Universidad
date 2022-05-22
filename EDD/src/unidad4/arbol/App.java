package unidad4.arbol;

public class App {
	
	public static void main(String[] args) {
		Arbol arbol = new Arbol();
		
		arbol.insertarABB(10);
		arbol.insertarABB(1);
		arbol.insertarABB(9);
		arbol.insertarABB(7);
		arbol.insertarABB(13);
		arbol.insertarABB(6);
		arbol.insertarABB(-5);
		arbol.insertarABB(-1);
		arbol.insertarABB(-6);
		arbol.insertarABB(4);
		arbol.insertarABB(5);
		arbol.insertarABB(12);
		arbol.insertarABB(14);

//		System.out.println(arbol.obtenerNivel(6));
//		arbol.obtenerNombres();
		arbol.inorden();
		System.out.println("================");
		arbol.eliminar(1);
		arbol.eliminar(4);
		arbol.eliminar(13);
		arbol.eliminar(-5);
		arbol.eliminar(7);
		arbol.inorden();
		System.out.println("==============");
		arbol.insertarABB(999);
		arbol.inorden();
		System.out.println("==============");
		arbol.eliminar(10);
		arbol.inorden();
	}
}
