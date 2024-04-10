namespace Exercicio02
{
    internal class Program
    {
        //Escreva um programa que declare e inicialize um vetor com 5 elementos inteiros e, em seguida, mostre o maior e menor valor.
        static void Main(string[] args)
        {
            int[] vetor = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite o {i + 1} valor: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            int maior = vetor[0];
            int menor = vetor[0];

            foreach (int number in vetor)
            {
                if (number > maior)
                    maior = number;
                if (number < menor)
                    menor = number;
            }

            Console.WriteLine();
            Console.WriteLine("O maior número é: " + maior);
            Console.WriteLine("O menor número é: " + menor);
        }
    }
}
