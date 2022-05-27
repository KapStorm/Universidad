package unidad4.examen;

public class ExamenLista {

	public static void main(String[] args) {
		//EJERCICIO LISTA
		ListaOrdenada alumnos;

		alumnos = inicializar();
		System.out.println("Lista por genero");
        listaPorGenero(alumnos);

		alumnos = inicializar();
		System.out.println("\nAlumnos mayores de edad");
		alumnosMayoresDeEdad(alumnos);

		alumnos = inicializar();
		System.out.println("\nLista inversa");
		listaInversa(alumnos);
	}

	public static ListaOrdenada inicializar() {
		ListaOrdenada alumnos = new ListaOrdenada();
		alumnos.insertar(new Nodo(1, "Fernando Alonso Moreno Millan",20, 'h', "6674114087", "Las Quintas"));
		alumnos.insertar(new Nodo(2, "Luisa Marie Arriaga Millan",11,'m', "667XXXXXX", "Barrancos"));
		alumnos.insertar(new Nodo(3, "Fernanda Uriarte",18,'m', "667XXXXXX", "Campi�a"));
		alumnos.insertar(new Nodo(4, "MAX",19,'h', "667XXXXXX", "Barrio Pemex"));
		alumnos.insertar(new Nodo(5, "Chava Iglesias",14,'h', "667XXXXXX", "CU"));
		return alumnos;
	}

	//M�todo que devuelve la lista de forma invertida
	public static ListaOrdenada listaInversa(ListaOrdenada original) {
		ListaOrdenada invertida = new ListaOrdenada();

		while(!original.estaVacia()) {
			Nodo auxiliar = original.retirar(original.fin.clave);

			invertida.insertar(auxiliar);
			System.out.println(auxiliar);
		}

		return invertida;
	}

	//M�todo que separa a hombres y mujeres en dos listas separadas
	public static void listaPorGenero(ListaOrdenada original) {
		ListaOrdenada hombres = new ListaOrdenada();
		ListaOrdenada mujeres = new ListaOrdenada();
		ListaOrdenada indeterminado = new ListaOrdenada();

		while (!original.estaVacia()) {
			Nodo alumnoActual = original.retirar();

			if (alumnoActual != null) {
				switch (alumnoActual.genero) {
				case 'h':
					hombres.insertar(alumnoActual);
					break;
					
				case 'm':
					mujeres.insertar(alumnoActual);
				break;
				
				default:
					indeterminado.insertar(alumnoActual);
				break;
				
				}
			}
		}
		System.out.println("Lista de Hombres: ");
		hombres.imprimir();
		System.out.println();
		System.out.println("Lista de Mujeres: ");
		mujeres.imprimir();
		System.out.println();
		System.out.println("Alumnos con g�nero indeterminado:");
		indeterminado.imprimir();
	}

	public static void alumnosMayoresDeEdad(ListaOrdenada lista) {
		while (!lista.estaVacia()) {
			Nodo auxiliar = lista.retirar();

			if (auxiliar.edad >= 18) {
				System.out.println(auxiliar);
			}
		}
	}
}
