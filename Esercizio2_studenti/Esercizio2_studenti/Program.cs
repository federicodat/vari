using Esercizio2_studenti.classes;
using System.ComponentModel.Design;

namespace Esercizio_2_Gestione_lista_studenti
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool insAbi = true;
            bool modlista = true;


            double varVoto = 0;
            string elestringa;
            double varVotox = 0;


            #region menu 
            List<string> elenco = new List<string>();

            while (insAbi)
            {
                Console.Write("Dimmi cosa vuoi fare: \n - " +
                    "A Aggiungere uno studente alla lista \n - " +
                    "U Modificare o cancellare dati di uno studente esistente \n - " +
                    "V Visualizzare l’elenco completo degli studenti \n - " +
                    "F Filtrare gli studenti in base a un voto minimo e massimo \n - " +
                    "Q per uscire   : ");

                string? inputUtente = Console.ReadLine();

                // List<Studenti> elenco = new List<Studenti>();
                if (inputUtente != null) inputUtente = inputUtente.ToUpper();

                try
                {
                    switch (inputUtente)
                    {
                        case "A":
                            {
                                Console.WriteLine("Inserisci Nome: ");
                                string? varnome = Console.ReadLine();

                                if (varnome is not null && !varnome.Trim().Equals(""))
                                {
                                    Console.WriteLine("Inserisci Cognome: ");
                                    string? varcognome = Console.ReadLine();
                                    if (varcognome is not null && !varcognome.Trim().Equals(""))
                                    {
                                        Console.WriteLine("Inserisci voto (da 0 a 10) : ");
                                        double varvoto = Convert.ToDouble(Console.ReadLine());
                                        if (varvoto >= 0 && varvoto <= 10! )
                                            {
                                           Studenti stu = new Studenti()
                                            {
                                                Nome = varnome,
                                                Cognome = varcognome,
                                                Voto = varvoto
                                            };
                                            elenco.Add(varnome + "  " + varcognome + "  " + varvoto);
                                            Console.WriteLine("inserito studente");
                                        }
                                    else
                                        Console.WriteLine("voto errato");
                                    }
                                    else
                                        Console.WriteLine("non accetto vuoto");
                                }
                                else
                                    Console.WriteLine("non accetto vuoto");


                                //break;
                            }

                           
                            break;


                        case "U":
                            
                                
                            {
                               
                                    if (elenco.Count > 0)

                                {

                                    int l = 0; int max = 0;
                                do
                                {
                                    Console.WriteLine(elenco[l]);

                                    Console.WriteLine("C=cancella M=modifica P=prossimo ");
                                    string? inputUtente2 = Console.ReadLine();
                                    if (inputUtente2 != null) inputUtente2 = inputUtente2.ToUpper();
                                    switch (inputUtente2)
                                    {
                                        case "C":

                                            elenco.RemoveAt(l);
                                            Console.WriteLine("cancellato record  studente");
                                            l = elenco.Count;
                                            break;
                                            
                                       case "M":


                                       Console.WriteLine("modifica  ");
                                            Console.WriteLine("work in progress  ");
                                            l = elenco.Count;
                                            break;
                                        
                                        case "P":


                                            Console.WriteLine("prossimo");
                                            l++;
                                            break;
                                        default:
                                            Console.WriteLine("comando errato");

                                            break;
                                    }

                                    //l++;
                                } while (l < elenco.Count);


                               
                                break;
                            }
                            else
                                Console.WriteLine("lista vuota");
                                break;

                            }
                        case "V":
                            {

                                Console.WriteLine("********* Elenco studenti  ***********");
                                Console.WriteLine("Nome -  cognome -  voto ");
                                for (int i = 0; i < elenco.Count; i++)
                                {
                                    Console.WriteLine(elenco[i]);


                                }

                            }
                            break;
                        case "F":
                            {
                                //Console.WriteLine("work in progress  ");
                                //Console.WriteLine("Filtrare gli studenti in base a un voto minimo e massimo");
                                Console.WriteLine("Inserisci voto da (valori ammessi 0 a 10) : ");
                                double varvotoda = Convert.ToDouble(Console.ReadLine());
                                if (varvotoda >= 0 && varvotoda <= 10!)
                                {
                                    Console.WriteLine("Inserisci voto a (valori ammessi 0 a 10) : ");
                                    double varvotoa = Convert.ToDouble(Console.ReadLine());
                                    if (varvotoa >= 0 && varvotoa <= 10!)
                                     {
                                        Console.WriteLine($"************* elenco studenti voto da {varvotoda}  a {varvotoa} ***********");
                                        for (int i = 0; i < elenco.Count; i++)
                                        {
                                            //Console.WriteLine(elenco[i]);
                                            elestringa = (elenco[i]);
                                            string[] invitatiArray = elestringa.Split("  ");
                                             

                                            varVotox = Convert.ToDouble((invitatiArray[2]));
                                            //Console.WriteLine(varVotox);

                                            if (varVotox >= varvotoda && varVotox <= varvotoa )
                                                Console.WriteLine(elenco[i]);

                                        }

                                    }
                                    else
                                                Console.WriteLine("voto errato");
                                }
                                    
                               
                               else
                                        Console.WriteLine("voto errato");
                                    //--
                                    break;

                            }
                         


                        case "Q":
                            insAbi = !insAbi;
                            break;

                        default:
                            Console.WriteLine("comando errato");
                            break;
                            #endregion menu 

                    }
                }




                catch (FormatException)
                {

                    Console.WriteLine("cifra  deve essere numerica");
                }
            }
            //Console.WriteLine("Hello, World!");
        }
    }
}