using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Nome = "Juliana";
            p.Contato.Celular = "988287635";
            p.DataNasc.Dia = 22;
            p.DataNasc.Mes = 11;
            p.DataNasc.Ano = 1996;
            p.Endereco.Cidade = "Belo Horizonte";
            p.Endereco.Bairro = "Floresta";
            p.Endereco.Cep = "35796364";
            p.Endereco.Logradouro = "Santo Antonio";
            p.Endereco.Numero = 90;
            p.Endereco.Estado = "MG";
        }
    }
}
