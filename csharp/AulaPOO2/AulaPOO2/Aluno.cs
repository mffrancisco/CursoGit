using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO2
{
    public class Aluno : Usuario
    {
        //Atributos
        public double notaAluno { get; set; }

        public Aluno(int idAluno, string nomeAluno, string sobrenomeAluno, int idadeAluno, double notaAluno)
        {
            idUsuario = idAluno;
            nomeUsuario = nomeAluno;
            sobrenomeUsuario = sobrenomeAluno;
            idadeUsuario = idadeAluno;
            this.notaAluno = notaAluno;
        }


        //Metodos
        public new virtual void mostrarDados()
        {
            base.mostrarDados();
            Console.WriteLine("Nota do Aluno: {0}", notaAluno);
        }
    }
}
