using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPolimorfismo
{
    public abstract class Eletronico
    {
        public string NomeEletronico { get; set; }
        public string MarcaEletronico { get; set; }
        public double PrecoEletronico { get; set; }
        public string CorEletronico { get; set; }

        public Eletronico(string NomeEletronico, string MarcaEletronico, double PrecoEletronico, string CorEletronico)
        {
            this.NomeEletronico = NomeEletronico;
            this.MarcaEletronico = MarcaEletronico;
            this.PrecoEletronico = PrecoEletronico;
            this.CorEletronico = CorEletronico;
        }

        public abstract bool ligado(bool valor);
    }
}
