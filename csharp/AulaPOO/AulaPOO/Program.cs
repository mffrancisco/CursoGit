using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Carro c1 = new Carro();

            Console.WriteLine("Digite o Nome do Carro: ");
            c1.Nome = Console.ReadLine();

            Console.WriteLine("Digite a Marca do Carro: ");
            c1.Marca = Console.ReadLine();

            Console.WriteLine("Digite a Cor do Carro: ");
            c1.Cor = Console.ReadLine();

            Console.WriteLine("Digite a Placa do Carro: ");
            c1.Placa = Console.ReadLine();

            Console.WriteLine("Digite o Ano do Carro: ");
            c1.Ano = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\n");

            c1.MostraAtributos();

            Console.ReadKey();


            /* Criar objeto sem o Construtor
             * 
             * Carro c1 = new Carro();

            c1.nome = "del rey";
            c1.marca = "ford";
            c1.cor = "bordô";
            c1.placa = "jjd-2689";
            c1.ano = 1989;

            carro c2 = new carro();

            c2.nome = "civic";
            c2.marca = "honda";
            c2.cor = "preto";
            c2.placa = "bbc-2208";
            c2.ano = 2010;
            
            EXIBINDO OS ATRIBUTOS DO OBJETO SEM O METODO MostraAtributos;
            Console.WriteLine("Nome do Carro: {0}", c1.Nome);
            Console.WriteLine("Marca do Carro: {0}", c1.Marca);
            Console.WriteLine("Cor do Carro: {0}", c1.cor);
            Console.WriteLine("Placa do Carro: {0}", c1.Placa);
            Console.WriteLine("Ano do Carro: {0}", c1.Ano);
             */

            /* INSTANCIANDO OBJETO COM O MÉTODO CONSTRUTOR.
             * Carro c1 = new Carro("Del Rey", "Ford", "Bordô", "JJD-2689", 1989);
             * Carro c2 = new Carro("Civic", "Honda", "Preto", "BBC-2208", 2010);

            EXIBINDO ATRIBUTOS COM O MÉTODO MostraAtributos()
            Console.WriteLine("\n\n");
            c1.MostraAtributos();

            Console.WriteLine("\n\n");
            c1.Andar();

            Console.WriteLine("\n\n");
            c1.Ligado(true);

            Console.WriteLine("\n\n");
            c1.Combustao(true);

            Console.WriteLine("\n\n");
            c2.MostraAtributos();

            Console.WriteLine("\n\n");
            c2.Andar();

            Console.WriteLine("\n\n");
            c2.Ligado(true);

            Console.WriteLine("\n\n");
            c2.Combustao(true);

            Console.ReadKey(); */


        }
    }
}
