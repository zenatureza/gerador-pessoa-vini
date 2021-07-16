using System;
using Bogus;
using Bogus.Extensions.Brazil;

namespace Gerador_de_pessoa_Vini
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa vini = new()
            {
                cpf = new Faker("pt_BR").Person.Cpf()
            }; 

            Console.WriteLine(vini.cpf);  
        }
    }
}
