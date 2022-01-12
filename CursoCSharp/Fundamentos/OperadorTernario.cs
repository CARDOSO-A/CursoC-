using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadorTernario {
        public static void Executar() {
            var nota = 7.0;
            string resultado = nota >= 7.0 ? "Aprovado" : "Reprovado"; //Ternario ´w composto por ter parte, 1° expressão + interrogação, 2° Primeiro operando de atribuição, 3° Segundo operando de atribuição
            Console.WriteLine(resultado);
        }
    }
}
