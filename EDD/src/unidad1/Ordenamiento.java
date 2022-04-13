package unidad1;

import java.util.Arrays;

public class Ordenamiento {
    public static void main(String[] args) {
        int[] arr = {4, 7, 0, -2, 3, 1, 2};
        ordenar(arr);
        Arrays.stream(arr).forEach(x -> System.out.print(x + " "));
    }

    static int[] ordenar(int[] arr) {
        int length = arr.length;

        for (int i = 0; i < length; i++) {              // O(n)
            for (int j = 0; j < length - 1; j++) {      // O(n)
                if (arr[j] > arr[j + 1]) {              // O(1)
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        return arr;                                     // O(1)
        /*
                2+1+Σn(1+2+1+Σn(2+2+4+2+3+2)+2)+1+1
                4+Σn(7+Σn(15))
                4+Σn(7+15n)
                4+7n+15n²
                15n²+7n+5

                O(n²)
         */
    }
}
