using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados {
    internal class LINQ2 {
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

            var pedro = listAlunos.Single(aluno => aluno.Nome.Equals("Pedro")); //Pegar um dado e armazenar, se não encotrar gera erro,uma exceção
            Console.WriteLine($"{pedro.Nome} {pedro.Nota}");

            var fulano = listAlunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano")); //Pegar um dado e armazenar, se não encotrar não gera erro e fica null
            if (fulano == null) {
                Console.WriteLine("Aluno Inexistente!");
            }

            var ana = listAlunos.First(aluno => aluno.Nome.Equals("Ana")); //Pegar o primeiro nome "Ana",  se não encotrar gera erro,uma exceção
            Console.WriteLine($"{ana.Nome} {ana.Nota}");

            var sicrano = listAlunos.FirstOrDefault(aluno => aluno.Nome.Equals("Sicrano")); //Pegar o primeiro nome "Ana",  se não encotrar não gera erro e fica null
            if (sicrano == null) {
                Console.WriteLine("Aluno Inexistente!");
            }

            var outraAna = listAlunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana")); //Pegar o segunda nome "Ana",  se não encotrar gera erro uma exceção
            Console.WriteLine($"{outraAna.Nome} {outraAna.Nota}");

            var exemploSkip = listAlunos.Skip(1).Take(3); //Pular 1 linha e imprime as proximas 3
            foreach(var item in exemploSkip) {
                Console.WriteLine(item.Nome);
            }

            var maiorNota = listAlunos.Max(aluno => aluno.Nota); //Maior Nota
            Console.WriteLine(maiorNota);

            var menorNota = listAlunos.Min(aluno => aluno.Nota); //Menor Nota
            Console.WriteLine(menorNota);

            var somatorioNotas = listAlunos.Sum(aluno => aluno.Nota); //Somatorio Notas
            Console.WriteLine(somatorioNotas);

            var mediaTurma = listAlunos.Average(aluno => aluno.Nota); //Média
            Console.WriteLine(mediaTurma);
        }
    }
}
