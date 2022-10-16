import random

import Newman
import MediosCuadrados


def main():
    rango_medios_cuadrados = range(1_000, 10_000)
    rango_newman = range(1_000_000_000, 10_000_000_000)

    while True:
        print("\n=== Menu ===")
        print("1. Método Medios Cuadrados")
        print("2. Método de Newman")
        print("0. Salir")
        opcion = int(input(">>> "))

        if opcion == 0:
            break
        elif opcion not in (1, 2):
            print("Opcion incorrecta")
            continue

        semilla_por_teclado = input("¿Introducir por teclado la semilla (S/N)? ").upper() == "S"
        numero = 0

        if semilla_por_teclado:
            while True:
                numero = int(input("Ingrese la semilla: "))

                if opcion == 1 and numero in rango_medios_cuadrados:
                    break
                elif opcion == 2 and numero in rango_newman:
                    break
        else:
            if opcion == 1:
                numero = random.randint(1_000, 10_000)
            elif opcion == 2:
                numero = random.randint(1_000_000_000, 10_000_000_000)

        if opcion == 1:
            MediosCuadrados.metodo(numero)
        elif opcion == 2:
            Newman.metodo(numero)


if __name__ == '__main__':
    main()
