using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string escolha;

            /* Calculadora */
            string calculadora;
            int n1, n2, soma, subtracao, multiplicacao, divisao;

            /* Calculo IMC */
            double peso, altura, altura2, imc;

            /* Informar se o número é Par ou Impar */
            int PI;

            /* Média */
            float m1, m2, m3, m4, m5, media;

            /* default */
            string default1;

            default1 = "Opção invalida";
            

            Console.WriteLine("+----------------------------------------+");
            Console.WriteLine("|Selecione a opção desejada              |");
            Console.WriteLine("+----------------------------------------+");
            Console.WriteLine("|C. Calculadora                          |");
            Console.WriteLine("|I. Calculo do IMC                       |");
            Console.WriteLine("|PI. Informar se o número é Par ou Impar |");
            Console.WriteLine("|M. Calcular a Média                     |");
            Console.WriteLine("+----------------------------------------+");
            escolha = Console.ReadLine().ToUpper();

            Console.Clear();

            switch (escolha)
            {
                case "C":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Opção escolhida: Calculadora");
                        Console.ReadLine();
                        Console.ResetColor();

                        Console.Clear();

                        Console.WriteLine("+---------------------------+");
                        Console.WriteLine("|Selecione a opção desejada |");
                        Console.WriteLine("+---------------------------+");
                        Console.WriteLine("|S. Soma                    |");
                        Console.WriteLine("|T. Subtração               |");
                        Console.WriteLine("|M. Multiplicação           |");
                        Console.WriteLine("|D. Divisão                 |");
                        Console.WriteLine("+---------------------------+");
                        calculadora = Console.ReadLine().ToUpper();

                        switch (calculadora)
                        {
                            case "S":
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção escolhida: Soma");
                                    Console.ReadLine();
                                    Console.ResetColor();

                                    Console.Clear();

                                    Console.Write("Coloque o primeiro número: ");
                                    n1 = int.Parse(Console.ReadLine());

                                    Console.Write("Coloque o segundo número: ");
                                    n2 = int.Parse(Console.ReadLine());

                                    Console.Clear();

                                    soma = n1 + n2;

                                    Console.Write($"A soma de {n1} + {n2} é: {soma}");
                                    Console.Read();

                                    break;
                                }

                            case "T":
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção escolhida: Subtração");
                                    Console.ReadLine();
                                    Console.ResetColor();

                                    Console.Clear();

                                    Console.Write("Coloque o primeiro número: ");
                                    n1 = int.Parse(Console.ReadLine());

                                    Console.Write("Coloque o segundo número: ");
                                    n2 = int.Parse(Console.ReadLine());

                                    Console.Clear();

                                    subtracao = n1 - n2;

                                    Console.Write($"A subtração de {n1} - {n2} é: {subtracao}");
                                    Console.Read();

                                    break;
                                }

                            case "M":
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção escolhida: Multiplicação");
                                    Console.ReadLine();
                                    Console.ResetColor();

                                    Console.Clear();

                                    Console.Write("Coloque o primeiro número: ");
                                    n1 = int.Parse(Console.ReadLine());

                                    Console.Write("Coloque o segundo número: ");
                                    n2 = int.Parse(Console.ReadLine());

                                    Console.Clear();

                                    multiplicacao = n1 * n2;

                                    Console.Write($"A Multiplicação de {n1} x {n2} é: {multiplicacao}");
                                    Console.Read();

                                    break;
                                }

                            case "D":
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção escolhida: Divisão");
                                    Console.ReadLine();
                                    Console.ResetColor();

                                    Console.Clear();

                                    Console.Write("Coloque o primeiro número: ");
                                    n1 = int.Parse(Console.ReadLine());

                                    Console.Write("Coloque o segundo número: ");
                                    n2 = int.Parse(Console.ReadLine());

                                    Console.Clear();

                                    divisao = n1 / n2;

                                    Console.Write($"A divisão de {n1} % {n2} é: {divisao}");
                                    Console.Read();

                                    break;
                                }

                            default:
                                {
                                    Console.WriteLine($"{default1}");
                                    Console.Read();

                                    break;
                                }
                        }

                        break;
                    }

                case "I":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Opção escolhida: Calculo do IMC");
                        Console.ReadLine();
                        Console.ResetColor();

                        Console.Clear();

                        Console.Write("Coloque seu peso em Kg: ");
                        peso = double.Parse(Console.ReadLine());

                        Console.Write("Coloque sua altura em M: ");
                        altura = double.Parse(Console.ReadLine());

                        Console.Clear();

                        altura2 = altura * altura;

                        imc = peso / altura2;

                        Console.WriteLine($"Seu IMC é equivalente a: {imc}");
                        Console.Read();

                        break;
                    }

                case "PI":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Opção escolhida: Informar se o número é Par ou Impar");
                        Console.ReadLine();
                        Console.ResetColor();

                        Console.Clear();

                        Console.Write("Coloque o Número desejado: ");
                        PI = int.Parse(Console.ReadLine());

                        if ( PI % 2 == 0 )
                        {
                            Console.WriteLine($"O número {PI} é par");
                            Console.Read();
                        }

                        else
                        {
                            Console.WriteLine($"O número {PI} é Impar");
                            Console.Read();
                        }

                        break;
                    }

                case "M":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Opção escolhida: Calcular a Média");
                        Console.ReadLine();
                        Console.ResetColor();

                        Console.Clear();

                        Console.WriteLine("Insira o primeiro número: ");
                        m1 = float.Parse(Console.ReadLine());

                        Console.WriteLine("Insira o segundo número: ");
                        m2 = float.Parse(Console.ReadLine());

                        Console.WriteLine("Insira o terceiro número: ");
                        m3 = float.Parse(Console.ReadLine());

                        Console.WriteLine("Insira o quarto número: ");
                        m4 = float.Parse(Console.ReadLine());

                        Console.WriteLine("Insira o quinto número: ");
                        m5 = float.Parse(Console.ReadLine());

                        Console.Clear();

                        media = (m1 + m2 + m3 + m4 + m5) / 5;

                        Console.WriteLine($"A sua média com as notas {m1}, {m2}, {m3}, {m4}, {m5} é: {media}");
                        Console.Read();

                        break;
                    }

                default:
                    {
                        Console.WriteLine($"{default1}");
                        Console.Read();

                        break;
                    }
            }
        }
    }
}
