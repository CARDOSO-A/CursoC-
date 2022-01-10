using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class Array {
        public static void Executar() {
            string[] arrayAluno = new string[5];
            arrayAluno[0] = "Anderson";
            arrayAluno[1] = "Boa";
            arrayAluno[2] = "Carlos";
            arrayAluno[3] = "Daniela";
            arrayAluno[4] = "Emanuel";

            foreach (var row in arrayAluno) {
                Console.WriteLine(row);
            }

            double somatorio = 0;
            double[] arrayNotas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach (var row in arrayNotas) {
                somatorio += row;
            }

            double media = somatorio / arrayAluno.Length; //Length para localizar o tamanho do array
            Console.WriteLine(media);

            char[] arrayLetras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(arrayLetras);
            Console.WriteLine(palavra);
        }
    }
}
