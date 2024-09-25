using db_lez06_task_edicola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_lez06_task_edicola.Models
{
    internal class Rivista : Prodotto
    {
        public string Titolo { get; set; } = null!;
        public string Editrice { get; set; } = null!;
        public string Codice { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Prezzo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //public Rivista(string? Titolo, string? Editrice)
        //{
        //    Titolo = titolo;
        //    Editrice = editrice;
        //}

        public override string ToString()
        {
            return $"[Rivista] {Titolo} {Editrice} ";
        }
    }

}
 