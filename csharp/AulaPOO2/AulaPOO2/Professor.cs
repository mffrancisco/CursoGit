using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO2
{
    public class Professor : Usuario
    {
        public double salarioProfessor { get; set; }

        public Professor(int idProfessor, string nomeProfessor, string sobrenomeProfessor, int idadeProfessor, double salarioProfessor)
        {
            idUsuario = idProfessor;
            nomeUsuario = nomeProfessor;
            sobrenomeUsuario = sobrenomeProfessor;
            idadeUsuario = idadeProfessor;
            this.salarioProfessor = salarioProfessor;
        }


        public new virtual void mostrarDados()
        {
            base.mostrarDados();
            Console.WriteLine("Salario do Professor: {0}", salarioProfessor);

        }
        

    }
}
