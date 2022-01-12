using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    internal class FormatantoNumero {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); //F1 para uma casa decimal
            Console.WriteLine(valor.ToString("C")); //C para valor monetario "R$"
            Console.WriteLine(valor.ToString("P")); //P para porcentagem
            Console.WriteLine(valor.ToString("#.##")); //Definir o total especifico de caracteres

            CultureInfo cultura = new CultureInfo("en-US"); //Definir uma variavel com o idioma padrão
            Console.WriteLine(valor.ToString("C3", cultura)); //C para valor monetario "R$" + 3 casas decimais em formato da variavel cultura

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); //D para adicionar zeros na frende do número

        }
    }
}
