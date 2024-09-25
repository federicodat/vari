using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_lez06_task_edicola.Models.DAL
{
    internal class giocattoloDAO : IDao<Giocattolo>
    {
        #region singletonizzazione
        private static giocattoloDAO? instance;

        public static giocattoloDAO GetInstance()
        {
            if (instance == null)
                instance = new giocattoloDAO();
            return instance;
        }

        private giocattoloDAO() { }
        #endregion singletonizzazione
        public bool Delete(Giocattolo obj)
        {
            throw new NotImplementedException();
        }

        public List<Giocattolo> GetAll()
        {
            throw new NotImplementedException();
        }

        public Giocattolo? GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Giocattolo obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Giocattolo obj)
        {
            throw new NotImplementedException();
        }
    }
}
