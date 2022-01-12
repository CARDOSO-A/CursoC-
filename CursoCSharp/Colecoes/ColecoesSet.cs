using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class ColecoesSet { //Set não aceita dadso duplicados na lista
        public static void Executar() {
            var livro = new Produto("Game of Throne", 49.9);
            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro); // Adicionar os elementos na lista

            var combo = new HashSet<Produto>() {
                new Produto("Camisa", 29.9),
                new Produto("8° Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10),
                livro
            };
            carrinho.UnionWith(combo); // Adiconar os dados não duplicados
            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3); //Remover o elemento indice 3 da lista

            foreach (var item in carrinho) {
                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome}  {item.Preco}");
            }

            Console.WriteLine(carrinho.Count); 
            carrinho.Add(livro); 
            Console.WriteLine(carrinho.Count); 
        }
    }
}
