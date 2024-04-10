namespace Exercicio04
{
    internal class Program
    {
        //Escreva um programa que declare dois vetores de mesmo tamanho e calcule a soma dos elementos correspondentes de ambos os vetores,
        //armazenando o resultado em um terceiro vetor. Em seguida, exiba o vetor resultante.
        static void Main(string[] args)
        {
            int[] vetor1 = { 45, 15 };
            int[] vetor2 = { 2, 70 };
            int[] vetorSoma = new int[2];

            for (int i = 0; i < vetor1.Length; i++)
            {
                vetorSoma[i] = vetor1[i] + vetor2[i];
            }

            foreach (int i in vetorSoma)
            {
                Console.WriteLine(i);
            }
        }
    }
}
