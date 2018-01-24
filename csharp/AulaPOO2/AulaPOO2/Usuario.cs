using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO2
{
    public abstract class Usuario
    {
        //Atributos
        public int idUsuario { get; set; }
        public string nomeUsuario { get; set; }
        public string sobrenomeUsuario { get; set; }
        public int idadeUsuario { get; set; }

        public Usuario()
        {
            
        }
        //Método
        protected void mostrarDados()
        {
            Console.WriteLine("ID do Usuário: {0}", idUsuario);
            Console.WriteLine("Nome do Usuário: {0}", nomeUsuario);
            Console.WriteLine("Sobrenome do Usuário: {0}", sobrenomeUsuario);
            Console.WriteLine("Idade do Usuário: {0}", idadeUsuario);
        }
    }
}
