using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class DesafioAtributo {
        int a = 10;
        public static void Executar() {
            //Desafio de acessar a variavel "a" sem mexer na variavel.

            DesafioAtributo valor = new DesafioAtributo(); //Precisa criar uma extancia da classe "DesafioAtributo" para acessar a varavel "a".

            Console.WriteLine($"O valor de a é: {valor.a}");
        }
    }
}
