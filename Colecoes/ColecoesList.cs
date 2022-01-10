using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object? obj) {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Nome, Preco);
        }
    }
    internal class ColecoesList {
        public static void Executar() {
            var livro = new Produto("Game of Throne", 49.9);
            var carrinho = new List<Produto>();
            carrinho.Add(livro); // Adicionar os elementos na lista

            var combo = new List<Produto>() {
                new Produto("Camisa", 29.9),
                new Produto("8° Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10)
            };
            carrinho.AddRange(combo); // Adiconar varios dados em uma lista
            Console.WriteLine(carrinho.Count); //Tamanho da lista
            carrinho.RemoveAt(3); //Remover o elemento indice 3 da lista

            foreach (var item in carrinho) {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome}  {item.Preco}");
            }

            Console.WriteLine(carrinho.Count); //Tamanho da lista
            carrinho.Add(livro); // Adicionar os elementos na lista
            Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
