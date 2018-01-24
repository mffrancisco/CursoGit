using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cidade { get; set; }
        public string Sexo { get; set; }

        public Pessoa(string nome, int idade, string cidade, string sexo)
        {
            Nome = nome;
            Idade = idade;
            Cidade = cidade;
            Sexo = sexo;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + " Idade: " + Idade + " Cidade: " + Cidade + " Sexo: " + Sexo;
        }
    }

    class LPessoa :List<Pessoa>
    {
        public LPessoa()
        {
            this.Add(new Pessoa("JOSÉ SILVA", 21, "PIRACICABA", "M"));
            this.Add(new Pessoa("ADRIANA GOMES", 18, "CURITIBA", "F"));
            this.Add(new Pessoa("JOSÉ NOVAES", 17, "CAMPINAS", "M"));
            this.Add(new Pessoa("ANDRÉ NEVES", 50, "PIRACICABA", "M"));
            this.Add(new Pessoa("JONATHAN SANTOS", 45, "CAMPINAS", "M"));
            this.Add(new Pessoa("IVANILDA RIBEIRO", 29, "AMERICANA", "F"));
            this.Add(new Pessoa("BRUNA STEVAN", 28, "AMERICANA", "M"));
            this.Add(new Pessoa("ANDREIA MARTINS", 22, "RIO DE JANEIRO", "F"));
            this.Add(new Pessoa("ANTONIO DA SILVA", 30, "POÇOS DE CALDAS", "M"));
        }
        
    }


}
