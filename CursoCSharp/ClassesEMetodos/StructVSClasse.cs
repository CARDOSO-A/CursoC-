using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    public struct SPonto {
        public int X;
        public int Y;
    }
    public class CPonto {
        public int X;
        public int Y;
    }
    internal class StructVSClasse {
        public static void Executar() {

            //struct
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1; //Atribuição por VALOR e não pos referencia, o seja, só copia sem altera o outro
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 X:{0}", ponto1.X);
            Console.WriteLine("Cópia ponto 1 X:{0}", copiaPonto1.X);

            //class
            CPonto ponto2 = new CPonto { X = 2, Y = 4 };
            CPonto copiaPonto2 = ponto2; //Atribuição por Referencia e não pos valor, o seja, altera o outro
            ponto2.X = 4;

            Console.WriteLine("Ponto 2 X:{0}", ponto2.X);
            Console.WriteLine("Cópia ponto 2 X:{0}", copiaPonto2.X);
        }
    }
}
