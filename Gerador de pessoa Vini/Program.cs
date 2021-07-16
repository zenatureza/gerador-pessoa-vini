using System;
using Bogus;
using Bogus.Extensions.Brazil;

namespace Gerador_de_pessoa_Vini
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa vini = new Pessoa(); // (vini) é uma variavel (Pessoa) é o tipo do dado
            //vini.cpf = "40210741805";
            //vini.cpf = CpfUtils.GerarCpf(); // (essa linha esta trazendo a geração não utilizando o Bogus)
           
            vini.cpf = new Bogus.Faker("pt_BR").Person.Cpf();

            Console.WriteLine(vini.cpf);  
        }
    }
}
