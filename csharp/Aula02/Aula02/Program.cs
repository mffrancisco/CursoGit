using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soma números de 1 a 100, exceto os multiplos de 3
            //int total = 0;
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (!(i % 3 == 0))
            //    {
            //        total += i;
            //    }
            //}
            //Console.WriteLine("O total é de {0}", total);
            //Console.ReadKey();

            //Soma quantas vezes a palavra ana aparece na frase
            //string frase = "ANA E MARIANA GOSTAM DE BANANA";
            //int resultado = 0;
            //string[] frasesplit = frase.Split(' ');

            //for (int i = 0; i < frasesplit.Length; i++)
            //{
            //    if (frasesplit[i].Contains("ANA"))
            //    {
            //        resultado += 1;
            //    }
            //}
            //Console.WriteLine("A palavra ANA aparece na frase {0} vezes", resultado);
            //Console.ReadKey();

            //Decidir qual é o IMC
            float imc, peso, altura;
            Console.WriteLine("Qual o seu peso?");
            //decimal peso = double.Parse(Console.ReadLine());
            peso = float.Parse(Console.ReadLine());//Não precisa instanciar nenhuma classe. Recebe apenas string. É mais rápido
            Console.WriteLine("Qual a sua altura?");
            //var teste = Convert.ToDecimal(Console.ReadLine());
            altura = float.Parse(Console.ReadLine());
            imc = peso / (altura * altura);

            var cortimc = imc.ToString("0.00");
            var cortimcvalor = Math.Round(imc, 2);

            if (imc < 18.5)
            {
                Console.WriteLine("ABAIXO DO PESO");
            }
            else if ((imc >= 18.6) && (imc <= 24.9))
            {
                Console.WriteLine("PESO IDEAL");
            }
            else if ((imc >= 25) && (imc <= 29.9))
            {
                Console.WriteLine("LEVEMENTE ACIMA DO PESO");
            }
            else if ((imc >= 30.0 && imc <= 34.9))
            {
                Console.WriteLine("OBESIDADE GRAU 1");
            }
            else if ((imc >= 35) && (imc <= 39.9))
            {
                Console.WriteLine("OBESIDADE GRAU 2");
            }
            else
                Console.WriteLine("OBESIDADE MORBIDA");
            Console.ReadKey();

            //Calcular 4 Médias passadas por um aluno

        }
    }
}
