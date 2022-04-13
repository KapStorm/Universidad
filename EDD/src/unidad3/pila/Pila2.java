package unidad3.pila;

public class Pila2 <T> {
	public T[] pila;
	private T memory;
	private int tope = -1;
	protected int max;
	
	 @SuppressWarnings("unchecked")
	public void CrearPila(int max) {
		pila = (T[]) new Object[max];
		this.max = max-1;
	}
	 
	 public boolean PilaVacia() {
		 if (tope == -1)
			 return true;
		 return false;
	 }
	
	 public boolean PilaLlena() {
		 if (tope == max)
			 return true;
		 return false;
	 }
	 
	 public boolean Push(T valor) { //Esta madre debe de ser void
		 if (!PilaLlena()) {
			 tope++;
			 pila[tope] = valor;
			 return true;
		 }
		 return false;
	 }
	
	 public T Pop() {	//Esta madre debe ser boolean
		 if (!PilaVacia()) {
			 memory = pila[tope];
			 pila[tope] = null;
			 tope--;
			 return memory;
		 } else {
			 return null;
		 }
	 }
	 
	 public void MostrarTodo(){
		 int c = tope;
		 if (PilaVacia())
			 System.out.println("La pila no tiene datos");
		 else {
			 System.out.println("---");
			 while (c >= 0) {
				 System.out.println(" "+pila[c]);
				 System.out.println("---");
				 c--;
			 }
		 }
	 }
	 public T MostrarTope() {
		 if (tope!=-1)
			 return pila[tope];
		 return null;
	 }
	 public T getMemory() {
		 return memory;
	 }
	 													//A partir de aqu� son m�todos que no aparecen en el PowerPoint de la profe
}