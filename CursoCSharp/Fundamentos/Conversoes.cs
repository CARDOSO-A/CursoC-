using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Conversoes {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro; //Conversão implicita
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota; //Conversão de double para int
            Console.WriteLine("Nota truncada {0}", notaTruncada); //Conversão explicita

            Console.WriteLine("Digite a sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado da conversão: {0}", idadeInteiro);

            Console.Write("Digite o número 1: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.Write("Resultado 1: {0}", numero);

            Console.Write("Digite o número 2: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.Write("Resultado 2: {0}", numero2);
        }
    }
}
