using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    internal class LendoDados {
        public static void Executar() {
            string nome;
            int idade;
            double salario;

            Console.WriteLine("Qual é o seu nome? ");
            nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade? ");
            idade = int.Parse(Console.ReadLine()); //Parse converte o tipo de variavel

            Console.WriteLine("Qual é o seu salário? ");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //CultureInfo.InvariantCulture converte para usar ponto no lugar de vírgula

            Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }
}
