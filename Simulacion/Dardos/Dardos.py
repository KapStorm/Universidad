import random
import math

import matplotlib.pyplot as plt


def dardos():
    fig, tabla = plt.subplots(2)
    draw_circle = plt.Circle((0, 0), 1, fill=False, color='r')

    fig.set_size_inches(8, 8)

    tabla[0].set_aspect(1)
    tabla[0].add_artist(draw_circle)
    
    tabla[0].plot([-1.2, 1.2], [0, 0], color='blue')
    tabla[0].plot([0, 0], [-1.2, 1.2], color='blue')

    tabla[0].plot([-1, 1], [1, 1], color='blue')
    tabla[0].plot([-1, 1], [-1, -1], color='blue')
    tabla[0].plot([-1, -1], [-1, 1], color='blue')
    tabla[0].plot([1, 1], [-1, 1], color='blue')

    numero_calculos = int(input("¿Cuántos cálculos quiere realizar? "))
    hits = 0

    for i in range(1, numero_calculos):
        x = random.random() * 2 - 1
        y = random.random() * 2 - 1

        tabla[0].plot(x, y, marker='.')
        tabla[1].plot([0, i], [math.pi, math.pi], color='b')

        if (x * x + y * y) <= 1:
            hits += 1

        pi = hits / i * 4
        tabla[1].plot(i, pi, marker='o', color='r')
        plt.title("π = {:.8f}".format(pi))

        # plt.pause(0.05)


if __name__ == '__main__':
    dardos()
    plt.show()
