using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    public class Dependente {
        public string Nome;
        public int Idade;
    }
    internal class ValorVsReferencia {
        public static void Executar() {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dependente = new Dependente {
                Nome = "Beto",
                Idade = 20
            };

            Dependente copiaDependente = dependente;

            Console.WriteLine($"{dependente.Nome} {copiaDependente.Nome}");
            Console.WriteLine($"{dependente.Idade} {copiaDependente.Idade}");

            copiaDependente.Nome = "Renato";
            dependente.Idade = 21;

            Console.WriteLine($"{dependente.Nome} {copiaDependente.Nome}");
            Console.WriteLine($"{dependente.Idade} {copiaDependente.Idade}");
        }
    }
}
