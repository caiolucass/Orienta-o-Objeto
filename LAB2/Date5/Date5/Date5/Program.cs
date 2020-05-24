//
//Nome do programa:Date5
//programador(es):Caio Lucas(604365),Wernen Rodrigues(597704),Bernardo Martinez(613081),Cleber Magela(636964)
//Data:22/03/2019
//Entrada:sem entrada pela linha de comando(LC)
//saida(s):mostra se a data digitada é um ano bissexto ou nao,
//saidas(s):calcula e imprimi a diferença de dias em duas datas distintas
//saida(s):imprimi o a posicao do dia no ano
//saida(s):printa as datas por extenso
//descrição:digite duas datas distintas para que o programa faça das devidas operaçoes


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date5
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.clear();
			Console.WriteLine("Caio Lucas(604365),Wernen Rodrigues(597704),Bernardo Martinez(613081),Cleber Magela(636964)");
            string Data = "";
            Calendario d1 = new Calendario();
            Calendario d2 = new Calendario();

            Console.WriteLine("Exercicio Date5.");
            Console.WriteLine("Primeira data:");
            string[] info1 = Console.ReadLine().Split('/');
            d1.Dia = int.Parse(info1[0]);
            d1.Mes = int.Parse(info1[1]);
            d1.Ano = int.Parse(info1[2]);
            if (Calendario.anoBissexto(d1.Ano))
            {
                Console.WriteLine("Ano bissexto!");
            }
            else Console.WriteLine("Ano não bissexto!");

            Console.WriteLine("O dia da data do ano e:" + d1.Data());
           
        
            Console.WriteLine("Seguda data:");
            string [] info2 = Console.ReadLine().Split('/');
            d2.Dia = int.Parse(info2[0]);
            d2.Mes = int.Parse(info2[1]);
            d2.Ano = int.Parse(info2[2]);
            if (Calendario.anoBissexto(d2.Ano)) 
            {
                Console.WriteLine("Ano bissexto!");
            }
            else Console.WriteLine("Ano nao bissexto!");

            Console.WriteLine("O dia da data do ano e:" + d2.Data());

            Console.WriteLine("A diferença entre as datas é de:" + d1.diferencaDias(info1,info2));

            Console.WriteLine("Fim do program Date5.");
            Console.WriteLine("Aperte qualquer tecla para sair do programa.");
            Console.ReadKey();
        }
    }
}
