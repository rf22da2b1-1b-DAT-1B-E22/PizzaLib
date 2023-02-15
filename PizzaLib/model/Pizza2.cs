using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLib.model
{
    public class Pizza2:AbstractModelClasss
    {
        public String Name { get; set; }
        public double Pris { get; set; }

        public Pizza2():base()
        {
            Name = "dummy";
            Pris = 0;
        }

        public Pizza2(int id, string name, double pris):base(id)
        {
            Name = name;
            Pris = pris;
        }

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Pris)}={Pris.ToString()}, {nameof(Id)}={Id.ToString()}}}";
        }
    }
}
