using System;
using Bogus;
using Bogus.Extensions.Brazil;

namespace Gerador_de_pessoa_Vini
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa vini = new Pessoa()
            {
                Cpf = new Faker("pt_BR").Person.Cpf(),
                Nome = new Faker().Person.FullName,
                Email = new Faker().Person.Email,
                Perfil = "Loja Geral"

            };

            Console.WriteLine(vini.Cpf);
            Console.WriteLine(vini.Nome);
            Console.WriteLine(vini.Email);
            Console.WriteLine(vini.Perfil);
        }
    }
}
