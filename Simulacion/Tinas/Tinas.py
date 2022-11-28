import math
import random
from tabulate import tabulate


def cachear_aleatorio(num_aleatorio: float):
    if num_aleatorio < 0.5:
        return 190 + math.sqrt(800 * num_aleatorio)
    elif num_aleatorio < 1.0:
        return 230 - math.sqrt(800 * (1 - num_aleatorio))

    return 0


def main():
    simulaciones = int(input("Cantidad de simulaciones: "))
    datos = []
    costeFinal = 0

    for sim in range(1, simulaciones + 1):
        costeTotal = 0

        for dia in range(1, 261):
            costeTotal += 200
            sumaPeso = 0
            for tina in range(1, 6):
                num_aleatorio = random.random()
                peso = cachear_aleatorio(num_aleatorio)
                sumaPeso += peso

                if dia == 1 and tina == 1:
                    datos.append([sim, dia, tina, num_aleatorio, peso, sumaPeso, 'Si' if sumaPeso > 1000 else 'No', '+$200' if sumaPeso > 1000 else ''])
                else:
                    datos.append(['', dia, tina, num_aleatorio, peso, sumaPeso, 'Si' if sumaPeso > 1000 else 'No', '+$200' if sumaPeso > 1000 else ''])

            if sumaPeso > 1000:
                costeTotal += 200

        costeFinal += costeTotal

    print(tabulate(
        datos,
        headers=['N. Corrida', 'Dia', 'Tina', '#aleaR', 'Peso Sim. Acumulado', '¿Excede capacidad?', 'Si si, acumula $200'],
        tablefmt='fancy_grid'
    ))
    print(f'Coste promedio anual ${costeFinal / simulaciones}')
    print(f'Coste si se comprase un camion ${simulaciones * 50_000}')
    print(f'Diferencia entre el coste del camion y el coste de las rentas: ${(simulaciones * 50_000) - (costeFinal / simulaciones)}')


if __name__ == '__main__':
    main()
