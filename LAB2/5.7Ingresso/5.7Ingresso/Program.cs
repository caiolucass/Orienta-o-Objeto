using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ingresso
{
    class Program
    {
        static void Main(string[] args)
        {
            char x='s';
            ingresso ing = new ingresso();
            normal norm = new normal();
            VIP v = new VIP();
            camaroteInf ci = new camaroteInf();
            camaroteSup cs = new camaroteSup();

            while (x != 'n' || x != 'N')
            {
                char op;
                Console.WriteLine("\n\n\tEntre com a opção de ingresso desejada;\n\t1- Normal;\n\t2- VIP.");
                op = char.Parse(Console.ReadLine());
                switch (op)
                {
                    case '1':
                        Console.Clear();
                        ing.imprimeValor();
                        Console.ReadKey();
                        break;

                    case '2':
                        Console.WriteLine("\n\n\tEntre com a opção de ingresso VIP desejada;\n\t1- Inferior;\n\t2-  Superior.");
                        op = char.Parse(Console.ReadLine());
                        switch (op)
                        {
                            case '1':
                                Console.Clear();
                                Console.WriteLine(v.adcionalVip);
                                Console.WriteLine(ci.Local);
                                break;
                            case '2':
                                Console.Clear();
                                Console.WriteLine(cs.Adcional);
                                break;
                            default: Console.WriteLine("\n\n\t[ERROR]- Opção Inválida"); break;

                        }
                        Console.ReadKey();
                        break;
                    default: Console.WriteLine("\n\n\t[ERROR]- Opção Inválida"); break;
                }
                Console.WriteLine("\n\n\tDeseja realizar a compra de outro ingresso?\n[s] Para nova compra\n[n] Para finalizar.");
                x = char.Parse(Console.ReadLine());
                Console.Clear();
            }  
        }
    }
}
