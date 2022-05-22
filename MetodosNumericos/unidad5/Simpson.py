from tabulate import tabulate
from math import *


def imprimir_encabezado():
    print("Instituto Tecnológico de Culiacán".rjust(40, " "))
    print("Ing. en Sistemas Computacionales\n".rjust(41, " "))

    print("Arellanes Beltrán Sebastián")
    print("Corrales Macías Emmanuel")
    print("Integración Numérica - Método de Simpson")
    print("10:00 a 11:00 horas\n")


def funcion(x):
    return 2 + sin(2 * sqrt(x))


def caso_a(problema, v_real, a, b, unidad, n):
    print("Simpson de 1/3 formula simple\n")
    imprimir_encabezado()
    print(f"Pregunta: {problema}")

    h = (b - a) / n
    fa = funcion(a)
    x1 = a + h
    fx1 = funcion(x1)
    fb = funcion(b)
    v_calc = ((1 * h) / 3) * (fa + (4 * fx1) + fb)
    error = abs(v_real - v_calc)

    print(tabulate(
        [
            ["1", a, fa, "1", (1 * fa)],
            ["2", x1, fx1, "4", (4 * fx1)],
            ["3", b, fb, "1", (1 * fb)]
        ],
        headers=["Pxy", "x", "f(x)", "Factor", "Area"],
        tablefmt="fancy_grid",
        floatfmt=".6f"
    ))
    print(f"No. de divisiones = {n}")
    print(f"Valor real de la integral = {v_real} {unidad}")
    print(f"Valor por el método = {round(v_calc, 6)} {unidad}")
    print(f"Error del método = {round(error, 6)} {unidad}")


def caso_b(problema, v_real, a, b, unidad, n):
    print("Simpson de 3/8 formula simple\n")
    imprimir_encabezado()
    print(f"Pregunta: {problema}")

    h = (b - a) / n
    fa = funcion(a)
    x1 = a + (1 * h)
    x2 = a + (2 * h)
    fx1 = funcion(x1)
    fx2 = funcion(x2)
    fb = funcion(b)
    v_calc = ((3 * h) / 8) * (fa + (3 * fx1) + (3 * fx2) + fb)
    error = abs(v_real - v_calc)

    print(tabulate(
        [
            ["1", a, fa, "1", (1 * fa)],
            ["2", x1, fx1, "3", (3 * fx1)],
            ["3", x2, fx2, "3", (3 * fx2)],
            ["4", b, fb, "1", (1 * fb)],
        ],
        headers=["Pxy", "x", "f(x)", "Factor", "Area"],
        tablefmt="fancy_grid",
        floatfmt=".6f"
    ))
    print(f"No. de divisiones = {n}")
    print(f"Valor real de la integral = {v_real} {unidad}")
    print(f"Valor por el método = {round(v_calc, 6)} {unidad}")
    print(f"Error del método = {round(error, 6)} {unidad}")


def caso_c(problema, v_real, a, b, unidad, n):
    print("Simpson de 1/3 formula compleja")
    imprimir_encabezado()
    print(f"Pregunta: {problema}")

    v_calc = 0
    h = (b - a) / n
    ca = a
    cb = b

    output = []

    for x in range(1, n + 1):
        if x == 1:
            factor = 1
            pto = ca
            fpto = funcion(pto)
            valor = factor * fpto
            v_calc += valor

            output.append([x, pto, fpto, factor, valor])

        if x == n + 1:
            factor = 1
            pto = cb
            fpto = funcion(pto)
            valor = factor * fpto
            v_calc += valor

            output.append([x, pto, fpto, factor, valor])

        if 1 < x < n + 1:
            pos = x - 1
            res = x % 2

            if res == 0:
                factor = 4
            else:
                factor = 2

            pto = ca + (pos * h)
            fpto = funcion(pto)
            valor = factor * fpto
            v_calc += valor

            output.append([x, pto, fpto, factor, valor])

    v_calc = (1 * h / 3) * v_calc
    error = abs(v_real - v_calc)

    print(tabulate(
        output,
        headers=["Pxy", "x", "f(x)", "Factor", "Area"],
        tablefmt="fancy_grid",
        floatfmt=".6f"
    ))
    print(f"No. de divisiones = {n}")
    print(f"Valor real de la integral = {v_real} {unidad}")
    print(f"Valor por el método = {round(v_calc, 6)} {unidad}")
    print(f"Error del método = {round(error, 6)} {unidad}")


def caso_d(problema, v_real, a, b, unidad, n):
    print("Simpson de 3/8 formula compleja\n"
          "Encabezado del informe solicitado")
    imprimir_encabezado()
    print(f"Pregunta: {problema}")

    v_calc = 0
    h = (b - a) / n
    ca = a
    cb = b

    output = []

    for xx in range(1, n+1):
        if xx == 1:
            factor = 1
            pto = ca
            fpto = funcion(pto)
            valor = factor * fpto
            v_calc += valor

            output.append([xx, pto, fpto, factor, valor])

        if xx == n + 1:
            factor = 1
            pto = cb
            fpto = funcion(pto)
            valor = factor * fpto
            v_calc += valor

            output.append([xx, pto, fpto, factor, valor])

        if 1 < xx < n + 1:
            pos = xx - 1
            res = ((xx - 1) % 3)

            if res == 0:
                factor = 2
                pto = ca + (pos * h)
                fpto = funcion(pto)
                valor = factor * fpto
                v_calc += valor

                output.append([xx, pto, fpto, factor, valor])
            else:
                factor = 3
                pto = ca + (pos * h)
                fpto = funcion(pto)
                valor = factor * fpto
                v_calc += valor

                output.append([xx, pto, fpto, factor, valor])

    v_calc = (3 * h / 8) * v_calc
    error = abs(v_real - v_calc)

    print(tabulate(
        output,
        headers=["Pxy", "x", "f(x)", "Factor", "Area"],
        tablefmt="fancy_grid",
        floatfmt=".6f"
    ))
    print(f"No. de divisiones = {n}")
    print(f"Valor real de la integral = {v_real} {unidad}")
    print(f"Valor por el método = {round(v_calc, 6)} {unidad}")
    print(f"Error del método = {round(error, 6)} {unidad}")


def main():
    imprimir_encabezado()
    print("f(x) = 2+sen(2√x)")

    problema = input("¿Cuál es el problema? ")
    v_real = float(input("Ingrese el valor real: "))
    a = float(input("Ingrese el limite superior: "))
    b = float(input("Ingrese el limite inferior: "))
    unidad = input("Ingrese la unidad: ")

    # problema = "¿Cuál será la producción del empleado los días martes, miércoles, jueves y viernes de la Semana?"
    # v_real = 7.17563
    # a = 1
    # b = 5
    # unidad = "unidades"

    salida = False
    while not salida:
        print("\n\tMétodo reglas de Simpson")
        print("- Regla 1. n = 2")
        print("- Regla 2. n = 3")
        print("- Regla 3. n > 2 y n = par")
        print("- Regla 4. n > 3, n = impar y n = *3")
        print("- FIN. n = 0")

        n = int(input("¿Cuál es el número de divisiones? "))
        print("\n")

        if n == 0:
            salida = True
        elif n == 2:
            caso_a(problema, v_real, a, b, unidad, n)
        elif n == 3:
            caso_b(problema, v_real, a, b, unidad, n)
        elif n > 2 and n % 2 == 0:
            caso_c(problema, v_real, a, b, unidad, n)
        elif n > 3 and n % 2 == 1 and n % 3 == 0:
            caso_d(problema, v_real, a, b, unidad, n)
        else:
            print("Simpson no aplica para este número de divisiones\n")


if __name__ == '__main__':
    main()
