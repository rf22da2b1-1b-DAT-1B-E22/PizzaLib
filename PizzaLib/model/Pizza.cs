using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLib.model
{
    public class Pizza
    {
        private int _id;
        private string _name;
        private double _pris;

        public int Id
        {
            get => _id;
            set
            {
                // betingelse
                if (!(value >= 0))
                {
                    throw new ArgumentException("Id skal være positiv");
                }

                _id = value;

            }
        }
        public string Name
        {
            get => _name;
            set
            {
                // betingelse
                if (!(value is not null))
                {
                    throw new ArgumentNullException("Der skal være et navn");
                }
                if (!(value.Trim().Length >= 5))
                {
                    throw new ArgumentException("Navn skal være mindst 5 tegn");
                }

                _name = value;
            }
        }
        public double Pris
        {
            get => _pris;
            set
            {
                // betingelse
                if (!(40 <= value && value <= 120))
                {
                    throw new ArgumentException("Pris skal være mellem 40 og 120");
                }

                _pris = value;
            }
        }

        public Pizza(int id, string name, double pris)
        {
            Id = id;
            Name = name;
            Pris = pris;

        }

        public Pizza() : this(0, "dummy", 100)
        { }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Pris)}={Pris.ToString()}}}";
        }

    }
}
