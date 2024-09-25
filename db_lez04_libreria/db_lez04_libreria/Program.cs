using db_lez04_libreria.classes;
using db_lez04_libreria.classes.DAL;
using System;
using System.ComponentModel.Design;

namespace db_lez04_libreria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool insAbi=true;
            while (insAbi) 
            {
                
                Console.WriteLine("Digita il comando per scegliere operazione : " +
                        "I inserimento\n" +
                    "S stampa  \n" +
                    "Q esci");

                string? inputUtente = Console.ReadLine();

                switch(inputUtente) {
                    case "I":
                        Console.WriteLine("inserisci titolo");
                        string? inTitolo=Console.ReadLine();                Console.WriteLine("inserisci autore");
                        string? inAutore=Console.ReadLine();                Console.WriteLine("inserisci pagine");
                        int inPagine =Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("inserisci editore");
                        string? inEditore= Console.ReadLine();  Console.WriteLine("inserisci isbn");
                        string? inIsbn= Console.ReadLine();

                        Libro lib = new Libro()
                        {
                            Titolo = inTitolo is not null ? inTitolo : "N.D.",
                            Autore = inAutore is not null ? inAutore : "N.D.",
                            Pagine = inPagine,
                            Editore = inEditore is not null ? inEditore : "N.D.",
                            Isbn = inIsbn is not null ? inIsbn : "N.D."

                        };
                          if ( LibroDAO.GetInstance().Insert(lib))
                        

                            Console.WriteLine("libro inserito");
                            else
                            Console.WriteLine("errore di inserimento");
                        


                        break;
                    case "S":
                        List<Libro> elenco = LibroDAO.GetInstance().GetAll();

                        foreach (Libro libro in elenco)
                        {
                            Console.WriteLine(libro);
                        }
                        break;

                  
                    case "Q":
                        insAbi = false;
                        break;
                    default:
                        Console.WriteLine("non conosco comando");
                        break;

                }
    }
        }
    }
}



