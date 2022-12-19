import random

from scipy import stats
from tabulate import tabulate


def huecos(numeros_aleatorios, error):
    res = []
    resultado_2 = []

    alpha = float(input("Valor de alpha: "))
    beta = float(input("valor de beta: "))

    pf = 1 - beta - alpha

    for i in range(1, len(numeros_aleatorios) + 1):
        n_random = round(random.random(), 5)
        e = 0 if alpha <= n_random <= beta else 1

        output = [i, n_random, e]
        res.append(output)

    for i, x in enumerate(res):
        if x[2] == 1:
            x.append(0)
        else:
            contador = 0
            ultimo_indice = 0
            for y in range(i, len(res)):
                if res[y][2] == 0:
                    contador += 1
                    ultimo_indice = y
                else:
                    ultimo_indice = y - 1
                    break

            for y in range(ultimo_indice, i - 1, -1):
                if len(res[y]) == 3:
                    res[y].append(contador)

    print(tabulate(
        headers=['n', 'Ui', '∈', 'i'],
        tabular_data=res,
        tablefmt='fancy_grid',
        floatfmt='.4f'
    ))

    d = dict()
    for r in range(len(res)):
        if res[r][3] != res[r - 1][3]:
            d[res[r][3]] = d.get(res[r][3], 0) + 1

    d = sorted(d.items())

    for x in d:
        if len(resultado_2) == x[0]:
            resultado_2.append(x[1])
        else:
            resultado_2[len(resultado_2) - 1] += x[1]

    res.clear()
    sumatoria_oi = sum(resultado_2)
    sumatoria_ultimo = 0
    for i, oi in enumerate(resultado_2):
        pi = (pf ** i) * (beta - alpha) if i < len(resultado_2) - 1 else pf ** i
        ei = sumatoria_oi * pi
        oi_ei = oi - ei
        ultimo = oi_ei ** 2 / ei
        res.append([i, pi, oi, ei, oi_ei, ultimo])
        sumatoria_ultimo += ultimo

    res.append(['', 1, sumatoria_oi, sumatoria_oi, 'Σ=', sumatoria_ultimo])

    print(tabulate(
        headers=['i', 'Pi', 'Oi', 'Ei', 'Oi-Ei', '(Oi-Ei)²/Ei'],
        tabular_data=res,
        tablefmt='fancy_grid',
        floatfmt='.4f'
    ))

    rango = 1 - error
    chi_cuadrado_tabla = stats.chi2.ppf(rango, i)
    print(sumatoria_ultimo)
    print(chi_cuadrado_tabla)
    print(
        'Los números estan uniformemente distribuidos' if sumatoria_ultimo <= chi_cuadrado_tabla else 'Los números NO estan uniformemente distribuidos')
