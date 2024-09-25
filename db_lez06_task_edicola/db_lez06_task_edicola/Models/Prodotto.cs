using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_lez06_task_edicola.Models
{
    internal interface Prodotto
    {       public string Codice { get; set; }
            public float Prezzo { get; set; }
            public string ToString()
            {

                return $"[prodotto] {Codice} {Prezzo} ";

            }
          }

}

