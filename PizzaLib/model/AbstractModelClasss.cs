using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLib.model
{
    public abstract class AbstractModelClasss
    {
        public int Id { get; set; }

        protected AbstractModelClasss(int id)
        {
            Id = id;
        }

        protected AbstractModelClasss()
        {
            Id = -1;
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}}}";
        }
    }
}
