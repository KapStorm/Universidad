package clemente.unidad1.proyecto1;

import java.util.Random;

public class Espiral implements Caracol {
    private int size;
    private int matrix[][];

    public Espiral(int size) {
        this.size = size;
        matrix = new int[size][size];
    }

    public Espiral() {
        this(new Random().nextInt(91) + 10);
    }

    @Override
    public void formar() {
        for (int number = 1; number <= size; number++) {
            for (int x = number - 1; x <= size - number; x++) {
                matrix[x][number - 1] = number;
            }

            for (int y = size - number; y >= number; y--) {
                matrix[number - 1][y] = number;
            }

            for (int x = size - number; x >= number; x--) {
                matrix[x][size - number] = number;
            }

            for (int y = number - 1; y <= size - number; y++) {
                matrix[size - number][y] = number;
            }
        }
    }

    @Override
    public void imprimir() {
        for (int y = 0; y < size; y++) {
            for (int x = 0; x < size; x++) {
                System.out.printf("%3d", matrix[x][y]);
            }
            System.out.println();
        }
    }
}
