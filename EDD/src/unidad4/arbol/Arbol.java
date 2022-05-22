package unidad4.arbol;

public class Arbol {

	private Nodo raiz;
	
	public Arbol() {
		raiz = null;
	}
	
	public boolean insertarABB(int clave) {
		if (raiz == null) {
			raiz = new Nodo(clave);
			return true;
		}
		
		return insertarABB(clave, raiz);
	}
	
	private boolean insertarABB(int clave, Nodo nodo) {
		if (clave == nodo.clave) return false;
		
		if (clave > nodo.clave) {
			if (nodo.nodoDer == null) {
				nodo.nodoDer = new Nodo(clave);
				return true;
			}
			return insertarABB(clave, nodo.nodoDer);
		}
		
		if (clave < nodo.clave) {
			if (nodo.nodoIzq == null) {
				nodo.nodoIzq = new Nodo(clave);
				return true;
			}
			return insertarABB(clave, nodo.nodoIzq);
		}
		
		return false;
	}
	
	public void inorden() {
		inorden(raiz, 0);
	}
	
	private void inorden(Nodo nodo, int i) {
		if (nodo != null && i != 50) {
			inorden(nodo.nodoIzq, i + 1);
			System.out.println(nodo.clave);
			inorden(nodo.nodoDer, i + 1);
		}
	}
	
	public void postorden() {
		postorden(raiz);
	}
	
	private void postorden(Nodo nodo) {
		if (nodo != null) {
			postorden(nodo.nodoDer);
			System.out.println(nodo.clave);
			postorden(nodo.nodoIzq);
		}
	}

	public boolean buscarBool(int clave) {
		if (raiz == null) {
			return false;
		}
		return buscarBool(clave, raiz);
	}
	
	private boolean buscarBool(int clave, Nodo nodo) {
		if (nodo != null) {
			if (clave == nodo.clave) {
				return true;
			}
			
			if (clave > nodo.clave) {
				return buscarBool(clave, nodo.nodoDer);
			}
			
			if (clave < nodo.clave) {
				return buscarBool(clave, nodo.nodoIzq);
			}
		}
		
		return false;
	}

	public int obtenerGrado(int clave) {
		Nodo nodo = obtenerGrado(clave, raiz);
		
		if (nodo == null) return -1;
		
		int raices = 0;
		if (nodo.nodoDer != null)raices++;
		if (nodo.nodoIzq != null)raices++;
		
		return raices;
	}
	
	private Nodo obtenerGrado(int clave, Nodo nodo) {
		if (nodo != null) {
			if (clave == nodo.clave) {
				return nodo;
			}
			
			if (clave > nodo.clave) {
				return obtenerGrado(clave, nodo.nodoDer);
			}
			
			if (clave < nodo.clave) {
				return obtenerGrado(clave, nodo.nodoIzq);
			}
		}
		
		return null;
	}
	
	public Nodo obtenerPadre(int clave) {
		if (raiz == null) return null;
		
		return obtenerPadre(clave, raiz); 
	}
	
	private Nodo obtenerPadre(int clave, Nodo nodo) {
		if (nodo != null) {
			if (nodo.nodoDer != null) {
				if (nodo.nodoDer.clave == clave) {
					return nodo;
				}
			}
			
			if (nodo.nodoIzq != null) {
				if (nodo.nodoIzq.clave == clave) {
					return nodo;
				}
			}
			
			if (clave > nodo.clave) {
				return obtenerPadre(clave, nodo.nodoDer);
			}
			
			if (clave < nodo.clave) {
				return obtenerPadre(clave, nodo.nodoIzq);
			}
		}
		
		return null;
	}
	
	public int obtenerNivel(int clave) {
		if (raiz == null) return -1;
		
		return obtenerNivel(clave, raiz, 0);
	}
	
	private int obtenerNivel(int clave, Nodo nodo, int nivel) {
		if (nodo != null) {
			if (nodo.clave == clave) return nivel;
			
			if (clave > nodo.clave) {
				return obtenerNivel(clave, nodo.nodoDer, nivel+1);
			}
			if (clave < nodo.clave) {
				return obtenerNivel(clave, nodo.nodoIzq, nivel+1);
			}
		}
		
		return -1;
	}
	
	public void obtenerNombres() {
		if (raiz == null) System.out.println("Arbol vacio");
		
		System.out.println(raiz.clave + ": Raiz");
		obtenerNombres(raiz.nodoDer);
		obtenerNombres(raiz.nodoIzq);
	}
	
	private void obtenerNombres(Nodo nodo) {
		if (nodo != null) {
			int gradoDelNodo = obtenerGrado(nodo.clave);
			
			System.out.print(nodo.clave);
			switch(gradoDelNodo) {
				case 0:
					System.out.println(": Hoja");
					break;
				case 1:
					System.out.println(": Intermedio");
					break;
			}
			
			obtenerNombres(nodo.nodoDer);
			obtenerNombres(nodo.nodoIzq);
		}
	}
	
	public boolean eliminar(int clave) {
		if (raiz == null) {
			return false;
		}

		return eliminar(clave, raiz);
	}
	
	private boolean eliminar(int clave, Nodo nodo) {
		if (nodo != null) {
			if (clave == nodo.clave) {
				if (raiz == nodo) return eliminarRaiz(clave);

				int grado = obtenerGrado(clave);
				Nodo padre = obtenerPadre(clave);
				
				switch (grado) {
				case 0:
					if (padre.nodoDer != null && clave == padre.nodoDer.clave) {
						padre.nodoDer = null;
					}
					if (padre.nodoIzq != null && clave == padre.nodoIzq.clave) {
						padre.nodoIzq = null;
					}
					break;
				case 1:
					if (padre.nodoDer != null && clave == padre.nodoDer.clave) {
						if (nodo.nodoDer != null) {
							padre.nodoDer = nodo.nodoDer;
						}
						if (nodo.nodoIzq != null) {
							padre.nodoDer = nodo.nodoIzq;
						}
					}
					if (padre.nodoIzq != null && clave == padre.nodoIzq.clave) {
						if (nodo.nodoDer != null) {
							padre.nodoIzq = nodo.nodoDer;
							nodo.nodoDer = null;
						}
						if (nodo.nodoIzq != null) {
							padre.nodoIzq = nodo.nodoIzq;
							nodo.nodoIzq = null;
						}
					}
					break;
				case 2:
					Nodo menorDeLosMayores = nodo.nodoDer;
					while (menorDeLosMayores.nodoIzq != null) {
						menorDeLosMayores = menorDeLosMayores.nodoIzq;
					}
					Nodo padreDelMenor = obtenerPadre(menorDeLosMayores.clave);

					if (menorDeLosMayores.nodoDer != null) {
						padreDelMenor.nodoIzq = menorDeLosMayores.nodoDer;
					}

					if (padreDelMenor.nodoIzq == menorDeLosMayores) {
						padreDelMenor.nodoIzq = null;
					}
					if (padreDelMenor.nodoDer == menorDeLosMayores) {
						padreDelMenor.nodoDer = null;
					}

					menorDeLosMayores.nodoIzq = nodo.nodoIzq;
					menorDeLosMayores.nodoDer = nodo.nodoDer;

					if (clave == padre.nodoDer.clave) {
						padre.nodoDer = menorDeLosMayores;
					}

					if (padre.nodoIzq != null && clave == padre.nodoIzq.clave) {
						padre.nodoIzq = menorDeLosMayores;
					}
					break;
				}
				return true;
			}
			
			if (clave > nodo.clave) {
				return eliminar(clave, nodo.nodoDer);
			}
			if (clave < nodo.clave) {
				return eliminar(clave, nodo.nodoIzq);
			}
		}
		return false;
	}

	private boolean eliminarRaiz(int clave) {
		int grado = obtenerGrado(clave);

		switch (grado) {
			case 0:
				raiz = null;
				break;
			case 1:
				if (raiz.nodoDer != null) {
					raiz = raiz.nodoDer;
				} else {
					raiz = raiz.nodoIzq;
				}
				break;
			case 2:
				Nodo menorDeLosMayores = raiz.nodoDer;
				while (menorDeLosMayores.nodoIzq != null) {
					menorDeLosMayores = menorDeLosMayores.nodoIzq;
				}
				Nodo padreDelMenor = obtenerPadre(menorDeLosMayores.clave);

				if (menorDeLosMayores.nodoDer != null) {
					padreDelMenor.nodoIzq = menorDeLosMayores.nodoDer;
				}

				if (padreDelMenor.nodoIzq == menorDeLosMayores) {
					padreDelMenor.nodoIzq = null;
				}
				if (padreDelMenor.nodoDer == menorDeLosMayores) {
					padreDelMenor.nodoDer = null;
				}

				menorDeLosMayores.nodoIzq = raiz.nodoIzq;
				menorDeLosMayores.nodoDer = raiz.nodoDer;

				raiz = menorDeLosMayores;
				break;
		}
		return true;
	}
}
