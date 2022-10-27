import random
import matplotlib.pyplot as plt

from tabulate import tabulate


def num_consulta(num_generado: float):
    if num_generado <= 0.05:
        return 0, '0.00 - 0.05'
    elif num_generado <= 0.15:
        return 1, '0.05 - 0.15'
    elif num_generado <= 0.35:
        return 2, '0.15 - 0.35'
    elif num_generado <= 0.65:
        return 3, '0.35 - 0.65'
    elif num_generado <= 0.85:
        return 4, '0.65 - 0.85'
    elif num_generado <= 1.0:
        return 5, '0.85 - 1.00'

    return -1, '0'


def main():
    dias = int(input('¿Cuántos días se van a simular? '))
    num_consultas = [0, 0, 0, 0, 0, 0]
    tab = []

    for i in range(1, dias + 1):
        num_generado = random.random()
        resultado, intervalo = num_consulta(num_generado)
        num_consultas[resultado] += 1

        tab.append([num_generado, resultado, intervalo])

    print(tabulate(
        tab,
        headers=['Numero generado', 'Resultado', 'Intervalo'],
        tablefmt='fancy_grid'
    ))

    plt.pie(
        num_consultas,
        labels=[
            f'Cero {num_consultas[0] / dias * 100}%',
            f'Uno {num_consultas[1] / dias * 100}%',
            f'Dos {num_consultas[2] / dias * 100}%',
            f'Tres {num_consultas[3] / dias * 100}%',
            f'Cuatro {num_consultas[4] / dias * 100}%',
            f'Cinco {num_consultas[5] / dias * 100}%'
        ]
    )
    plt.title(f'Consultas totales: {dias}')
    plt.show()


if __name__ == '__main__':
    main()
