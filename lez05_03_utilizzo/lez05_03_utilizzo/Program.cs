using lez05_03_utilizzo.classes;

namespace lez05_03_utilizzo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ordine ord = new Ordine()
            {
                Codice = "AB1234",
                Spedizione = new Indirizzo()
                {
                    Nominativo = "Giovanni",
                    Via = "Le mani dal naso",
                    Citta = "Rocca cannuccia",
                    Cap = 1111,
                    Provincia = "BOH"
                },
                Fatturazione = new Indirizzo()
                {
                    Nominativo = "Valeria",
                    Via = "P.zza la bomba (pasticcino) e scappa",
                    Citta = "Rocca preturo",
                    Cap = 1112,
                    Provincia = "BOH"
                }
            };
            
            //Indirizzo ind = new Indirizzo();
           
            Console.WriteLine(ord.Codice);
            Console.WriteLine(ord);

        }
    }
}
