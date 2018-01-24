using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO
{
    public class Carro
    {
        public string Nome { get; set; }

        public string Marca { get; set; }

        public string Cor { get; set; }

        public string Placa { get; set; }

        public int Ano { get; set; }

        //Construtor com os Atributos
        public Carro(string Nome, string Marca, string Cor, string Placa, int Ano)
        {
            this.Nome = Nome;
            this.Marca = Marca;
            this.Cor = Cor;
            this.Placa = Placa;
            this.Ano = Ano;
        }

        //Construtor Vazio
        public Carro()
        {

        }

        public void Andar()
        {
            Console.WriteLine("Andando... VRUUUM!");
        }

        public bool Ligado(bool valor)
        {
            if(valor == true)
            {
                Console.WriteLine("Ligado");
            }
            else
            {
                Console.WriteLine("Desligado");
            }

            return valor;
        }

        public bool Combustao(bool valor)
        {
            if (valor == true)
            {
                Console.WriteLine("Fazendo Combustão");
            }
            else
            {
                Console.WriteLine("Não Fazendo Combustão");
            }

            return valor;
        }

        public void MostraAtributos()
        {
            Console.WriteLine("Nome do Carro: {0}", Nome);
            Console.WriteLine("Marca do Carro: {0}", Marca);
            Console.WriteLine("Cor do Carro: {0}", Cor);
            Console.WriteLine("Placa do Carro: {0}", Placa);
            Console.WriteLine("Ano do Carro: {0}", Ano);
        }

        
    }
}
