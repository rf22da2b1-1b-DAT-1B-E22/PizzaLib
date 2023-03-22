using PizzaLib.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrøvPizza
{
    public class SortByPrice : IComparer<Pizza2>
    {
        public int Compare(Pizza2? x, Pizza2? y)
        {
            if (x == y) return 0;
            if (x.Equals(y)) return 0;

            if (x.Pris > y.Pris) 
                return 1;
            else 
                return -1;

            //return (x.Pris > y.Pris) ? 1 : -1;

            //return y.Pris - x.Pris;

        }
    }
}
