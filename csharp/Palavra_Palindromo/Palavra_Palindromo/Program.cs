using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palavra_Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o palindromo: ");
            string legal = Console.ReadLine();

            string removeAcentos = removeAcentos(legal);

            string reverseText = string.Join("", removeAcentos.ToLower().Reverse());

            var replace = removeAcentos.ToLower().Replace(" ", "");
            var replace2 = reverseText.Replace(" ", "");

            Console.WriteLine(replace == replace2 ? "Essa frase é um palindromo" : "Essa frase não é um palindromo");

            Console.ReadKey();

            //Inverte palavra com vetor
            //string frase = "ARARA";

            //var chars = frase.ToCharArray();

            //int[] inverte = new int[chars.Length];
            //int aux = 0;

            //for (int i = chars.Length; i > 0; i--)
            //{
            //    inverte[aux] = chars[i];
            //    aux = aux + 1;
            //}

            //Console.ReadKey();
        }
    }
}
