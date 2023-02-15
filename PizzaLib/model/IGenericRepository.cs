using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLib.model
{
    public interface IGenericRepository<T> where T : AbstractModelClasss
    {
        public List<T> GetAll();
        public T Create(T obj);

        // på grund af Abstract Model Class
        public T GetById(int id);
        public T Delete(int id);
        public T Update(int id, T obj);
    }
}
