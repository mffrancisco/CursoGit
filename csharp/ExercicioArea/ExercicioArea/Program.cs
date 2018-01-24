using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo c = new Circulo(5);
            c.CalculaArea(5);

            Console.ReadKey();
        }
    }
}
