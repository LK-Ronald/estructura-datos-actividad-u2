namespace ProyectoC;

class Program
{
    static void Main()
    {
        float[][] notas =
        {
            [ 2.4f, 4.3f, 3.2f ],
            [ 5.0f, 1.5f, 2.2f ],
            [ 4.4f, 3.3f, 3.9f ],
            [ 4.4f, 4.3f, 2.8f ],
            [ 3.1f, 3.0f, 4.2f ],
        };

        int[] count = new int[notas.Length];

        Console.WriteLine("-------- Sin ordenar --------");
        MostrarMatrix(notas);

        Console.WriteLine("-------- Ordenado ---------");
        MatrixOrder.BubbleSortOrderMatrix(notas, count);
        MostrarMatrix(notas);

        MostraContabilizador(count);
    }

    static void MostrarMatrix(float[][] m)
    {
        for (int x = 0; x < m.Length; x++)
        {
            Console.Write("Estudiante " + x + ":");
            for (int y = 0; y < m[x].Length; y++)
            {
                Console.Write(" | " + m[x][y] + " |");
            }
            Console.WriteLine();
        }
    }


    static void MostraContabilizador(int[] count)
    {
        Console.WriteLine("----- Contabilizador de cambios --------");
        for (int i = 0; i < count.Length; i++)
        {
            Console.WriteLine("Estudiante " + i + " : " + count[i]);
        }
    }
}

static class MatrixOrder
{
    public static void BubbleSortOrderMatrix(float[][] m, int[] intercambios)
    {
        for (int i = 0; i < m.Length; i++)
        {
            int contador = 0;

            for (int j = 0; j < m[i].Length - 1; j++)
            {
                for (int k = 0; k < m[i].Length - 1 - j; k++)
                {
                    if (m[i][k] > m[i][k + 1])
                    {
                        float aux = m[i][k];
                        m[i][k] = m[i][k + 1];
                        m[i][k + 1] = aux;
                        contador++;
                    }
                }
            }
            intercambios[i] = contador;
        }
    }
}