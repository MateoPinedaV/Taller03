using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el orden N de la matriz cuadrada: ");
        int N = int.Parse(Console.ReadLine());

        int[,] matriz = new int[N, N];

        // Llenar la matriz con la fórmula Celda[i][j] = i + j
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matriz[i, j] = i + j;
            }
        }

        Console.WriteLine("\nMatriz completa:");
        MostrarMatriz(matriz, N);

        Console.WriteLine("\nTriangular inferior de la matriz:");
        MostrarTriangularInferior(matriz, N);
    }

    static void MostrarMatriz(int[,] matriz, int N)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void MostrarTriangularInferior(int[,] matriz, int N)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j <= i; j++) // Solo imprime la parte triangular inferior
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
