using System;

class Program
{
    static void Main(string[] args)
    {
        // Criando uma instância de Random para gerar números aleatórios
        Random random = new Random();

        // Criando uma matriz 4x4 de números inteiros
        int[,] matriz = new int[4, 4];

        // Preenchendo a matriz com números aleatórios
        PreencherMatrizAleatoria(matriz, random);

        // Exibindo a matriz
        Console.WriteLine("Matriz gerada:");
        ExibirMatriz(matriz);

        // Encontrando o maior valor na matriz
        int maiorValor = EncontrarMaiorValor(matriz);

        // Exibindo o maior valor encontrado
        Console.WriteLine("\nO maior valor na matriz é: " + maiorValor);

        Console.ReadLine(); // Para manter o console aberto após a execução do programa
    }

    // Método para preencher a matriz com números aleatórios
    static void PreencherMatrizAleatoria(int[,] matriz, Random random)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = random.Next(100); // Gerando números aleatórios de 0 a 99
            }
        }
    }

    // Método para exibir a matriz
    static void ExibirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Método para encontrar o maior valor na matriz
    static int EncontrarMaiorValor(int[,] matriz)
    {
        int maiorValor = matriz[0, 0]; // Inicializando com o primeiro valor da matriz

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] > maiorValor)
                {
                    maiorValor = matriz[i, j];
                }
            }
        }

        return maiorValor;
    }
}

