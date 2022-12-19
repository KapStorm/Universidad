import math
import random

import numpy
from matplotlib import pyplot as plt
from scipy import stats
from tabulate import tabulate


def grafica_barra(axis_x, axis_y, esperado):
    data = axis_y
    labels = ["{:10.1f}".format(x) for x in axis_x]
    plt.xticks(range(len(data)), labels)
    plt.xlabel('Rangos')
    plt.ylabel('Valor')
    plt.title('Chi cuadrado')
    plt.bar(range(len(data)), data)
    plt.axhline(y=esperado, color='r', linestyle='-')

    plt.show()


def Chi2(numeroaAleatorios, porcentajedefallo):
    tabla_de_valores = []

    k = math.ceil(len(numeroaAleatorios) ** (1 / 2))
    if k % 10 != 0:
        k += 10 - k % 10

    e = len(numeroaAleatorios) / k
    intervalo = k / (k ** 2)

    intervalos = []
    for _ in numpy.arange(intervalo, 1 + intervalo, intervalo):
        intervalos.append([_, 0, e])

    for i in range(1, len(numeroaAleatorios) + 1):
        n_random = round(random.random(), 5)

        output = [i, n_random]
        tabla_de_valores.append(output)

    for dato in tabla_de_valores:
        for _ in numpy.arange(intervalo, 1 + intervalo, intervalo):
            if dato[1] < _:
                intervalos[int(k * (_ - intervalo))][1] += 1
                break

    sumatoria = 0
    for dato in intervalos:
        dato.append(dato[1] - e)
        dato.append(dato[3] ** 2 / e)
        sumatoria += dato[3] ** 2 / e

    print(tabulate(
        headers=['i', 'O', 'E', '(O-E)', '(O-E)²/E'],
        tabular_data=intervalos,
        tablefmt='fancy_grid',
        floatfmt='.4f'
    ))

    rango = 1 - porcentajedefallo
    chi_cuadrado_tabla = stats.chi2.ppf(rango, k - 1)

    arreglo1 = []
    for i in range(1, len(intervalos) + 1):
        arreglo1.append(i * intervalo)

    arreglo2 = []
    for data in intervalos:
        arreglo2.append(data[1])

    print(sumatoria)
    print(chi_cuadrado_tabla)
    print(
        'Los números estan uniformemente distribuidos' if sumatoria <= chi_cuadrado_tabla else 'Los números NO estan uniformemente distribuidos')
    grafica_barra(arreglo1, arreglo2, e)
