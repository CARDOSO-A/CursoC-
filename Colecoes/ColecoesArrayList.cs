using System;
using System.Collections; //ArrayList System.Collections
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class ColecoesArrayList {
        public static void Executar() {

            //Criar um array list com varios tipos
            var arrayList = new ArrayList {
                "Palavra",
                3,
                true
            };

            arrayList.Add(3.14);

            foreach (var item in arrayList) {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }
        }
    }
}
