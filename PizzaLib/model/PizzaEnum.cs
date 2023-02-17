using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLib.model
{
    public enum PizzaType { Almindelig, DeepPan, Lukket }

    public  class PizzaEnum:Pizza
    {
        public PizzaType Slags { get; set; }

        public PizzaEnum(int id, string name, double pris, PizzaType slags):base(id,name,pris)
        {
            Slags = slags;
        }
        public PizzaEnum() : base()
        {
            Slags = PizzaType.Almindelig;
        }

    }
}
