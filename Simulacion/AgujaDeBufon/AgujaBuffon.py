import math
import random

import matplotlib.pyplot as plt


def aguja_buffon():
    fig, tabla = plt.subplots(2)

    fig.set_size_inches(8, 8)

    # Tabla 1
    lineas_x = [[0, 0], [1, 1], [2, 2], [3, 3]]
    lineas_y = [[0, 4], [0, 4], [0, 4], [0, 4]]

    for i in range(len(lineas_x)):
        tabla[0].plot(lineas_x[i], lineas_y[i], 'r')

    intentos = int(input("Ingrese la cantidad de intentos: "))
    aciertos = 0
    pi = 0.0

    for i in range(1, intentos):
        x1 = random.random() * 3
        y1 = random.random() * 2 + 1
        angulo = random.random() * 360
        x2 = x1 + math.cos(angulo)
        y2 = y1 + math.sin(angulo)

        tabla[0].plot([x1, x2], [y1, y2])
        tabla[1].plot([0, i], [math.pi, math.pi], color='b')

        if aciertos > 0:
            pi = 2 * i / aciertos

        if x1 > x2:
            x1, x2 = x2, x1

        if (x1 <= 0 and x2 >= 0) or (x1 <= 1 and x2 >= 1) or (x1 <= 2 and x2 >= 2) or (x1 <= 3 and x2 >= 3):
            aciertos += 1

        tabla[1].plot(i, pi, marker='o', color='r')
        plt.title("π = {:.8f}".format(pi))

        # plt.pause(0.05)


if __name__ == '__main__':
    aguja_buffon()
    plt.show()
