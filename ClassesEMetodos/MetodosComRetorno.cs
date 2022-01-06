using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class CalculadoraComum {

        public int Soma(int a, int b) { 
            return a + b;
        }

        public int Subtrair(int a, int b) {
            return a - b;
        }

        public int Multiplicar(int a, int b) {
            return a * b;
        }

        public int Dividir(int a, int b) {
            return a / b;
        }
    }

    class CalculadoraCadeia { //Encadear varias chamadas
        int memoria;

        public CalculadoraCadeia Somar(int a) {
            memoria += a;
            return this; // This para retornar o proprio método
        }

        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this; // This para retornar o proprio método
        }

        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this; // This para retornar o proprio método
        }

        public CalculadoraCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this; // This para retornar o proprio método
        }

        public int Resultado() {
            return memoria;
        }
    }
    internal class MetodosComRetorno {
        public static void Executar() { 
            var calculadoraComum = new CalculadoraComum(); // Já possui um contrutor implicito por isso fazer um new direto em uma variavel
            var resultado = calculadoraComum.Soma(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(2, 7));
            Console.WriteLine(calculadoraComum.Multiplicar(4, 4));
            Console.WriteLine(calculadoraComum.Dividir(10, 2));

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(2).Imprimir().Limpar().Imprimir(); //Chamadas encadeandas

            resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();
        }
    }
}
