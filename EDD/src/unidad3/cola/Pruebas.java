package unidad3.cola;

public class Pruebas {
	public static void main(String[] args) {
		Cola cola = new Cola(5);
		cola.insertar(4);
		cola.insertar(3);
		cola.insertar(2);
		cola.insertar(1);
		cola.insertar(0);
		cola.insertar(-1);
		System.out.println("Valor en el frente de la cola: "+cola.mostrarFrente());

		System.out.println();
		cola.retirar();
		cola.retirar();
		cola.retirar();

		System.out.println();
		
		cola.insertar(10);
		cola.insertar(9);
		System.out.println();
		
		cola.retirar();
		System.out.println();
		
		cola.retirar();
		cola.retirar();
		cola.retirar();
		cola.retirar();
		cola.retirar();
		cola.retirar();
		cola.retirar();
		System.out.println("Valor en el frente de la cola: "+cola.mostrarFrente());
		System.out.println();
		
		cola.retirar();
		cola.retirar();
		cola.retirar();
		cola.retirar();
		cola.retirar();

	}
}
