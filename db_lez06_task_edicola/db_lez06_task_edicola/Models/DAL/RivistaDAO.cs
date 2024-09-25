using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_lez06_task_edicola.Models.DAL
{
    internal class RivistaDAO : IDao<Rivista>
    {
        #region singletonizzazione
        private static RivistaDAO? instance;

        public static RivistaDAO GetInstance()
        {
            if (instance == null)
                instance = new RivistaDAO();
            return instance;
        }

        private RivistaDAO() { }
        #endregion singletonizzazione
       
        public bool Delete(Rivista obj)
        {
            throw new NotImplementedException();
        }

        public List<Rivista> GetAll()
        {
            throw new NotImplementedException();
        }

        public Rivista? GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Rivista obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Rivista obj)
        {
            throw new NotImplementedException();
        }
    }
}
