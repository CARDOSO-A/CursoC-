using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class ColecoesQueue {
        public static void Executar() { 
            var fila = new Queue<string>(); //Queue generico

            fila.Enqueue("Fulano"); // Enqueue Enfilerar
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek()); // Peek pegar o primeiro elemento da fila sem remover
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue()); // Dequeue desenfilerar
            Console.WriteLine(fila.Count);

            foreach (var item in fila) {
                Console.WriteLine(item);
            }

            var salada = new Queue(); //Queue não generico, valores diferentes
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item"));
            Console.WriteLine(salada.Contains("Item"));
        }
    }
}
