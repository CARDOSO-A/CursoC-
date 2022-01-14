using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados {
    public class Aluno {
        public string Nome;
        public int Idade;
        public double Nota;
    }
    internal class LINQ1 {
        public static void Executar() {
            var listAlunos = new List<Aluno> {
                new Aluno{Nome = "Pedro", Idade = 24, Nota = 8.0},
                new Aluno{Nome = "Andre", Idade = 21, Nota = 4.3},
                new Aluno{Nome = "Ana", Idade = 25, Nota = 9.5},
                new Aluno{Nome = "Jorge", Idade = 20, Nota = 8.5},
                new Aluno{Nome = "Ana", Idade = 21, Nota = 7.7},
                new Aluno{Nome = "Julia", Idade = 22, Nota = 7.5},
                new Aluno{Nome = "Marcio", Idade = 18, Nota = 6.8},
            };

            Console.WriteLine("== Aprovados ==");
            var aprovados = listAlunos.Where(a => a.Nota >= 7).OrderBy(a => a.Nome); //Notas >= 7 e ordenadas pelo nome
            foreach(var aluno in aprovados) {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("== Chamada ==");
            var chamada = listAlunos.OrderBy(a => a.Nome).Select(a => a.Nome); //Ordenadas pelo nome e selecionar somente os nomes
            foreach (var aluno in chamada) {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("== Aprovados Ordenado por Idade ==");
            var alunosAprovados = // Sleconar de forma parecida com banco SQL
                from aluno in listAlunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;

            foreach (var aluno in alunosAprovados) {
                Console.WriteLine(aluno);
            }
        }
    }
}
