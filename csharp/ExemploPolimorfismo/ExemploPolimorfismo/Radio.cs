using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPolimorfismo
{
    public class Radio : Eletronico
    {
        public double Watts { get; set; }

        public Radio(string NomeEletronico, string MarcaEletronico, double PrecoEletronico, string CorEletronico, int Watts) 
            : base(NomeEletronico, MarcaEletronico, PrecoEletronico, CorEletronico)

        {
            this.Watts = Watts;

        }

        public override bool ligado(bool valor)
        {
            if (valor == true){
                Console.WriteLine("Radio Ligado Pelo Botão");
            }
            else
            {
                Console.WriteLine("Radio Desligado");
            }

            return valor;

        }
    }
}
