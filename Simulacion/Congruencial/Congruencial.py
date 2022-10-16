import random

from tabulate import tabulate


def es_primo(n: int):
    for x in range(2, int(n / 2 + 1)):
        if n % x == 0:
            return True

    return False


def metodo(a: int, x: int, c: int, m: int):
    index = 0
    arreglo = []
    arreglo_x = []

    while x not in arreglo_x:
        arreglo_x.append(x)
        arreglo_temp = [index, x, (a * x + c), f"{(a * x + c)} / {m}", (a * x + c) % m]
        x = (a * x + c) % m
        index += 1

        arreglo.append(arreglo_temp)

    print(tabulate(
        arreglo,
        headers=["n", "x", "axₙ + c", "(axₙ + c) / m", "xₙ₊₁"],
        tablefmt="fancy_grid"
    ))


def main():
    a = 0
    x = 0
    c = 0
    m = 0

    while True:
        a = int(input("Valor de a: "))
        if a % 2 == 1 and not a % 3 == 0 and not a % 5 == 0:
            break

    x_por_teclado = input("¿Desea ingresar x por teclado (S/N)? ").lower() == "s"

    if x_por_teclado:
        while x <= 0:
            x = int(input("Valor de x: "))
    else:
        maximo = -1
        while maximo < 1:
            maximo = int(input("Valor maximo del random: "))

        x = random.randint(1, maximo)

    while True:
        c = int(input("Valor de c: "))

        if c % 200 == 21:
            break

    m_por_teclado = input("¿Desea ingresar m por teclado (S/N)? ").lower() == "s"

    if m_por_teclado:
        while m <= 0:
            m = int(input("Valor de m: "))
    else:
        d = 0
        while d <= 0:
            d = int(input("Valor de d: "))

        m = 10 ** d
        for item in range(10 ** d, 1):
            if es_primo(item):
                m = item
                break

    metodo(a, x, c, m)


if __name__ == '__main__':
    main()
