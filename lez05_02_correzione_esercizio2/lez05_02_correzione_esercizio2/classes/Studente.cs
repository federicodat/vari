using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez05_02_correzione_esercizio2.classes
{
    internal class Studente
    {
        public String? Nome { get; set; }       
        public String? Cognome { get; set; }
        public double voto;

       

        public double Voto
        {
            get { return voto; }
            set { if (value >= 0 && voto <= 10)
                    voto = value;
                else
                    Console.WriteLine("voto non ammesso");
                        }
        }


        public override string ToString()
        {
            return $" {Nome} {Cognome} {Voto}";
        }
    }
}
