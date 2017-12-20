using CalcSQL.Operacoes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CalcSQL
{
    class Program
    {
        enum Opcoes
        {
            Soma,
            Subtração,
            Divisão,
            Multiplicação,
            Potenciação,
            Radiciação,
            Fatoração,
            Sair,
        }
        static void Main(string[] args)
        {
            var r = String.Format("{0}", int.MaxValue);
            SQL sql = new SQL();
            do
            {
                if (sql.Teste())
                {
                    try
                    {
                        Console.Title = "Calculadora com SQL";
                        Console.SetWindowSize(50, 12);
                        Console.SetBufferSize(50, 12);
                        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                        Console.WriteLine("Calculadora com SQL by: FQA\n");
                        int op = 1;
                        foreach (var i in Enum.GetValues(typeof(Opcoes)))
                        {
                            Console.WriteLine(String.Format("{0}) {1}", op++, i));
                        }
                        Console.Write("\nEscolha uma opção: ");
                        r = Console.ReadLine();
                        Console.Clear();
                        switch (r)
                        {
                            case "1":
                                {
                                    Soma soma = new Soma();
                                    soma.Somar();
                                    break;
                                }
                            case "2":
                                {
                                    Subtracao sub = new Subtracao();
                                    sub.Subtrair();
                                    break;
                                }
                            case "3":
                                {
                                    Divisao div = new Divisao();
                                    div.Dividir();
                                    break;
                                }
                            case "4":
                                {
                                    Multiplicacao mult = new Multiplicacao();
                                    mult.Multiplicar();
                                    break;
                                }
                            case "5":
                                {
                                    Potenciacao pot = new Potenciacao();
                                    pot.Potencializar();
                                    break;
                                }
                            case "6":
                                {
                                    Radiciacao rad = new Radiciacao();
                                    rad.Radiciar();
                                    break;
                                }
                            case "7":
                                {
                                    Fatoracao fat = new Fatoracao();
                                    fat.Fatorar();
                                    break;
                                }
                            case "8":
                                {
                                    Console.WriteLine("Saindo...");
                                    break;
                                }
                            default:
                                {
                                    break;
                                }
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        if (r != "8")
                        {
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                }
                else
                {
                    Console.Write("Não tem insert");
                    break;
                }
            }
            while (r != "8");
        }
    }
}
