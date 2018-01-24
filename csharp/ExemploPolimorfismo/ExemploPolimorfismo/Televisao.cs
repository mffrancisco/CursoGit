using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPolimorfismo
{
    public class Televisao : Eletronico
    {
        public int Polegadas { get; set; }

        public Televisao(string NomeEletronico, string MarcaEletronico, double PrecoEletronico, string CorEletronico, int Polegadas) 
            : base(NomeEletronico, MarcaEletronico, PrecoEletronico, CorEletronico)
        {
            this.Polegadas = Polegadas;
        }

        public override bool ligado(bool valor)
        {
            if (valor == true)
            {
                Console.WriteLine("Televisão Ligada Pelo Controle!");
            }
            else
            {
                Console.WriteLine("Televisão Desligada!");
            }

            return valor;
            
        }
    }
}
