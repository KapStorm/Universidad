import math
import random

import matplotlib.pyplot as plt


def aguja_buffon():
    fig, tabla = plt.subplots(2)
    # fig = plt.figure()

    fig.set_size_inches(8, 8)

    # Tabla 1
    lineas_x = [[0, 0], [1, 1], [2, 2], [3, 3]]
    lineas_y = [[0, 4], [0, 4], [0, 4], [0, 4]]

    for i in range(len(lineas_x)):
        tabla[0].plot(lineas_x[i], lineas_y[i], 'r')

    intentos = int(input("Ingrese la cantidad de intentos: "))
    aciertos = 0

    # Tabla 2
    tabla[1].plot([0, intentos], [math.pi, math.pi])

    for i in range(intentos):
        x1 = random.random() * 3
        y1 = random.random() * 2 + 1
        angulo = random.random() * 360
        x2 = x1 + math.sin(angulo)
        y2 = y1 + math.cos(angulo)

        tabla[0].plot([x1, x2], [y1, y2])

        if aciertos != 0:
            pi = 2 * i / aciertos
            tabla[1].plot(i, pi, marker='o', color='r')

        if y1 > y2:
            y1, y2 = y2, y1

        if (y1 <= 0 and y2 >= 0) or (y1 <= 1 and y2 >= 1) or (y1 <= 2 and y2 >= 2) or (y1 <= 3 and y2 >= 3):
            aciertos += 1

    plt.title(f"Pi = {pi}")


if __name__ == '__main__':
    aguja_buffon()
    plt.show()
