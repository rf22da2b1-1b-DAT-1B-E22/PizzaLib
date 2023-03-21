using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLib.model
{
    public class Pizza2:AbstractModelClasss, IComparable<Pizza2>
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

        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (this == obj) return true;
            if (obj is not Pizza2) return false;

            return Equals(obj as Pizza2);
        }

        public  bool Equals(Pizza2 obj)
        {
            if (Id == obj.Id && Name == obj.Name && Pris == obj.Pris ) 
                return true;
            else 
                return false;
        }

        public int CompareTo(Pizza2? other)
        {
            if (other is null) return 1;
            if (this.Equals(other)) return 0;   

            return Name.CompareTo(other.Name);

        }
    }
}
