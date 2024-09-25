using lez05_02_correzione_esercizio2.classes;

namespace lez05_02_correzione_esercizio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Studente gio = new Studente()
            {Nome = "Giovanni",
             Cognome= "Verdi",
                    Voto =1
            };
            
            Studente vale = new Studente()
            {Nome = "Valeria",
             Cognome= "Rossi",
                    Voto =5
            };
             
            Console.WriteLine("Hello, World!");

            GestoreStudente ges = new GestoreStudente();
            ges.AggiungiStudente(gio);
            ges.AggiungiStudente(vale);


            ges.StampaStudenti();

           // ges.AggiungiStudente(vale);


            ges.ModificaStudente(
                new Studente() { Nome = "gianni", Cognome = "pirillo" },
                new Studente() { Nome = "giovanni", Cognome = "pace" }

        }
    }
}
