import random as r

import matplotlib.pyplot as plt
from tabulate import tabulate


def borracho(aleatorio: float):
    if aleatorio <= 0.25:
        return 0, 1, 'Norte'
    elif aleatorio <= 0.50:
        return 0, -1, 'Sur'
    elif aleatorio <= 0.75:
        return 1, 0, 'Este'
    elif aleatorio <= 1.00:
        return -1, 0, 'Oeste'

    return 0, 0, '0'


def main():
    figure, axes = plt.subplots()
    axes.set_aspect(1)

    cantidad_de_simulacion = int(input("¿Cuántas veces deseas realizar la simulación? "))

    intento = 0
    cantidad_de_exito = 0
    for _ in range(cantidad_de_simulacion):
        x = 0
        y = 0
        datos = []

        intento += 1
        intento_str = f'{intento}'

        plt.plot([-10, 10], [0, 0], color='black')
        plt.plot([0, 0], [-10, 10], color='black')

        for i in range(1, 11):
            aleatorio = r.random()

            res_x, res_y, direccion = borracho(aleatorio)
            x += res_x
            y += res_y

            localizacion = f'({x},{y})'

            if i == 10 and abs(x) + abs(y) >= 2:
                exito = 'Si'
                cantidad_de_exito += 1
            elif i == 10:
                exito = 'No'
            else:
                exito = ''

            datos.append([intento_str, i, aleatorio, direccion, localizacion, exito])
            intento_str = ''

            plt.plot(x, y, 'g', marker='*')
            plt.title(f'({x}, {y})')
            plt.pause(0.5)

        print(tabulate(
            datos,
            headers=[
                'N',
                '# de cuadras recorridas',
                '#alegen',
                'Dirección',
                'Localización (x,y)',
                '¿Éxito?'
            ],
            tablefmt='fancy_grid',
            stralign='center')
        )
        plt.plot(x, y, 'r', marker='o')
        plt.pause(2)
        plt.cla()

    print(f'Se obtuvieron {cantidad_de_exito} éxitos')

    probabilidad = (cantidad_de_exito / cantidad_de_simulacion) * 100

    print(f'La probabilidad de que el borracho avance 2 cuadras es de: {probabilidad}%')
    plt.show()


if __name__ == '__main__':
    main()
