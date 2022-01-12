using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento {
    public class SubCelebridade {
        //Todos
        public string InfoPublica = "Tenho um instagram!";

        //Herança
        protected string CorDoOlho = "Verde";

        //Mesmo projeto (assembly)
        internal ulong NumeroCelular = 5554992463030;

        //Herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        //Mesma class ou herança no memso proejto (C# >= 7.2
        private protected string SegredoFamilia = "Bla Bla";

        //Private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos() {
            Console.WriteLine("SubCelebridade.. ");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
