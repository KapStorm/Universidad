import random

import matplotlib.pyplot as plt
import pylab
import scipy.stats as stats
from tabulate import tabulate


def series(numeros_aleatorios, error):
    plt.xlabel('x')
    plt.ylabel('y')

    n_random = []
    e = len(numeros_aleatorios) / (5 ** 2)
    tabla = [
        [1, 0, 0, 0, 0, 0],
        [0.8, 0, 0, 0, 0, 0],
        [0.6, 0, 0, 0, 0, 0],
        [0.4, 0, 0, 0, 0, 0],
        [0.2, 0, 0, 0, 0, 0]
    ]

    for _ in range(len(numeros_aleatorios)):
        n_random.append([random.random(), random.random()])

    x_ = []
    y_ = []
    for data in n_random:
        x_.append(data[0])
        y_.append(data[1])

    plt.scatter(x_, y_, marker='o')
    plt.grid(True)
    for dato in n_random:
        dato_1 = dato[0]
        dato_2 = dato[1]

        x = 0
        y = 0
        for _ in pylab.arange(0.2, 1.2, 0.2):
            if not dato_1 < _:
                x += 1
            if not dato_2 < _:
                y += 1

        tabla[4 - x][y + 1] += 1

    print('Observado. Oij')
    print(tabulate(
        headers=['', 0.2, 0.4, 0.6, 0.8, 1],
        tabular_data=tabla,
        tablefmt='fancy_grid'
    ))

    print('Esperando. Eij')
    print(tabulate(
        headers=['', 0.2, 0.4, 0.6, 0.8, 1],
        tabular_data=[
            [1, e, e, e, e, e],
            [0.8, e, e, e, e, e],
            [0.6, e, e, e, e, e],
            [0.4, e, e, e, e, e],
            [0.2, e, e, e, e, e],
        ],
        tablefmt='fancy_grid'
    ))

    calculos = [
        [1],
        [0.8],
        [0.6],
        [0.4],
        [0.2]
    ]

    sumatoria = 0
    for x in range(1, 6):
        for y in range(0, 5):
            resultado = (tabla[y][x] - e) ** 2 / e
            sumatoria += resultado
            calculos[y].append(resultado)

    print(tabulate(
        headers=['', 0.2, 0.4, 0.6, 0.8, 1],
        tabular_data=calculos,
        tablefmt='fancy_grid',
        floatfmt='.4f'
    ))

    rango = 1 - error
    chi_cuadrado_tabla = stats.chi2.ppf(rango, 24)
    print(sumatoria)
    print(chi_cuadrado_tabla)
    print(
        'Los números estan uniformemente distribuidos' if sumatoria <= chi_cuadrado_tabla else 'Los números NO estan uniformemente distribuidos')

    plt.show()
