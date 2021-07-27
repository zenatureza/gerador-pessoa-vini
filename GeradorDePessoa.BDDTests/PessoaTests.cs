using System;
using System.Linq;
using System.Text.RegularExpressions;
using Xunit;

namespace GeradorDePessoa.BDDTests
{
    public class PessoaTests
    {
        [Fact]
        public void DeveGerarPessoa_ComCpfValido()
        {
            // Arrange
            // Act
            var pessoa = Pessoa.GerarPessoa();

            // Assert
            var cpfPessoaSemPontuacao = Regex.Replace(
                pessoa.Cpf, 
                "[^0-9a-zA-Z]+", 
                "");

            Assert.True(cpfPessoaSemPontuacao.All(char.IsDigit));
            Assert.Equal(11, cpfPessoaSemPontuacao.Length);
        }
    }
}
