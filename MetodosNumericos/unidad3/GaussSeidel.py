import math

from tabulate import tabulate


def imprimir_encabezado():
    print("Instituto Tecnológico de Culiacán".rjust(40, " "))
    print("Ing. en Sistemas Computacionales\n".rjust(41, " "))

    print("Arellanes Beltrán Sebastián")
    print("Corrales Macías Emmanuel")
    print("Solución de sistemas de ecuaciones")
    print("Método de Gauss Seidel")
    print("10:00 a 11:00 horas\n")

    print("Este programa ejecuta el proceso de cálculo de racíes de\n"
          "una ecuación utilizando el método de Newton Rapson\n")


def main():
    imprimir_encabezado()

    # Inicializando variables
    pregunta = input("¿Cuál es la pregunta del problema? ")
    orden = 0
    nc = 0
    errorTotal = math.inf
    concepto = []
    valorAnterior = []
    valorActual = []
    unidad = []
    matriz = []
    output = []

    while 2 > orden or orden > 6:
        orden = int(input("Ingrese el orden (2 a 6): "))

    # Captura de concepto, valor inicial y unidad
    print("\nCaptura de conceptos del problema, valor inicial y unidad")
    for f in range(orden):
        concepto.append(input(f"Concepto {f + 1}: "))
        valorAnterior.append(float(input(f"Valor inicial {f + 1}: ")))
        unidad.append(input(f"Unidad {f + 1}: "))
        valorActual.append(0)
        print()

    # Captura del error y cantidad de calculos
    print("\nComo es un método de aproximación, debe capturar el error"
          "\ny cuántos cálculos desea realizar")
    error = float(input("Ingrese el error: "))
    tc = int(input("Ingrese el número de cálculos: "))

    # Captura de datos en la matriz
    print("\nCaptura de los datos de la matriz")
    for f in range(orden):
        auxiliar = []
        print(f"Ingrese las incógnitas de la ecuación #{f + 1}")

        for c in range(orden + 1):
            if c != orden:
                auxiliar.append(float(input(f"x{c + 1}: ")))
            else:
                auxiliar.append(float(input("Resultado de la ecuación: ")))

        matriz.append(auxiliar)
        print()

    # Insertar datos originales del método a la tabla
    auxiliar = [nc]
    for i in range(orden):
        auxiliar.append(valorAnterior[i])
    auxiliar.append(0)
    output.append(auxiliar)

    # Ciclo para el método Gauss Seidel
    while errorTotal > error and nc < tc:
        errorTotal = 0
        nc += 1

        # Cálculo de los valores actuales
        for f in range(orden):
            suma = matriz[f][orden]
            coef = matriz[f][f]

            for c in range(orden):
                if f == c:
                    continue

                if c < f:
                    suma -= matriz[f][c] * valorActual[c]
                else:
                    suma -= matriz[f][c] * valorAnterior[c]

            suma /= coef
            valorActual[f] = suma

        # Cálculo del error total
        for p in range(orden):
            errorTotal += abs(abs(valorActual[p]) - abs(valorAnterior[p]))

        # Asignación de valor anterior con valor actual
        for p in range(orden):
            valorAnterior[p] = valorActual[p]

        # Agregar resultados a la salida para la tabla
        auxiliar = [nc]
        for i in range(orden):
            auxiliar.append(valorAnterior[i])

        auxiliar.append(errorTotal)
        output.append(auxiliar)

    # Impresión de resultados
    headers = ["No."]
    for i in range(orden):
        headers.append(concepto[i])
    headers.append("Error total")

    imprimir_encabezado()
    print(pregunta)
    print(tabulate(
        output,
        headers=headers,
        tablefmt="fancy_grid",
        floatfmt=".6f"
    ))

    if errorTotal <= error:
        print("Resultados")

        for p in range(orden):
            print(f"{concepto[p]} = {round(valorActual[p], 6)} {unidad[p]}")
    else:
        print("El proceso superó los cálculos y por lo tanto no se encontraron resultados")


if __name__ == '__main__':
    main()
