import math

import matplotlib.pyplot as plt
from tabulate import tabulate


def calcular_velocidad(m, c, t):
    g = 9.81
    return g * m / c * (1 - math.e ** (-c / m * t))


def main():
    m = float(input("¿Cuál es el peso del paracaidista? "))
    c = float(input("¿Cuál es la constante de velocidad? "))

    x, y = [], []
    data = []

    t = 0
    velocidadActual = math.inf
    while True:
        velocidadAnterior = velocidadActual
        velocidadActual = calcular_velocidad(m, c, t)
        if velocidadActual == velocidadAnterior and velocidadActual != 0:
            break

        x.append(t)
        y.append(velocidadActual)
        data.append([t, velocidadActual])

        t += 5

    print(
        tabulate(
            data,
            headers=["Tiempo (s)", "Velocidad"],
            tablefmt="fancy_grid"
        )
    )

    plt.plot(x, y)
    plt.title("Paracaidista")
    plt.xlabel("Tiempo (s)")
    plt.ylabel("Velocidad")
    plt.show()


if __name__ == '__main__':
    main()
