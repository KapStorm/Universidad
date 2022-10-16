def metodo(actual: int):
    arreglo = []

    while True:
        cuadrado = str(actual ** 2)

        # Si es par, agregar un 0 a la izquierda
        if len(cuadrado) % 2 == 0:
            cuadrado = "0" + cuadrado

        longitud = len(cuadrado)
        actual = int(cuadrado[int(longitud / 2 - 2): int(longitud / 2 + 3)])

        if actual == 0 or actual in arreglo:
            break

        arreglo.append(actual)

    for index, numero in enumerate(arreglo):
        print(f"{index + 1}: {numero}")

    print(f"Total de numeros {len(arreglo)}")
