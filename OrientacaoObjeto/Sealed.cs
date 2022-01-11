using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OrientacaoObjeto {
    sealed class SemFilho { //Classe selada, não permite criar herança dela
        public double ValorDaFortuna() {
            return 1407033.65;
        }

    }
    class Avo {
        public virtual bool HonrarNomeFamilia() {
            return true;
        }
    }

    class Pai :Avo {
        public override sealed bool HonrarNomeFamilia() {
            return true;
        }
    }
    class FilhoRebelde : Pai {
        //Class pai não permite subscrever
        //public override bool HonrarNomeFamilia() {
        //    return false;
        //}
    }
    internal class Sealed {
        public static void Executar() {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }
    }
}
