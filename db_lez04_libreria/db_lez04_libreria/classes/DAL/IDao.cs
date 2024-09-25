using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_lez04_libreria.classes.DAL
{
    internal interface IDao<T>
    {
        List<T> GetAll();
        T? GetByID(int id);
        bool Insert(T obj);
        bool Update(T obj);
        bool Delete(T obj);
    }
}
