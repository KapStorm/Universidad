import math
import random

import matplotlib.pyplot as plt


def dardos():
    figure, axes = plt.subplots()
    circulo = plt.Circle((0, 0), radius=1, fill=False, color='r')

    axes.set_aspect(1)
    axes.add_artist(circulo)

    plt.plot([-1.2, 1.2], [0, 0], color='blue')
    plt.plot([0, 0], [-1.2, 1.2], color='blue')

    plt.plot([-1, 1], [1, 1], color='blue')
    plt.plot([-1, 1], [-1, -1], color='blue')
    plt.plot([-1, -1], [-1, 1], color='blue')
    plt.plot([1, 1], [-1, 1], color='blue')

    numero_calculos = calculos = float(input("¿Cuántos cálculos quiere realizar? "))
    aciertos = 0

    while numero_calculos:
        x = random.random() * 2 - 1
        y = random.random() * 2 - 1

        plt.plot(x, y, marker='.')

        if (math.sqrt(x * x + y * y)) <= 1:
            aciertos += 1

        numero_calculos -= 1

    pi = aciertos / calculos * 4
    print(pi)


if __name__ == '__main__':
    dardos()
    plt.show()
