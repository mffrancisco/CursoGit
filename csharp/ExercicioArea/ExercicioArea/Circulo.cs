using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioArea
{
    public class Circulo : Forma
    {
        public double Raio { get; set; }

        public Circulo(double AreaForma) : base(AreaForma)
        {
            this.AreaForma = AreaForma;
        }

        public override double CalculaArea(double AreaForma)
        {
            double AreaCirculo;

            AreaCirculo = AreaForma * (3.14 * 3.14);

            return AreaCirculo;

            Console.WriteLine("Area do Círculo: {0}", AreaCirculo);
            
        }
    }
}
