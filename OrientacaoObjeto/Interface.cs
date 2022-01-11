using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OrientacaoObjeto {
    interface OperacaoBinaria {
        int Operacao(int a, int b); //Método abstrado, pois é implicitamente abstrata por ser uma interface
    }
    interface Teste {
        bool Bla(string a);
    }

    class Soma : OperacaoBinaria, Teste { //Exemplo de dois métodos passado por herança
        public int Operacao(int a, int b) {
            return a + b;
        }

        public bool Bla(string a) {
            return true;
        }
    }
    class Subtracao : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a - b;
        }
    }
    class Multiplicacao : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a * b;
        }
    }

    class Calculadora {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria> {
            new Soma(),
            new Subtracao(),
            new Multiplicacao()
        };

        public string ExecutarOperacoes(int a, int b) {
            string resultado = "";

            foreach (var op in operacoes) {
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n";
            }

            return resultado;
        }
    }
    internal class Interface {
        public static void Executar() {
            var calc = new Calculadora();
            var resultado = calc.ExecutarOperacoes(20, 5);
            Console.WriteLine(resultado);
        }
    }
}
