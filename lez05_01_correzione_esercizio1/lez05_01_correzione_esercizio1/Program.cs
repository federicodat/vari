using lez05_01_correzione_esercizio1.classes;

namespace lez05_01_correzione_esercizio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Calcolatrice cal = new Calcolatrice(); non serve se static
            double prova = Calcolatrice.Somma(5, 6);

            Console.WriteLine(prova);
            double prova2 = Calcolatrice.Moltiplicazione(5, 6);

            Console.WriteLine(prova2);

            double? prova3 = Calcolatrice.Divisione(5, 0);

            Console.WriteLine(prova3);

            double? prova4= Calcolatrice.Divisione(0, 0);
            Console.WriteLine(prova4);
             
        }
    }
}
