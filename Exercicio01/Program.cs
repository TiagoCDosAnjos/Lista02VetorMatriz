namespace Exercicio01
{
    //Escreva um programa que declare e inicialize um vetor com 5 elementos inteiros e, em seguida, exiba esses elementos na tela.
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[5];
            {
                for (int i = 0; i < 5; i++)
                {
                    vet[i] = i;
                    Console.WriteLine(vet[i]);
                }
            }
        }
    }
}
