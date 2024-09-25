using LINQ_lez02_oggett.Models;

namespace LINQ_lez02_oggett
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<Studente> elenco =new List<Studente>();
            {
                new Studente() { Nominativo = "giovanni Pace", Matricola = "AB1234", Eta = 37 };
                new Studente() { Nominativo = "valeria verdi", Matricola = "AB1235", Eta = 44 };
                new Studente() { Nominativo = "marika mariko", Matricola = "AB1237", Eta = 33 };
                       
            };
            var studenteTrovato = elenco.FirstOrDefault(stud =>( stud.Matricola is not null && stud.Matricola.Equals("AB1234")) 
            );

            if (studenteTrovato is null)

            Console.WriteLine("studente non  Trovat");
            else
                Console.WriteLine("studente Trovat");
        }
    }
}
