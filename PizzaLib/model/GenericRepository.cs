using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLib.model
{
    public class GenericRepository<T> : IGenericRepository<T> where T : AbstractModelClasss
    {

        private readonly List<T> _list = new List<T>();

        public T Create(T obj)
        {
            _list.Add(obj);
            return obj;
        }
               

        public List<T> GetAll()
        {
            return new List<T>(_list);
        }

        /*
         * metoder med id
         */
        public T Delete(int id)
        {
            T t = GetById(id); // kaster en KeyNotFoundException

            _list.Remove(t);
            return t;
        }

        public T GetById(int id)
        {
            foreach(T t in _list)
            {
                if (t.Id == id)
                {
                    return t;
                }
            }

            throw new KeyNotFoundException();
        }

        public T Update(int id, T obj)
        {
            T t = GetById(id); // kaster en KeyNotFoundException

            int ix = _list.IndexOf(t);
            _list[ix] = obj;

            return obj;
        }
    }
}
