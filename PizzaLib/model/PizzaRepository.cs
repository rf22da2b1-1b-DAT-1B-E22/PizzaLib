using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLib.model
{
    public class PizzaRepository : IPizzaRepository
    {
        private readonly List<Pizza> pizzas = new List<Pizza>();

        public Pizza Create(Pizza pizza)
        {
            pizzas.Add(pizza);
            return pizza;
        }

        public List<Pizza> GetAll()
        {
            return new List<Pizza>(pizzas);
        }
    }
}
