using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaForEach {

        public static void Executar() {
            var palavra = "Opa!";

            foreach(var letra in palavra) {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Anna", "Antonio", "Emma" };

            foreach (string row in alunos) {
                Console.WriteLine(row);
            }
        }
    }
}
