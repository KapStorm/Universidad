package unidad4.examen;
/**
*
* Integrantes:
* 	- Arellanes Beltran Sebastian
* 	- Celis Perez Carlos Miguel
* 	- Corrales Macias Emmanuel
* 	- Laija Guzman Juan Jose
* 	- Moreno Millan Fernando Alonso
*	- Valdes Manchado Victor Manuel
*
*/

public class ExamenCola {

	public static Cola cola;
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		cola = new Cola(5);
		//for(int i = 1; i < 6;i++) 
		//{
			//cola.insertar(i);
		//}
		cola.insertar(6);
		cola.insertar(9);
		cola.insertar(44);
		cola.insertar(22);
		cola.insertar(12);
		Cola aux = new Cola(5);
		
		ExamenCola ec = new ExamenCola();
		ec.impares(cola, aux);
		
		System.out.println("==========Cola sin impares=================");
		aux.mostrarCola();
		cola = aux;
		System.out.println("===========Comprobar cola=====");
		cola.mostrarCola();
		Integer arregloaux[] = new Integer[5];
		System.out.println("===========Ordenados ==================");
		ec.Ordenar(cola, aux, arregloaux);
		cola.mostrarCola();
	}
	
	public static boolean impares(Cola cola, Cola aux) {
		Integer i;
		i = (Integer) cola.mostrarFrente();
		if(cola.colaVacia()) {
			return false;
		}
		if(i % 2 == 0) {
			aux.insertar(i);
			cola.retirar();
			return impares(cola, aux);
		}
		if(i % 2 != 0) {
			cola.retirar();
			return impares(cola, aux);
		}
		
		return false;
	}
	
	public static boolean Ordenar(Cola cola, Cola aux, Integer[] arrAux) {
		Integer j;
		
		if(cola.colaVacia()) {
			 return false;
		 }
		for(int k = 0;!cola.colaVacia(); k++) {
			j = (Integer) cola.mostrarFrente();
			arrAux[k] = j;
			cola.retirar();
		}
		for(int l = 0; l < arrAux.length - 1;l++) {
			if(arrAux[l + 1] == null)continue;
			if(arrAux[l] > arrAux[l + 1]) {
				Integer aux2 = arrAux[l];
				arrAux[l] = arrAux[l + 1];
				arrAux[l + 1] = aux2;
			}
			if(arrAux[l] < arrAux[l+1]) {
				Integer aux2 = arrAux[l+1];
				arrAux[l + 1] = arrAux[l];
				arrAux[l] = aux2;
			}
		}
		for(int o = 0; o < arrAux.length; o++) {
			if(arrAux[o] == null)continue;
			cola.insertar(arrAux[o]);
		}
		return false;
	}

}
