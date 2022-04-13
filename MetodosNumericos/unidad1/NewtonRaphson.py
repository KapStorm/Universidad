import math


def imprimir_encabezado():
    print("Instituto Tecnológico de Culiacán".rjust(40, " "))
    print("Ing. en Sistemas Computacionales\n".rjust(41, " "))

    print("- Arellanes Beltrán Sebastián")
    print("- Corrales Macias Emanuel")
    print("- Laija Guzmán Juan José")
    print("Método de Newton Raphson. Raíces de una ecuación.")
    print("Métodos Numéricos de 11:00 a 12:00 horas\n")

    print("Este programa ejecuta el proceso de cálculo de racíes de\n"
          "una ecuación utilizando el método de Newton Rapson\n")


def newton_raphson():
    def calcular_fx(x):
        return x * math.cos(x ** 2) - 4

    def calcular_fdx(x):
        return (-2) * (x ** 2) * math.sin(x ** 2) + math.cos(x ** 2)

    def calcular_x2(x, fx, fdx):
        return x - (fx / fdx)

    def encabezado_tabla():
        return "=" * 77 + "\n{:<5} {:<14} {:<14} {:<14} {:<14} {:<14}\n".format("n", "x1", "f(x1)", "f'(x1)", "x2",
                                                                                "f(x2)") + "=" * 77

    # Sección de variables que el usuario registrará por teclado
    pregunta = input("¿Cuál es tu pregunta del problema?: ")
    limitante_izquierdo = float(input("Ingresa el limitante izquierdo: "))
    limitante_derecho = float(input("Ingresa el limitante derecho: "))
    error = float(input("Ingresa el error: "))
    factor = float(input("Ingrese el factor: "))
    print()

    # Validación de los limitantes
    if limitante_izquierdo > limitante_derecho:
        limitante_izquierdo, limitante_derecho = limitante_derecho, limitante_izquierdo

    # Inicialización de variables y arreglos
    n = 1
    raices = []
    encabezados = []
    sub_encabezados = [encabezado_tabla(), ]
    punto_anterior = x1 = limitante_izquierdo

    # Ciclo que calcula las raíces de los puntos que están dentro de
    # los extremos
    while punto_anterior <= limitante_derecho:
        # Obtenemos los cálculos necesarios para después evaluar si se encontró la raíz
        fx1 = calcular_fx(x1)
        fdx1 = calcular_fdx(x1)
        x2 = calcular_x2(x1, fx1, fdx1)
        fx2 = calcular_fx(x2)

        # Agregamos al arreglo de sub_encabezados la fila de las variables
        # del cálculo numero n
        sub_encabezados.append(
            "{:<5} {:<14} {:<14} {:<14} {:<14} {:<14}".format(n, round(x1, 6), round(fx1, 6), round(fdx1, 6),
                                                              round(x2, 6), round(fx2, 6)))

        # Re-asignamos el valor de x1 con el valor de x2 para volver a realizar el
        # cálculo en caso de que no entre en el margen de error, y también aumentamos
        # el número de cálculo en uno
        x1 = x2
        n += 1

        # La condición será válida cuando el resultado de la f(x2) esté dentro del margen
        # de error o si los son mayores a 50, es decir, está en un bucle indefinido
        if abs(fx2) < error or n > 50:
            # Reiniciamos el numero de cálculos y movemos el punto anterior mediante
            # un factor
            n = 1
            punto_anterior += factor
            x1 = punto_anterior

            # Comprobar si la raíz ya fue calculada anteriormente,
            # si es verdadero entonces se omite el cálculo
            for res in raices:
                if abs(res - x2) < 0.0001:
                    x2 = math.inf
                    continue

            # Comprobar si la raíz realizó más de 50 cálculos, se pasó de los límites
            # o es mayor al error, si es verdadero se omite el cálculo
            if (x2 < limitante_izquierdo) or (x2 > limitante_derecho) or abs(fx2) > error:
                sub_encabezados = [encabezado_tabla(), ]
                continue

            # Agregamos al los arreglos de resultados y encabezados los cálculos
            # para posteriormente calcularlos
            sub_encabezados.append("=" * 77)
            raices.append(x2)
            encabezados.append(sub_encabezados)
            sub_encabezados = [encabezado_tabla(), ]

    # Ordenando los resultados
    for i in range(len(raices) - 1):
        for j in range(len(raices) - i - 1):
            if raices[j] > raices[j + 1]:
                raices[j], raices[j + 1] = raices[j + 1], raices[j]
                encabezados[j], encabezados[j + 1] = encabezados[j + 1], encabezados[j]

    # Validación e impresión de los resultados
    if len(raices) == 0:
        print("No se encontraron raíces con los datos dados")
    else:
        for i in range(len(raices)):
            print(f"Pregunta: {pregunta}")
            for enc in encabezados[i]:
                print(enc)

            print(f"Resultado de la raíz {raices[i]}")
            print()


if __name__ == '__main__':
    imprimir_encabezado()
    newton_raphson()
