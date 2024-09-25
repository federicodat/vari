using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_le03_raggruppamenti.Nuova_cartella.Models
{
    internal class Libro
    {
        public int ID { get; set; }
        public string? Titolo { get; set; }
        public string? Autore { get; set; }
        public string? Categoria { get; set; }

        public Libro(string? titolo, string? autore, string? categoria)
        {
            Titolo = titolo;
            Autore = autore;
            Categoria = categoria;
        }

        public Libro(int id, string? titolo, string? autore, string? categoria)
        {
            ID = id;
            Titolo = titolo;
            Autore = autore;
            Categoria = categoria;
        }
        public override string ToString()
        {
            return $"[LIBRO]{ID}  {Titolo} {Autore} {Categoria}";
        }
    }
}

