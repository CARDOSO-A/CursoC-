using System;
using Encapsulamento;

namespace CursoCSharp.OrientacaoObjeto {
    public class FilhoNaoReconhecido : SubCelebridade {
        public void MeusAcessos() {
            Console.WriteLine("Filho Não Reconhecido.. ");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            // Console.WriteLine(SegredoFamilia);
        }
    }
    public class AmigoDistante {
        public readonly SubCelebridade amigo = new SubCelebridade();

        public void MeusAcessos() {
            Console.WriteLine("Amigo Proximo.. ");

            Console.WriteLine(amigo.InfoPublica);
            //Console.WriteLine(amigo.CorDoOlho);
            //Console.WriteLine(amigo.NumeroCelular);
            //Console.WriteLine(amigo.JeitoDeFalar);
            //Console.WriteLine(amigo.SegredoFamilia);
            //Console.WriteLine(amigo.UsaMuitoPhotoshop);
        }

    }
    internal class Encapsulamento {
        public static void Executar() {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
