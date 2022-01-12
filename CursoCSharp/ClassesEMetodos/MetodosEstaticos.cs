using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class CalculadoraEstatica {

        //Método e Classe ou Método estático!
        public static int Somar(int a, int b) { //static possui somente uma cópia para em toda classe
            return a + b;
        }

        //Método de instância!
        public int Multiplicar(int a, int b) { 
            return a * b;
        }
    }
    
    internal class MetodosEstaticos {
        public static void Executar() {
            var resultado = CalculadoraEstatica.Somar(2, 2); //Acesso diretamente via classe 
            Console.WriteLine(resultado);
            //Console.WriteLine(CalculadoraEstatica.Somar(2, 2));

            CalculadoraEstatica calcular = new CalculadoraEstatica();//Quando o metodo (objeto) não for static, precisa criar uma variavel do tipo da classe para acessar os métodos
            Console.WriteLine(calcular.Multiplicar(2, 2));
        }
    }
}
