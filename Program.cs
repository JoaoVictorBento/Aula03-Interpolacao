using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2___exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Como declarar uma variável

            //juntar os textos se chama CONCATENAçÃo

            String criador = "João";

            int idade = 18;

            Console.WriteLine("Programa criado pelo " + criador);

            Console.WriteLine("Programa criado pelo " + criador);

            Console.WriteLine("Programa criado pelo " + criador);

            Console.WriteLine("Programa criado pelo " + criador + ", minha idade é: " + idade);

            //E esse é o jeito moderno, se chama INTERPOLAÇÃO

            Console.WriteLine($"meu nome é {criador} e eu tenho {idade} anos");

            Console.ReadLine();

        }

    }
}
