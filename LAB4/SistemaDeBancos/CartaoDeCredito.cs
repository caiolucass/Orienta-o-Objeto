using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeBancos
{
    class CartaoDeCredito
    {
        int numero;
        String dataDeValidade;
        Cliente cliente;
        // Adicione a linha abaixo
        Fatura[] faturas;

        public int Numero { get; set; }

        public string GetDate { get; set; }

        public Cliente Cliente { get; set; }
    }
}
