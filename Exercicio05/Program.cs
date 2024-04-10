namespace Exercicio05
{
    internal class Program
    {
        //Crie uma matriz 4x4 de números inteiros aleatórios e encontre o maior valor presente nela.
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int[,] matriz = new int[4, 4];

            PreencherMatriz(matriz, aleatorio);

            MostrarMatriz(matriz);
        }

        static void PreencherMatriz(int[,] matriz, Random aleatorio)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = aleatorio.Next(100);
                }
            }
        }

        static void MostrarMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    Console.Write(matriz[i, j] + "\t ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            int maiorValor = MaiorValor(matriz);
            Console.WriteLine("O maior valor é: " + maiorValor);
        }

        static int MaiorValor(int[,] matriz)
        {
            int maior = 0;

            foreach (int i in matriz)
            {
                if (i >= maior)
                    maior = i;
            }
            return maior;
        }
    }
}

