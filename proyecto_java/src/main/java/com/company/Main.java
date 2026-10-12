package com.company;

public class Main {
    public static void main(String[] args) {

        float[][] notas = new float[][] {
                { 2.4f, 4.3f, 3.2f },
                { 5.0f, 1.5f, 2.2f },
                { 4.4f, 3.3f, 3.9f },
                { 4.4f, 4.3f, 2.8f },
                { 3.1f, 3.0f, 4.2f },
        };

        int[] count = new int[notas.length];

        System.out.println("-------- Sin ordenar --------");
        mostrarMatrix(notas);

        System.out.println("-------- Ordenado ---------");
        MatrixOrder.BubbleSortOrderMatrix(notas, count);
        mostrarMatrix(notas);

        mostrarContabilizadorCambios(count);
    }

    public static void mostrarMatrix(float[][] m) {
        for (int x = 0; x < m.length; x++) {
            System.out.print("Estudiante " + x + ":");
            for (int y = 0; y < m[x].length; y++) {
                System.out.print(" | " + m[x][y] + " |");
            }
            System.out.println("\n");
        }
    }

    public static void mostrarContabilizadorCambios(int[] c) {
        System.out.println("----- Contabilizador de cambios --------");
        for (int i = 0; i < c.length; i++) {
            System.out.println("Estudiante " + i + " : " + c[i]);
        }
    }
}
