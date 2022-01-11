using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OrientacaoObjeto {
    public class Carro {
        protected readonly int VelocidadeMaxima; //Protegido e somenente leitura
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta) { //Método protegido para evitar alterações
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0) {
                VelocidadeAtual = 0;
            } else if (novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;
            } else {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        public virtual int Acelerar() { //"Virtual" para que o método possa ser sobrescrito
            return AlterarVelocidade(5);
        }

        public int Frear() {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro { //Uno recebe herança de Carro
        public Uno() : base(200) { //Contrutor "Uno" recebe a base do método "Carro"

        }
    }

    public class Ferrari : Carro { //Ferrari recebe herança de Carro
        public Ferrari() : base(350) { //Contrutor "Ferrari" recebe a base do método "Carro"

        }

        public override int Acelerar() { //"override" para sobreescrever um método já existente
            return AlterarVelocidade(15);
        }

        public new int Frear() { //"new" para oculta o método "Frear" da classe Pai
            return AlterarVelocidade(-15);
        }
    }

    internal class Heranca {
        public static void Executar() {
            Console.WriteLine("Uno..");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari..");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari com tipo Carro..");
            Carro carro3 = new Ferrari();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno com tipo Carro..");
            carro3 = new Uno(); //Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}
