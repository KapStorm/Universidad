import math
import random

from tabulate import tabulate


def num_licencia(num_generado: float):
    if num_generado <= 0.3:
        return 100, '0.00 - 0.30'
    elif num_generado <= 0.5:
        return 150, '0.30 - 0.50'
    elif num_generado <= 0.8:
        return 200, '0.50 - 0.80'
    elif num_generado <= 0.95:
        return 250, '0.80 - 0.95'
    elif num_generado <= 1:
        return 300, '0.95 - 1.00'
    
    return -1, '-1'


def main():
    veces = int(input("¿Cuántas veces deseas realizar la simulación? "))

    while True:
        licencias_max = int(input("¿Cuántas licencias desea vender? "))

        if licencias_max in (100, 150, 200, 250, 300):
            break

    tab = []
    utilidades = []

    for i in range(1, veces + 1):
        num_generado = random.random()
        vendidas, intervalo = num_licencia(num_generado)

        devueltas = abs(vendidas - licencias_max)
        vendidas = licencias_max if vendidas > licencias_max else vendidas

        costo = licencias_max * 75
        ing_por_venta = vendidas * 100
        ing_por_devolucion = devueltas * 25
        utilidad = costo + ing_por_venta - ing_por_devolucion

        tab.append([i, num_generado, vendidas, devueltas, costo, ing_por_venta, ing_por_devolucion, utilidad])
        utilidades.append(utilidad)

    print(tabulate(
        tab,
        headers=['#',
                 '# generado',
                 'Licencias vendidas',
                 'Licencias devueltas',
                 'Costo',
                 'Ing. x Vta',
                 'Ing. x Dev',
                 'Utilidad'
                 ],
        tablefmt='fancy_grid'
    ))

    media = sum(utilidades) / len(utilidades)
    primero = 0
    for i in utilidades:
        primero += (i - media) ** 2

    desviacion_estandar = math.sqrt(primero / len(utilidades))

    print(f'Desviacion estandar: {desviacion_estandar}')
    print(f'Media: {media}')


if __name__ == '__main__':
    main()
