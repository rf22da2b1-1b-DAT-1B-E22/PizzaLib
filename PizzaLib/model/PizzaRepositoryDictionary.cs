using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLib.model
{
    public class PizzaRepositoryDictionary : IPizzaRepository
    {
        private readonly Dictionary<int, Pizza> _repository = new Dictionary<int, Pizza>();

        public Pizza Create(Pizza pizza)
        {
            _repository.Add(pizza.Id, pizza);
            return pizza;
        }

        public List<Pizza> GetAll()
        {
            return new List<Pizza>(_repository.Values);
        }

        public Pizza Get(int id)
        {
            if (_repository.ContainsKey(id))
            {
                return _repository[id];
            }
            
            throw new KeyNotFoundException();
        }
    }
}
