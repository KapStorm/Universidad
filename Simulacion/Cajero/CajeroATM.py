import math
import random

from tabulate import tabulate as t


def Montecarlo():
    aleatorio2 = random.random()

    if aleatorio2 <= .25:
        operacion = 'Consulta'
        tiempo = 1.3

    elif aleatorio2 <= .50:
        operacion = 'Otros'
        tiempo = .83

    elif aleatorio2 <= .85:
        operacion = 'Retiros'
        tiempo = 2

    else:
        operacion = 'Transferencia'
        tiempo = 1

    return aleatorio2, operacion, tiempo


def main():
    datos = []
    tiempo_total = 0
    momento_llegada = 0
    total_espera = 0

    for cliente in range(1, 101):
        aleatorio1 = random.random()
        tiempo_llegada = (-(math.log(1 - aleatorio1) / 30) * 60)

        momento_llegada += tiempo_llegada

        tiempo_inicio = tiempo_total if tiempo_llegada < tiempo_total else momento_llegada

        tiempo_espera = 0 if momento_llegada > tiempo_total else tiempo_inicio - momento_llegada

        aleatorio2, operacion, tiempo = Montecarlo()

        tiempo_total = tiempo_inicio + tiempo

        total_espera += tiempo_espera

        datos.append(
            [cliente, aleatorio1, tiempo_llegada, momento_llegada, tiempo_inicio, tiempo_espera, aleatorio2, operacion,
             tiempo_total])

    print(t(datos, headers=['Usuario', '#alea1', 'Tiempo entre llegada', 'Momento de llegada', 'Tiempo inicia servicio',
                            'Tiempo espera/atención', '#alea2', 'Operación', 'Tiempo Operación',
                            'Tiempo termina el servicio'], tablefmt='fancy_grid'))

    print(f'Tiempo de espera de la simulación: {total_espera}')


if __name__ == '__main__':
    main()
