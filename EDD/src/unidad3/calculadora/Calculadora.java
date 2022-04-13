package unidad3.calculadora;

import unidad3.pila.Pila;

public class Calculadora {

    public Double convertir(String str) {
        Pila<String> arr = convertirString(str);
        Pila<String> pila = new Pila<>(str.length());
        Pila<String> postfijo = new Pila<>(str.length());

        while (!arr.esVacia()) {
            String s = arr.retirar();

            if (esEntero(s)) {
                postfijo.insertar(s);
            }

            else if (s.equals("(")) {
                pila.insertar(s);
            }

            else if (s.equals(")")) {
                String aux;
                do {
                    aux = pila.retirar();
                    if (!aux.equals("(")) postfijo.insertar(aux);
                } while (!aux.equals("("));
            }

            else if (s.equals("+" ) || s.equals("-")) {
                if (pila.esVacia()) {
                    pila.insertar(s);
                } else {
                    if (!pila.mostrarFrente().equals("(") && pila.mostrarFrente().equals("*") || pila.mostrarFrente().equals("/")) {
                        postfijo.insertar(pila.retirar());
                    }
                    pila.insertar(s);
                }
            }

            else if (s.equals("*") || s.equals("/")) {
                if (!pila.esVacia()) {
                    String aux = pila.mostrarFrente();
                    if (aux.equals("*") || aux.equals("/")) {
                        postfijo.insertar(pila.retirar());
                    }
                }
                pila.insertar(s);
            }
        }

        while (!pila.esVacia()) {
            postfijo.insertar(pila.retirar());
        }

        return evaluar(postfijo);
    }

    private Double evaluar(Pila<String> pila) {
        pila = invertirPila(pila);
        Pila<String> respuesta = new Pila<>(pila.tamanio());

        while (!pila.esVacia()) {
            String dato = pila.retirar();
            if (esEntero(dato)) respuesta.insertar(dato);
            else {
                double n2 = Double.parseDouble(respuesta.retirar());
                double n1 = Double.parseDouble(respuesta.retirar());

                switch (dato) {
                    case "+":
                        respuesta.insertar(String.valueOf(n1 + n2));
                        break;
                    case "-":
                        respuesta.insertar(String.valueOf(n1 - n2));
                        break;
                    case "*":
                        respuesta.insertar(String.valueOf(n1 * n2));
                        break;
                    case "/":
                        respuesta.insertar(String.valueOf(n1 / n2));
                        break;
                }
            }
        }

        return Double.parseDouble(respuesta.retirar());
    }

    private Pila<String> convertirString(String s) {
        Pila<String> pila = new Pila<>(s.length());
        String aux = "";

        for (Character c : s.toCharArray()) {
            if (Character.isDigit(c)) {
                aux += c.toString();
            } else {
                if (aux.length() != 0) pila.insertar(aux);
                pila.insertar(c.toString());
                aux = "";
            }
        }
        if (aux.length() != 0) pila.insertar(aux);

        return invertirPila(pila);
    }

    private boolean esEntero(String s) {
        for (char c : s.toCharArray()) {
            if (!Character.isDigit(c)) return false;
        }

        return true;
    }

    private Pila<String> invertirPila(Pila<String> pila) {
        Pila<String> pilaInvertida = new Pila<>(pila.tamanio());

        while (!pila.esVacia()) {
            pilaInvertida.insertar(pila.retirar());
        }

        return pilaInvertida;
    }

}
