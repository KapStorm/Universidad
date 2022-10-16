def metodo(actual: int):
    arreglo = [actual]

    while True:
        cuadrado = str(actual ** 2)
        cuadrado = ("0" * (8 - len(cuadrado))) + cuadrado
        actual = int(cuadrado[2: 6])

        if actual == 0 or actual in arreglo:
            break

        arreglo.append(actual)

    for index, numero in enumerate(arreglo):
        print(f"{index + 1}: {numero}")

    print(f"Total de numeros {len(arreglo)}")
