using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            //LPessoa lPessoa = new LPessoa();

            //var pessoa = from p in lPessoa where p.Idade >= 20 && p.Idade <= 30 select p;

            //foreach (var item in pessoa)
            //{
            //    Console.WriteLine(item.ToString());
            //    Console.ReadKey();
            //}

            LPessoa lPessoa = new LPessoa();

            //foreach (var item in lPessoa.Where(p => p.Nome.StartsWith("JONATHAN")))
            foreach (var item in lPessoa.Where(p => p.Nome.EndsWith("SILVA")))
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }
    }
}
