using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLib.model
{
    public interface IPizzaRepository
    {
        public List<Pizza> GetAll();
        public Pizza Create(Pizza pizza);

    }
}
