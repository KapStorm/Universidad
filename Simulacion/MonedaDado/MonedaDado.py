import random
import matplotlib.pyplot as plt

from tabulate import tabulate


def moneda_dado():
    while True:
        print("1. Moneda")
        print("2. Dado")
        print("0. Salir")
        opcion = int(input(">>> "))

        if opcion == 0:
            break

        if opcion not in (1, 2):
            continue

        lanzamientos = int(input("Lanzamientos: "))

        if opcion == 1:
            moneda(lanzamientos)
        elif opcion == 2:
            dado(lanzamientos)


def moneda(lanzamientos: int):
    arreglo = []
    probabilidadSello = probabilidadCara = 0

    for i in range(1, lanzamientos + 1):
        actual = random.random()
        cara = ""
        intervalo = ""

        if actual <= 0.5:
            cara = "Sello"
            intervalo = "0 - 0.5"
            probabilidadSello += 1
        elif actual <= 1:
            cara = "Aguila"
            intervalo = "0.5 - 1"
            probabilidadCara += 1

        arreglo.append([i, actual, intervalo, cara])

    print(tabulate(
        arreglo,
        headers=['Evento', 'Probabilidad', 'Intervalo', 'Cara'],
        tablefmt="fancy_grid"
    ))

    plt.pie([probabilidadSello, probabilidadCara],
            labels=[
                f"Sello {probabilidadSello / lanzamientos * 100}%",
                f"Cara {probabilidadCara / lanzamientos * 100}%"
            ])
    plt.show()


def dado(lanzamientos: int):
    arreglo = []
    caras = [0, 0, 0, 0, 0, 0]

    for i in range(1, lanzamientos + 1):
        actual = random.random()
        cara = ""
        intervalo = ""

        if actual <= 1 / 6:
            cara = "Uno"
            intervalo = "0 - 0.16"
            caras[0] += 1
        elif actual <= 2 / 6:
            cara = "Dos"
            intervalo = "0.16 - 0.33"
            caras[1] += 1
        elif actual <= 3 / 6:
            cara = "Tres"
            intervalo = "0.33 - 0.5"
            caras[2] += 1
        elif actual <= 4 / 6:
            cara = "Cuatro"
            intervalo = "0.5 - 0.66"
            caras[3] += 1
        elif actual <= 5 / 6:
            cara = "Cinco"
            intervalo = "0.66 - 0.83"
            caras[4] += 1
        elif actual <= 6 / 6:
            cara = "Seis"
            intervalo = "0.83 - 1"
            caras[5] += 1

        arreglo.append([i, actual, intervalo, cara])

    print(tabulate(
        arreglo,
        headers=['Evento', 'Probabilidad', 'Intervalo', 'Cara'],
        tablefmt="fancy_grid"
    ))

    plt.pie(caras,
            labels=[
                f"Uno {caras[0] / lanzamientos * 100}%",
                f"Dos {caras[1] / lanzamientos * 100}%",
                f"Tres {caras[2] / lanzamientos * 100}%",
                f"Cuatro {caras[3] / lanzamientos * 100}%",
                f"Cinco {caras[4] / lanzamientos * 100}%",
                f"Seis {caras[5] / lanzamientos * 100}%"
            ])
    plt.show()


if __name__ == '__main__':
    moneda_dado()
