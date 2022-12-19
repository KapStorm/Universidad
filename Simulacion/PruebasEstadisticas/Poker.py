import random

from scipy import stats
from tabulate import tabulate


def poker(numeros_aleatorios, error):
    respuesta = []
    eventos = [0, 0, 0, 0, 0, 0, 0]

    for i in range(1, len(numeros_aleatorios) + 1):
        n_random = round(random.random(), 5)
        n_str = '{:f}'.format(n_random)

        n_str += '0' * (7 - len(n_str))

        h = [
            int(n_str[2]),
            int(n_str[3]),
            int(n_str[4]),
            int(n_str[5]),
            int(n_str[6])
        ]
        h.sort()

        pares = 0
        tercia = 0
        cuartas = 0
        quintas = 0
        for x in range(5):
            if h[x] == -1:
                continue

            contador = 0

            for y in range(x + 1, 5):
                if h[x] == h[y]:
                    contador += 1
                    h[y] = -1
                else:
                    break

            if contador == 1:
                pares += 1
            elif contador == 2:
                tercia += 1
            elif contador == 3:
                cuartas += 1
            elif contador == 4:
                quintas += 1

            h[x] = -1

        output = [i, n_random]

        if pares == tercia == cuartas == quintas == 0:
            output.append('Pachuca')
            eventos[0] += 1
        elif pares == 1 and tercia == cuartas == quintas == 0:
            output.append('1 Par')
            eventos[1] += 1
        elif pares == 2:
            output.append('2 Pares')
            eventos[2] += 1
        elif tercia == 1 and pares == 0:
            output.append('Tercia')
            eventos[3] += 1
        elif tercia == 1 and pares == 1:
            output.append('Full')
            eventos[4] += 1
        elif cuartas == 1:
            output.append('Poker')
            eventos[5] += 1
        elif quintas == 1:
            output.append('Quintilla')
            eventos[6] += 1

        respuesta.append(output)

    print(tabulate(
        headers=['n', 'ri', 'evento'],
        tabular_data=respuesta,
        tablefmt='fancy_grid'
    ))

    sumatoria = (
            (eventos[0] - 0.3024 * len(numeros_aleatorios)) ** 2 / (0.3024 * len(numeros_aleatorios)) +
            (eventos[1] - 0.5040 * len(numeros_aleatorios)) ** 2 / (0.5040 * len(numeros_aleatorios)) +
            (eventos[3] - 0.0720 * len(numeros_aleatorios)) ** 2 / (0.0720 * len(numeros_aleatorios)) +
            (eventos[2] - 0.108 * len(numeros_aleatorios)) ** 2 / (0.108 * len(numeros_aleatorios)) +
            (eventos[4] - 0.009 * len(numeros_aleatorios)) ** 2 / (0.009 * len(numeros_aleatorios)) +
            (eventos[5] - 0.0045 * len(numeros_aleatorios)) ** 2 / (0.0045 * len(numeros_aleatorios)) +
            (eventos[6] - 0.0001 * len(numeros_aleatorios)) ** 2 / (0.0001 * len(numeros_aleatorios))
    )
    print(tabulate(
        headers=['Evento', 'FO', 'PE', 'FE', '(FOi - FEi)Â² / FEi'],
        tabular_data=[
            ['Pachuca', eventos[0], 0.3024, (0.3024 * len(numeros_aleatorios)),
             ((eventos[0] - 0.3024 * len(numeros_aleatorios)) ** 2 / (0.3024 * len(numeros_aleatorios)))],
            ['Un Par', eventos[1], 0.5040, (0.5040 * len(numeros_aleatorios)),
             ((eventos[1] - 0.5040 * len(numeros_aleatorios)) ** 2 / (0.5040 * len(numeros_aleatorios)))],
            ['Tercia', eventos[3], 0.0720, (0.0720 * len(numeros_aleatorios)),
             ((eventos[3] - 0.0720 * len(numeros_aleatorios)) ** 2 / (0.0720 * len(numeros_aleatorios)))],
            ['Dos Par', eventos[2], 0.108, (0.108 * len(numeros_aleatorios)),
             ((eventos[2] - 0.108 * len(numeros_aleatorios)) ** 2 / (0.108 * len(numeros_aleatorios)))],
            ['Full', eventos[4], 0.009, (0.009 * len(numeros_aleatorios)),
             ((eventos[4] - 0.009 * len(numeros_aleatorios)) ** 2 / (0.009 * len(numeros_aleatorios)))],
            ['Poker', eventos[5], 0.0045, (0.0045 * len(numeros_aleatorios)),
             ((eventos[5] - 0.0045 * len(numeros_aleatorios)) ** 2 / (0.0045 * len(numeros_aleatorios)))],
            ['Quintilla', eventos[6], 0.0001, (0.0001 * len(numeros_aleatorios)),
             ((eventos[6] - 0.0001 * len(numeros_aleatorios)) ** 2 / (0.0001 * len(numeros_aleatorios)))],
            ['Total de la muestra', len(numeros_aleatorios), ' ', ' ', sumatoria]
        ],
        tablefmt='fancy_grid',
        floatfmt='.4f'
    ))

    rango = 1 - error
    chi_cuadrado_tabla = stats.chi2.ppf(rango, 6)
    print(sumatoria)
    print(chi_cuadrado_tabla)
    print(
        'Los números estan uniformemente distribuidos' if sumatoria <= chi_cuadrado_tabla else 'Los números NO estan uniformemente distribuidos')
