using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_pessoa_Vini
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        // Construtor serve pra criar um objeto de uma classe.
        // Exemplo: Pesoa Vini = new ();

        // Construtor que recebe parâmetros
        public Pessoa(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        // Construtor sem parâmetros
        public Pessoa()
        {

        }
    }
}