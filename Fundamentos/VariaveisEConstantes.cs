using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class VariaveisEConstantes {
        public static void Executar() {
            //área da circunfêrencia
            double raio = 4.5;
            const double PI = 3.14;
            double area;

           raio = 5.5;
            //PI = 3.1415; essa variavel é constante, ou seja, não é possivel mudar o valor

            area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("Area: "+area);

            //Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo: "+ estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade "+ idade);

            sbyte saldoDeGols = sbyte.MinValue; //Tipo sbyte é sem sinal
            Console.WriteLine("Saldo de gols: "+saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário: "+salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor valor Inteiro: "+menorValorInt);

            uint populacaoBrasileira = 207_600_000; //Tipo uint é sem sinal
            Console.WriteLine("População Brasileira: "+ populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Valor Long: "+ menorValorLong);

            ulong populacaoMundial = 7_600_000_000; //Tipo ulong é sem sinal
            Console.WriteLine("População Mundial: " + populacaoMundial);

            float precoComputador = 1299.99f; //Para usar o float precisa colocar o f no final
            Console.WriteLine("Preço Computador: "+ precoComputador);

            double valorDeMercadoApple = 1000000000000.00;
            Console.WriteLine("Valor De Mercado Apple: " + valorDeMercadoApple);

            decimal distanciaEntreEstelas = decimal.MaxValue;
            Console.WriteLine("Distância Entre Estelas: " + distanciaEntreEstelas);

            char letra = 'b';
            Console.WriteLine("Letra: " + letra);

            string texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine("Texto: " + texto);
        }
    }
}
