using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese orden de la matriz (impar): ");
        int N = int.Parse(Console.ReadLine());

        if (N % 2 == 0)
        {
            Console.WriteLine("El número debe ser impar.");
            return;
        }

        int[,] matriz = new int[N, N];

        // Llenar la matriz con la fórmula dada
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matriz[i, j] = (i + j);
            }
        }

        // Mostrar la matriz completa
        Console.WriteLine("\nMATRIZ COMPLETA");
        MostrarMatriz(matriz, N);

        // Mostrar el reloj de arena
        Console.WriteLine("\nRELOJ DE ARENA");
        MostrarRelojDeArena(matriz, N);
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

    static void MostrarRelojDeArena(int[,] matriz, int N)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (j >= i && j < N - i || j <= i && j >= N - i - 1)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                else
                {
                    Console.Write("\t");
                }
            }
            Console.WriteLine();
        }
    }
}