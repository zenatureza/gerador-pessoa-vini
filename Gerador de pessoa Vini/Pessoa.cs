using Bogus;
using Bogus.Extensions.Brazil;

namespace GeradorDePessoa
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Perfil { get; set; }

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

        public static Pessoa GerarPessoa()
        {
            return new()
            {
                Cpf = new Faker("pt_BR").Person.Cpf(),
                Nome = new Faker().Person.FullName,
                Email = new Faker().Person.Email,
                Perfil = "Loja Geral"
            };
        }
    }
}