using System;
using Bogus;
using Bogus.Extensions.Brazil;

namespace GeradorDePessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa vini = Pessoa.GerarPessoa();

            Console.WriteLine(vini.Cpf);
            Console.WriteLine(vini.Nome);
            Console.WriteLine(vini.Email);
            Console.WriteLine(vini.Perfil);
        }
    }
}
