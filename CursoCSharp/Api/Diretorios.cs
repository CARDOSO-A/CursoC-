using System;
using System.IO;

namespace CursoCSharp.Api {
    internal class Diretorios {
        public static void Executar() {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDestino".ParseHome();
            var dirProjeto = @"~/Desktop/CursoCSharp/CursoCSharp".ParseHome();

            if (Directory.Exists(novoDir)) {
                Directory.Delete(novoDir, true); // true para excluir os diretorios recursivos um dentro do outro
            }

            if (Directory.Exists(novoDirDestino)) {
                Directory.Delete(novoDirDestino, true); // true para excluir os diretorios recursivos um dentro do outro
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("== Pastas ==");
            var pastas = Directory.GetDirectories(dirProjeto);

            foreach (var pasta in pastas) {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n\n== Arquivos ==");
            var arquivos = Directory.GetFiles(dirProjeto);

            foreach (var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }


            Console.WriteLine("\n\n== Raiz ==");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            Directory.Move(novoDir, novoDirDestino);
        }
    }
}
