using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date5
{
    class Calendario
    {
            int dia, mes, ano;

            string[] meses = { "janeiro", "fevereiro", "março", "abril", "maio", "junho",
                    "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };
            public Calendario(int d, int m, int a)//construtor com parametro
            {
                if (d > 0 && d <= 31)
                {
                    dia = d;
                }
                if (m > 1 && m <= 12)
                {
                    mes = m;
                }
                if (a > 1900)
                {
                    ano = a;
                }
            }//fim Date5

            public Calendario() //construtor sem parametro
            {
                dia = 20;
                mes = 09;
                ano = 2000;
            }


            public int Dia//metodo dia
            {
                get { return dia; }
                set { dia = value; }
            }
            public int Mes//metodo mes
            {
                get { return mes; }
                set { mes = value; }
            }//fim mes

            public int Ano//metodo ano
            {
                get { return ano; }
                set { ano = value; }
            }//fim ano

            public static bool anoBissexto(int a)//metodo para verificar se o ano é bissexto
            {
                if (a % 4 == 0) return true;
                else if (a % 100 != 0) return false;
                else if (a % 400 != 0) return false;
                else return true;
            }//fim bissexto

            public string Data() //metodo para retonar a data com string
            {
                return Convert.ToString(dia + " de " + meses[mes] + " de " + ano);
            }//fim data

            public string proximoDia(int dd, int mm, int aa)//metodo pata verificar o proximo dia
            {

                if (dd == 31 && mm == 12)//se o dia for 31 de dezembro aumenta o ano
                {
                    aa++;
                    dd = 1;
                    mm = 1;
                }
                else if (dd == 30 && (mm == 4 ||   //se o dia for igual 30 e o mes so tem 30 dias,pula para o proximo mes
                     mm == 6 || mm == 9 || mm == 11))
                {
                    mm++;
                    dd = 1;
                }
                else if (mm >= 1 && mm <= 11 && dd == 31)//se o mes tiver 31 dias aumenta mais um dia
                {
                    dd++;
                    mm++;
                }
                else if (dd == 28 && mm == 2)// se o ano for bissexto 
                {
                    if (anoBissexto(aa)) dd++;
                    else
                    {
                        mm++;
                        dd = 1;
                    }
                }

                return Convert.ToString(dd + " de " + mm + " de " + aa);
            }

            public static int DataAno(int dia, int mes, int ano)//verificar a data exata no ano
            {
                int i;
                int[] vetor = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                int datadoAno = 0;

                if (mes == 1)
                {
                    return (dia);
                }
                else
                {
                    for (i = 0; i < mes - 1; i++)
                    {
                        datadoAno += vetor[i];
                    }
                    if (anoBissexto(ano) && dia > 28)
                    {
                        dia++;
                    }
                }

                return (datadoAno + dia);
            }

            public int diferencaDias(string[] vetor1, string[] vetor2)//mostrar a diferença entras as datas
            {

                int dia1 = int.Parse(vetor1[0]);
                int mes1 = int.Parse(vetor1[1]);
                int ano1 = int.Parse(vetor1[2]);

                int dia2 = int.Parse(vetor2[0]);
                int mes2 = int.Parse(vetor2[1]);
                int ano2 = int.Parse(vetor2[2]);

                int Data1 = DataAno(dia1, mes1, ano1);//primeiraData
                int Data2 = DataAno(dia2, mes2, ano2);//segundaData

                int SomaDatas = 0;//calculo de diferença entre as datas de anos diferentes

                if (ano1 == ano2)//verificar se os anos sao iguais
                {

                    return DataAno(dia1, mes1, ano1) - DataAno(dia2, mes2, ano2);

                    if (Data1 > Data2)//comparar as datas se os anos forem iguais
                    {
                        return Data1 - Data2;
                    }
                    else if (Data1 == Data2)
                    {
                        return dia1 - dia2;
                    }
                    else
                    {
                        return Data2 - Data1;
                    }
                }//fim if

                else if (ano1 < ano2)
                {
                    int cont;
                    SomaDatas += dia2;

                    for (cont = ano1 + 1; cont < ano2; cont++)
                    {
                        SomaDatas += 365;

                        if ((anoBissexto(cont)))//verificar se o ano é bissexto,caso seja adicione mais um dia
                        {
                            SomaDatas++;
                        }//fim 
                    }//fim for
                    SomaDatas += 365 - dia1;
                }//fim

                else if (ano1 > ano2)//verificar se o ano1 é maior que o ano dois
                {
                    int cont;
                    SomaDatas += dia1;

                    for (cont = ano2 + 1; cont < ano2; cont++)
                    {
                        SomaDatas += 365;

                        if ((anoBissexto(cont)))//verificar se o ano é bissexto,caso seja adicione mais um dia
                        {
                            SomaDatas++;
                        }//fim

                        SomaDatas += 365 - dia2;
                    }//fim for

                }//fim 
                return SomaDatas;
            }
        }
    }

