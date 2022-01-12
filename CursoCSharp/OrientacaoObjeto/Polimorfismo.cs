using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OrientacaoObjeto {
    public class Comida {
        public double Peso;
        public Comida(double peso) {
            Peso = peso;
        }
        public Comida() { }
    }
    public class Feijao : Comida {
        public Feijao(double peso) :base(peso) { }
    }
    public class Arroz : Comida {

    }
    public class Carne : Comida {

    }
    public class Pessoa {
        public double Peso;

        //public void Comer(Feijao feijao) { 
        //    Peso += feijao.Peso;
        //}
        //public void Comer(Arroz arroz) {
        //    Peso += arroz.Peso;
        //}
        //public void Comer(Carne carne) {
        //    Peso += carne.Peso;
        //}

        public void Comer(Comida comida) { //polimerfismo
            Peso += comida.Peso;
        }
    }
    internal class Polimorfismo {
        public static void Executar() {
            Feijao igrediente1 = new Feijao(0.3);

            Arroz igrediente2 = new Arroz();
            igrediente2.Peso = 0.25;

            Carne igrediente3 = new Carne();
            igrediente3.Peso = 0.3;

            Pessoa cliente = new Pessoa();
            cliente.Peso = 80.2;
            cliente.Comer(igrediente1);
            cliente.Comer(igrediente2);
            cliente.Comer(igrediente3);

            Console.WriteLine($"Agora o peso do cliente é {cliente.Peso}Kg.");
        }
    }
}
