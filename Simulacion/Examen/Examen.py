import random

from tabulate import tabulate


def lanzamiento(numero_generado: float):
    if numero_generado < 0.5:
        return True, "Gano"
    elif numero_generado < 1:
        return False, "Perdió"

    return False, ""


def gano(monto: int, monto_deseado: int):
    if monto <= 0:
        return 'No'
    elif monto >= monto_deseado:
        return 'Si'

    return ''


def main():
    info = []
    corridas = int(input("¿Cuántas veces desea realizar la simulación? "))
    monto_inicial = int(input("Ingrese el monto inicial: "))
    monto_deseado = int(input("Ingrese el monto deseado: "))

    cantidad_de_aciertos = 0

    for i in range(1, corridas + 1):
        apuesta = 10
        monto = monto_inicial

        primera_corrida = True
        while 0 < monto < monto_deseado:
            numero_generado = random.random()

            bandera, resultado = lanzamiento(numero_generado)

            monto_anterior = monto
            apuesta_anterior = apuesta
            if bandera:
                monto += apuesta
                apuesta = 10
            else:
                monto -= apuesta
                apuesta *= 2

                apuesta = apuesta if monto >= apuesta else monto

            info.append([
                i if primera_corrida else '',
                monto_anterior,
                apuesta_anterior,
                numero_generado,
                resultado,
                monto,
                gano(monto, monto_deseado)
            ])

            primera_corrida = False

        cantidad_de_aciertos += 1 if monto >= monto_deseado else 0

    print(tabulate(
        info,
        headers=[
            '# Corrida',
            '$ antes del volado',
            'Apuesta',
            'Numero aleatorio',
            '¿Ganó?',
            '$ después del volado',
            '¿Se llegó a la meta?'
        ],
        tablefmt='fancy_grid'
    ))

    print(cantidad_de_aciertos)
    print(f'Probabilidad de éxito: %{cantidad_de_aciertos / corridas * 100}')


if __name__ == '__main__':
    main()
