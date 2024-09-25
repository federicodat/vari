using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez05_03_utilizzo.classes
{
    internal class Indirizzo
    {
        public string Nominativo { get; set; } = null!;
        public string Via { get; set; } = null!;
        public string Citta { get; set; } = null!;
        public string Provincia { get; set; } = null!;
        public int Cap { get; set; } = 0!;

      
        public override string ToString()
        {
            return $"{Nominativo} {Via} {Citta} {Cap}";
        }
    }
}
