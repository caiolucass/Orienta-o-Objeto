using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV
{
    class Program
    {
        static public void Tela(TV tv1)
        {
            Console.Clear();
            Console.WriteLine("\n\n");
            if (tv1.Ligada)
            {
                Console.WriteLine("TV DESLIGADA ");
                Console.WriteLine("Canal  = {0:00} ", tv1.Canal);
                Console.WriteLine("Volume =" + tv1.Vol);
            }
            else
            {
                Console.WriteLine("TV DESLIGADA ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            TV tv1 = new TV();
            Tela(tv1);
            char opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("\nOpcoes: ");
                Console.WriteLine("Canal: - e +");
                Console.WriteLine("Volume: < e > ");
                Console.WriteLine("Power: P");
                Console.WriteLine("Sair: X");
                Console.WriteLine();
                opcao = Console.ReadKey().KeyChar;
                switch (opcao)
                {
                    case '+':
                        tv1.sCanal();
                        Console.WriteLine("\aCanal: "+tv1.Canal);
                        Console.ReadKey();
                        break;
                    case '-':
                        tv1.bCanal();
                        Console.WriteLine("\aCanal: " + tv1.Canal);
                        Console.ReadKey();
                        break;
                    case '>':
                        tv1.sVol();
                        Console.WriteLine("\aVolume: " + tv1.Vol);
                        Console.ReadKey();
                        break;
                    case '<':
                        tv1.bVol();
                        Console.WriteLine("\aVolume: "+tv1.Vol);
                        Console.ReadKey();
                        break;
                    case 'P':
                    case 'p':
                        tv1.Power();
                        break;
                }
            } while (opcao.ToString().ToUpper() != "X");
        }
    }
}
