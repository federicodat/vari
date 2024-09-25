using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez05_02_correzione_esercizio2.classes
{
    internal class GestoreStudente
    {
        private List<Studente> Elenco     { get; set; }  = new List<Studente>();
        /// <summary>
        /// metodo aggiunta studente
        /// </summary>
        /// <param name="studente"></param>
        public void AggiungiStudente(Studente studente)
        { 
            Elenco.Add(studente);
            Console.WriteLine("aggiunto studente");
        }
        /// <summary>
        /// metodo stampa studenti
        /// </summary>
        public void StampaStudenti ()
        {
            foreach (Studente studente   in Elenco) 
            {
                Console.WriteLine(studente);
            }
        }

        /// <summary>
        /// per la modifica studenti  necessari nome e cognome
        /// </summary>
        /// <param name="vecchiostu"></param>
        /// <param name="nuovostu"></param>
        public void ModificaStudente(Studente vecchiostu, Studente nuovostu)
        {
            foreach (Studente stu in Elenco)
            {
                if (vecchiostu.Nome is not null && vecchiostu.Nome.Equals(stu.Nome) &&
                  vecchiostu.Cognome is not null && vecchiostu.Cognome.Equals(stu.Nome)) 
                {
                     stu.Nome = nuovostu.Nome;
                     stu.Cognome = nuovostu.Cognome;
                     stu.Voto = nuovostu.Voto;
                }
                 
            }


        }

        ///
        public void IntervalloVorti(double maggioreDi,double minoreDi)
        {
            List<Studente> elencotemp = new List<Studente>();   
            foreach (Studente stu in Elenco)
            {
                if (stu.Voto >= maggioreDi && stu.voto <= minoreDi)
                {
                    elencotemp.Add(stu);    

                     }
                foreach(Studente tmp in elencotemp)
                {
                    Console.WriteLine(tmp) ;

                }



            }
    }
}
