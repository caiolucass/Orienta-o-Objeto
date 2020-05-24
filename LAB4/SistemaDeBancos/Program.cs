                                                                                                                                  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeBancos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wernen,Caio,Bernado");
            // Criar alguns objetos
            Cliente cliente = new Cliente();
            CartaoDeCredito cdc = new CartaoDeCredito();
            // Carregar alguns dados
            cliente.Nome = "José da Silva";
            cdc.Numero = 111111;
            // Ligar os objetos (liga o objeto CartãodeCredito cdc ao objeto Cliente c)
            cdc.Cliente = cliente;

            // Criar alguns objetos
            Agencia a = new Agencia();
            
            Conta conta = new Conta();
            // Carregar alguns dados
            a.Numero = 178;
            conta.Saldo = 1000.0;
            // Ligar os objetos (liga o objeto Conta c ao objeto Agencia a)
            conta.Agencia = a;

            conta.deposita(1000);
            conta.imprimeExtrato();
            conta.saca(100);
            conta.imprimeExtrato();

            Fatura f = new Fatura();
            f.adiciona(100);
            f.adiciona(200);
            f.imprimeDados();
            double multa = f.calculaMulta();
        }
    }
}
