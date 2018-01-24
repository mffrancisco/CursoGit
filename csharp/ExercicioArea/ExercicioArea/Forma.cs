using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioArea
{
    public abstract class Forma
    {
        public double AreaForma { get; set; }

        public Forma(double Area)
        {
            this.AreaForma = AreaForma;
        }

        public abstract double CalculaArea(double Area);
    }
}
