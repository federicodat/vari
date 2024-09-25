using db_lez06_task_edicola.Models;
using db_lez06_task_edicola.Models.DAL;

namespace db_lez06_task_edicola
{
    internal class Program
    {
        static void Main(string[] args)
        {



            {
                bool insAbi = true;
                while (insAbi)
                {

                    Console.WriteLine("Digita il comando per scegliere operazione : " +
                            "G inserimento giocattolo \n" +
                            "R inserimento rivista \n" +
                           "S stampa  \n" +
                            "Q esci");
                        
                    string? inputUtente = Console.ReadLine();

                    switch (inputUtente)
                    {
                        case "G":
                            Console.WriteLine("inserisci Materiale");
                            string? inMateriale = Console.ReadLine(); 
                            Console.WriteLine("inserisci eta minima");
                            string? inEta = Console.ReadLine();

                            Giocattolo gioc  = new Giocattolo();   
                            if (giocattoloDAO.GetInstance().Insert(gioc))


                                Console.WriteLine("gioco inserito");
                            else
                                Console.WriteLine("errore di inserimento");




                            break;
                        case "S":
                         
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
}