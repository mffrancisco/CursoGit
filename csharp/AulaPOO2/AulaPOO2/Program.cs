using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno(01, "MATHEUS", "FRANCISCO", 23, 8.0);
            a1.mostrarDados();

            Console.WriteLine("\n\n");

            Professor p1 = new Professor(01, "PEDRO", "FERNANDES", 29, 2000);
            p1.mostrarDados();

            Console.ReadKey();
        }
        
    }
}
