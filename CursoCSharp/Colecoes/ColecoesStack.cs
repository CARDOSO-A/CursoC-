using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class ColecoesStack {
        public static void Executar() {
            var pilha = new Stack();

            pilha.Push(3); //Adicionar na pilha
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach (var item in pilha) {
                Console.WriteLine($"{item} ");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}"); //Excluir o ultimo elemento adicionado

            foreach (var item in pilha) {
                Console.WriteLine($"{item} ");
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}"); //Pegar o elemento do topo da pilha
            Console.WriteLine($"\nCont: {pilha.Count}");

        }
    }
}
