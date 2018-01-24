using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numero = Soma(1, 9);
            //int numero = Subtracao(9, 1);
            //int numero = Multiplicacao(5, 5);
            //int numero = Divisao(10, 2);


            Console.Write("1º Numero: ");
            var numero1 = int.Parse(Console.ReadLine());
            Console.Write("Escolha a Operação:");
            var op = Console.ReadLine();
            Console.Write("2º Numero: ");
            var numero2 = int.Parse(Console.ReadLine());

            switch (op)
            {
                case "+":
                   Console.WriteLine(Soma(numero1, numero2));
                    break;

                case "-":
                    Console.WriteLine(Subtracao(numero1, numero2));
                    break;

                case "*":
                    Console.WriteLine(Multiplicacao(numero1, numero2));
                    break;

                case "/":
                    Console.WriteLine(Divisao(numero1, numero2));
                    break; 

            }

            
            //Console.WriteLine(numero);
            Console.ReadKey();
        }

        public static int Soma(int numero1, int numero2)
        {
            int soma = numero1 + numero2;
            return soma;
        }

        public static int Subtracao(int numero1, int numero2)
        {
            int subtracao = numero1 - numero2;
            return subtracao;
        }

        public static int Multiplicacao(int numero1, int numero2)
        {
            int multiplicacao = numero1 * numero2;
            return multiplicacao;
        }

        public static int Divisao(int numero1, int numero2)
        {
            int divisao = numero1 / numero2;
            return divisao;
        }
    }
}
