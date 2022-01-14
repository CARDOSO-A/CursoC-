using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados {
    internal class Nullables {
        public static void Executar() {
            Nullable<int> num1 = null;
            int? num2 = null;

            if (num1.HasValue) {
                Console.WriteLine("Valor de num: {0}", num1);
            } else {
                Console.WriteLine("A variável não possui valor.");
            }

            int valor = num1 ?? 1000; // caso num1 for null ele coloca o valor padrão para 1000
            Console.WriteLine(valor);

            bool? booleana = null;//Setar o bool como null
            bool resultado = booleana.GetValueOrDefault(); //Veriifcar se o bool e null
            Console.WriteLine(resultado);

            try {
                //gera exceção pois pega o valor null
                int x = num1.Value;
                int y = num2.Value;

                //Não gera exceção pois pupula como 0
                //int x = num1.GetValueOrDefault;
                //int y = num2.GetValueOrDefault;

                Console.WriteLine(x + y);
            }catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
