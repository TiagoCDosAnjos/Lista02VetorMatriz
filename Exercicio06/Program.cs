using System.Linq.Expressions;

namespace Exercicio06
{
    internal class Program
    {
        //\t
        static void Main(string[] args)
        {
            string[,] animais = {
                   { "Fido", "Cachorro", "5", "10kg" },
                   { "Whiskers", "Gato", "5", "5kg" },
                   { "Buddy", "Cachorro", "3", "8kg" },
                   { "Fluffy", "Gato", "2", "4kg" },
                   { "Spot", "Cachorro", "4", "12kg" }
            };

            Console.Write("Deseja buscar por [nome], [espécie], [idade] ou [peso]: ");
            string buscar = Console.ReadLine();

            Console.Write("Digite a propiedade a ser buscada: ");
            string propiedade = Console.ReadLine();

            BuscarAnimal(animais, buscar, propiedade);
            Console.ReadKey();
        }

        static void BuscarAnimal(string[,] matrizAnimais, string propiedade, string valor)
        {
            int index = IndexDaMatriz(propiedade);
            for (int i = 0; i < matrizAnimais.GetLength(0); i++)
            {
                if (matrizAnimais[i, index] == valor)
                    Console.WriteLine($"Nome: {matrizAnimais[i, 0]}, Espécie: {matrizAnimais[i, 1]}, Idade: {matrizAnimais[i, 2]}, Peso: {matrizAnimais[i, 3]}");
            }

            if (index >= 4)
                Console.WriteLine("Animal não encontrado");
        }

        static int IndexDaMatriz(string propiedade)
        {
            switch (propiedade)
            {
                case "nome":
                    return 0;
                    break;
                case "espécie":
                    return 1;
                    break;
                case "idade":
                    return 2;
                    break;
                case "peso":
                    return 3;
                    break;
                default:
                    return 4;
            }
        }
    }
}
