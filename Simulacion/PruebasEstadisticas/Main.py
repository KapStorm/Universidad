import math
from random import random

from Chi2 import Chi2
from DistanciaHuecos import huecos
from Kolmogorov import kolmogorov
from Poker import poker
from Series import series


def ingresar_muestra():
    while (True):
        n = int(input("Ingresa el total de numeros aleatorios a generar: "))
        if n < 34:
            print('El total de numeros generados debe ser mayor o igual a 34')
        else:
            break

    return n


def generador(total_numeros):
    aleatorios = []

    for i in range(total_numeros):
        numero = random()
        numero_trunc = math.trunc(numero * 100000) / float(100000)
        aleatorios.append(numero_trunc)

    return aleatorios


def menu_de_pruebas(numeros_aleatorios):
    while True:
        print('¿Qué prueba quieres aplicar?')
        print('1. Chi2')
        print('2. Kolmogorov')
        print('3. Series')
        print('4. Distancia o Huecos')
        print('5. Poker')
        print('0. Salir')
        print('')

        opcion = int(input('Selecciona una opción: '))

        if opcion == 0:
            print('Adios')
            break

        if opcion not in range(1, 6):
            print('¡Selecciona una opción valida!')
            continue

        porcentaje_de_fallo = fallo()

        if opcion == 1:
            Chi2(numeros_aleatorios, porcentaje_de_fallo)
        elif opcion == 2:
            kolmogorov(numeros_aleatorios, porcentaje_de_fallo)
        elif opcion == 3:
            series(numeros_aleatorios, porcentaje_de_fallo)
        elif opcion == 4:
            huecos(numeros_aleatorios, porcentaje_de_fallo)
        elif opcion == 5:
            poker(numeros_aleatorios, porcentaje_de_fallo)


def fallo():
    while True:
        print('¿Qué porcentaje de fallo quieres que se aplique?')
        print('1.- 5%')
        print('2.- 10%')
        print('')

        opcion = int(input('Selecciona una opción: '))

        if opcion == 1:
            return 0.05
        elif opcion == 2:
            return 0.1
        else:
            print('¡Selecciona una opción valida')


total_de_numeros = ingresar_muestra()
numeros_aleatorios = generador(total_de_numeros)
menu_de_pruebas(numeros_aleatorios)
