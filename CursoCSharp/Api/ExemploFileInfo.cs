using System;
using System.IO;

namespace CursoCSharp.Api {
    internal class ExemploFileInfo {
        public static void ExcluirSeExistir(params string[] caminhos) {
            foreach(var caminho in caminhos) {
                FileInfo arquivo = new FileInfo(caminho);
                if (arquivo.Exists) {
                    arquivo.Delete();
                }
            }
        }
        public static void Executar() {
            var caminhoOrigem = @"~/arq_origem.txt".ParseHome();
            var caminhoDestino = @"~/arq_destino.txt".ParseHome();
            var caminhoCopia = @"~/arq_copia.txt".ParseHome();

            ExcluirSeExistir(caminhoOrigem, caminhoDestino, caminhoCopia);

            using (StreamWriter sw = File.CreateText(caminhoOrigem)) { //CreateText criar arquivo
                sw.WriteLine("Arquivo original!");
                Console.WriteLine("Arquivo criado com sucesso!");
            }

            FileInfo origem = new FileInfo(caminhoOrigem);
            Console.WriteLine(origem.Name); //Pegar o nome do arquivo
            Console.WriteLine(origem.IsReadOnly); //É somente leitura true/false
            Console.WriteLine(origem.FullName); //Nome completo
            Console.WriteLine(origem.Extension); //Extensão do arquivo
            Console.WriteLine(origem.DirectoryName); //Diretório do arquivo

            origem.CopyTo(caminhoCopia); //Copiar o arquivo para um destino
            origem.CopyTo(caminhoDestino); //Mover o arquivo para um destino
        }
    }
}
