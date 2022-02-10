using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Desafios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PrimeiroMultiplicador = 10;
            int SegundoMultiplicador = 11;
            int PrimeiroSomador = 0;
            int SegundoSomador = 0;

            int n1, valor, PrimeiroDigito, CalculoPrimeiroDigitoValidador;
            int SegundoDigito, CalculoSegundoDigitoValidador;

            string P, S;
            int PD, SD;  //PD = Primeiro Digito convertido para int / SD = Segundo Digito convertido para int. 

            string padrão = "[0-9]{9}[0-9]{2}";

            Console.Write("Digite o CPF completo sem pontos e hífen: ");
            var CPF = (Console.ReadLine());
            var resultado = Regex.Match(CPF, padrão);
            //Console.WriteLine(resultado);

            string inválido0 = "[0]{11}";
            string inválido1 = "[1]{11}";
            string inválido2 = "[2]{11}";
            string inválido3 = "[3]{11}";
            string inválido4 = "[4]{11}";
            string inválido5 = "[5]{11}";
            string inválido6 = "[6]{11}";
            string inválido7 = "[7]{11}";
            string inválido8 = "[8]{11}";
            string inválido9 = "[9]{11}";


            var U0 = Regex.Match(CPF, inválido0);
            if (U0.Success)
            {
            }
            var U1 = Regex.Match(CPF, inválido1);
            if (U1.Success)
            {
                Console.WriteLine("CPF Válido, porém não pode ser utilizado");
                Console.WriteLine("Tecle enter para finalizar");
                Console.Read();
                return;
            }
            var U2 = Regex.Match(CPF, inválido2);
            if (U2.Success)
            {
                Console.WriteLine("CPF Válido, porém não pode ser utilizado");
                Console.WriteLine("Tecle enter para finalizar");
                Console.Read();
                return;
            }
            var U3 = Regex.Match(CPF, inválido3);
            if (U3.Success)
            {
                Console.WriteLine("CPF Válido, porém não pode ser utilizado");
                Console.WriteLine("Tecle enter para finalizar");
                Console.Read();
                return;
            }
            var U4 = Regex.Match(CPF, inválido4);
            if (U4.Success)
            {
                Console.WriteLine("CPF Válido, porém não pode ser utilizado");
                Console.WriteLine("Tecle enter para finalizar");
                Console.Read();
                return;
            }
            var U5 = Regex.Match(CPF, inválido5);
            if (U5.Success)
            {
                Console.WriteLine("CPF Válido, porém não pode ser utilizado");
                Console.WriteLine("Tecle enter para finalizar");
                Console.Read();
                return;
            }
            var U6 = Regex.Match(CPF, inválido6);
            if (U6.Success)
            {
                Console.WriteLine("CPF Válido, porém não pode ser utilizado");
                Console.WriteLine("Tecle enter para finalizar");
                Console.Read();
                return;
            }
            var U7 = Regex.Match(CPF, inválido7);
            if (U7.Success)
            {
                Console.WriteLine("CPF Válido, porém não pode ser utilizado");
                Console.WriteLine("Tecle enter para finalizar");
                Console.Read();
                return;
            }
            var U8 = Regex.Match(CPF, inválido8);
            if (U8.Success)
            {
                Console.WriteLine("CPF Válido, porém não pode ser utilizado");
                Console.WriteLine("Tecle enter para finalizar");
                Console.Read();
                return;
            }
            var U9 = Regex.Match(CPF, inválido9);
            if (U9.Success)
            {
                Console.WriteLine("CPF Válido, porém não pode ser utilizado");
                Console.WriteLine("Tecle enter para finalizar");
                Console.Read();
                return;
            }


            try
            {
                if (!resultado.Success)
                {
                    Console.WriteLine("Número inserido está incorreto");
                }

                for (int i = 0; i < 9; i++)
                {
                
                    string numero = CPF.Substring(i, 1);
                    n1 = int.Parse(numero);
                    
                    valor = PrimeiroMultiplicador * n1;
                    
                    PrimeiroMultiplicador--;
                    PrimeiroSomador += valor;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("CPF digitado incorretamente");
                Console.WriteLine("Tecle enter para sair");
                Console.Read();
                return;
            }

            CalculoPrimeiroDigitoValidador = PrimeiroSomador % 11;
            PrimeiroDigito = 11 - CalculoPrimeiroDigitoValidador;

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    string numero = CPF.Substring(i, 1);
                    n1 = int.Parse(numero);
                    valor = SegundoMultiplicador * n1;

                    SegundoMultiplicador--;

                    SegundoSomador += valor;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("CPF digitado incorretamente");
                Console.WriteLine("Tecle enter para finalizar");
                Console.Read();
                return;
            }

            CalculoSegundoDigitoValidador = SegundoSomador % 11;
            SegundoDigito = 11 - CalculoSegundoDigitoValidador;

            if (SegundoDigito >= 10)
            {
                SegundoDigito = 0;
            }

            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    P = CPF.Substring(9, 1);
                    PD = int.Parse(P);

                    S = CPF.Substring(10, 1);
                    SD = int.Parse(S);

                    if (PrimeiroDigito != PD)
                    {
                        Console.WriteLine("CPF: " + resultado + " inválido");
                        Console.Read();
                    }
                    else if (SegundoDigito != SD)
                    {
                        Console.WriteLine("CPF: " + resultado + " inválido");
                        Console.Read();
                    }
                    else
                    {
                        Console.WriteLine("CPF: " + resultado + " Válido");
                        Console.Read();
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("CPF digitado incorretamente");
                Console.WriteLine("Tecle enter para finalizar");
                Console.Read();
                return;
            }
                Console.ReadLine();
        }
    }
}

