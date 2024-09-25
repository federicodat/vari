using db_lez06_task_edicola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_lez06_task_edicola.Models
{
    internal class Giocattolo : Prodotto
    {
        public string Materiale { get; set; } = null!;
        public int Eta { get; set; } = 1;
        public string Codice { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Prezzo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public override string ToString()
        {
            return $"[Giocattolo] {Materiale} {Eta} ";
        }
    }
}




