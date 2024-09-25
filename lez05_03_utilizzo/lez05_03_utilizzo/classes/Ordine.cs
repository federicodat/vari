using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez05_03_utilizzo.classes
{
    internal class Ordine
    {
        public List<Oggetto>? Elenco  { get; set; }
        public string  Codice   { get; set; }
        public Indirizzo?  Spedizione { get; set; }
        public Indirizzo?  Fatturazione  { get; set; }
         
        public void AggiungiOggetto(Oggetto ogg)
        {
             if (Elenco is null)
                Elenco= new List<Oggetto>();    

             Elenco.Add(ogg);   
        }

        public override string ToString()
        {
            return $" codice: {Codice}  \n+" +
                $" spedizione: {Spedizione}  \n +" +
                $" fatturazione: {Fatturazione}"; 
        }
    }
}
