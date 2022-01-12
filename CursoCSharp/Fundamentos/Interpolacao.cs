using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Interpolacao {
        public static void Executar() {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 58000.00;

            Console.WriteLine("O "+nome+" da marca "+marca+" custa R$"+preco+"."); //Concatenação
            Console.WriteLine("O {0} da marca {1} custa R${2}.", nome, marca, preco); //Interpolação
            Console.WriteLine($"A marca {marca} é legal!"); //Interpolação
            Console.WriteLine($"Soma 1+1= {1+1}!"); //Interpolação
        }
    }
}
