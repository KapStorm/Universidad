import random

from tabulate import tabulate


def color_fn(num_random: float):
    if num_random < 0.4545:
        return 'Rojo'
    elif num_random < 0.9090:
        return 'Negro'
    else:
        return 'Verde'


def main():
    jugadores = int(input('Cantidad de jugadores: '))
    resultados = []

    for jugador in range(1, jugadores + 1):
        dinero = 200
        apuesta = 1
        datos = []

        for i, resultado in enumerate(resultados):
            if not 0 < dinero < 1000:
                break

            i += 1

            num_random = random.random()
            color = color_fn(num_random)

            if resultado == color:
                dinero_antes = dinero
                dinero += apuesta
                apuesta = 1

                datos.append([i,
                              dinero_antes,
                              apuesta,
                              num_random,
                              resultado,
                              'Si',
                              dinero,
                              'Si' if dinero > 1000 else 'No',
                              '++' if dinero > 1000 else ''
                              ])
            elif resultado == 'Verde':
                datos.append([i,
                              dinero,
                              apuesta,
                              num_random,
                              resultado,
                              'Nulo',
                              dinero,
                              'No',
                              ''
                              ])
            else:
                dinero_antes = dinero
                dinero -= apuesta

                datos.append([i,
                              dinero_antes,
                              apuesta,
                              num_random,
                              resultado,
                              'No',
                              dinero,
                              'No',
                              '--' if 0 >= dinero else ''
                              ])

                apuesta *= 2

                if apuesta > dinero:
                    apuesta = dinero

        indx = len(resultados)
        while 0 < dinero < 1000:
            indx += 1

            num_random_tablero = random.random()
            num_random_jugador = random.random()
            color_tablero = color_fn(num_random_tablero)
            color_jugador = color_fn(num_random_jugador)

            resultados.append(color_tablero)

            if color_tablero == color_jugador:
                dinero_antes = dinero
                dinero += apuesta

                datos.append([indx,
                              dinero_antes,
                              apuesta,
                              num_random_jugador,
                              color_tablero,
                              'Si',
                              dinero,
                              'Si' if dinero >= 1000 else 'No',
                              '++' if dinero >= 1000 else ''
                              ])

                apuesta = 1

            elif color_tablero == 'Verde':
                datos.append([indx,
                              dinero,
                              apuesta,
                              num_random_jugador,
                              color_tablero,
                              'Nulo',
                              dinero,
                              'No',
                              ''
                              ])
            else:
                dinero_antes = dinero
                dinero -= apuesta

                datos.append([indx,
                              dinero_antes,
                              apuesta,
                              num_random_jugador,
                              color_tablero,
                              'No',
                              dinero,
                              'No',
                              '--' if 0 >= dinero else ''
                              ])

                apuesta *= 2

                if apuesta > dinero:
                    apuesta = dinero

        print(tabulate(
            datos,
            headers=['#interación', '$ antes de ganar', 'Apuesta', '#alea', 'Color', '¿Ganó?', '$ después de ganar', 'Se llegó a $1,000 USD', 'Exito++'],
            tablefmt='fancy_grid'
        ))


if __name__ == '__main__':
    main()
