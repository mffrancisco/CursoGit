using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio r = new Radio("TOCA FITA", "FOSTON", 45.90, "PRATA", 70);
            r.ligado(true);


            Televisao t = new Televisao("TV OLD SCHOOL", "MAGNAVOX", 19.00, "AZUL BEBÊ", 15);
            t.ligado(true);

            Console.ReadKey();
        }
    }
}
