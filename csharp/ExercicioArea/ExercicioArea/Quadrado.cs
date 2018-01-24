using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioArea
{
    public class Quadrado : Forma
    {
        public double Lado { get; set; }

        public Quadrado(double AreaForma) : base(AreaForma)
        {
            this.AreaForma = AreaForma;
        }

        public override double CalculaArea(double Area)
        {
            double AreaQuadrado;
            AreaQuadrado = AreaForma * AreaForma;

            return Area;

            Console.WriteLine("Area do Quadrado: {0}", Area);
            
        }
    }
}
