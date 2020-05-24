using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{

    class ControleDePonto
    {
        public static void RegistraEntrada(Funcionario f)
        {
            DateTime agora = DateTime.Now;
            string horario = String.Format(" {0: d/M/ yyyy HH:mm:ss}", agora);
            Console.WriteLine(" ENTRADA : " + f.Codigo);
            Console.WriteLine(" DATA :" + horario);
            f.Entrada = horario;
        }
        public static void RegistraSaida(Funcionario f)
        {
            DateTime agora = DateTime.Now;
            string horario = String.Format(" {0: d/M/ yyyy HH:mm:ss}", agora);
            Console.WriteLine(" SAÍDA : " + f.Codigo);
            Console.WriteLine(" DATA : " + horario);
            f.Saida = horario;
        }
    }

}
