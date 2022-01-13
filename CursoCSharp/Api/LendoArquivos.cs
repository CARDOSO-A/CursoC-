using System;
using System.IO;

namespace CursoCSharp.Api {
    internal class LendoArquivos {
        public static void Executar() {
            var path = @"~/lendo_arquivo.txt".ParseHome();

            if (!File.Exists(path)) {
                using (StreamWriter sw = File.CreateText(path)) { //CreateText criar arquivo
                    sw.WriteLine("Produto;Preco;Qtde");
                    sw.WriteLine("Caneta Bic Preta;3.59;89");
                    sw.WriteLine("Borracha Branca;2.89;27");
                    Console.WriteLine("Arquivo criado com sucesso!");
               
                }
            }

            try {
                using (StreamReader sr = new StreamReader(path)) { //StreamReader ler o contéudo de um arquivo
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
