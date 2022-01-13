using System;
using System.IO;

namespace CursoCSharp.Api {
    public static class ExtensaoString {
        public static string ParseHome(this string path) {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX) ? Environment.GetEnvironmentVariable("HOME") : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }
    internal class PrimeiroArquivo {
        public static void Executar() {
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path)){
                using (StreamWriter sw = File.CreateText(path)) { //CreateText criar arquivo
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                    Console.WriteLine("Arquivo criado com sucesso!");
                }
            }

            using (StreamWriter sw = File.AppendText(path)) { //AppendText editar arquivo
                sw.WriteLine("É possível");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais texto!");
                Console.WriteLine("Arquivo editado com sucesso!");
            }
        }
    }
}
