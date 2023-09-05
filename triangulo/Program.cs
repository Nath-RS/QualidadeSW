using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace triangulo
{
    internal class Program
    {
        public static bool ehTriangulo(double L1, double L2, double L3)
        {
            if ((L1 + L2 > L3) && (L1 + L3 > L2) && (L2 + L3 > L1))
            {
                return true; // e possivel formar um triangulo
            }
            else
            {
                return false; // Nao e possivel formar um triangulo
            }
        }

        public static string tipoTriangulo(double lado1, double lado2, double lado3)
        {
            if (ehTriangulo(lado1, lado2, lado3))
            {
                if (lado1 == lado2 && lado2 == lado3)
                {
                    return "O triangulo e do tipo: Equilatero";
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    return "O triangulo e do tipo: Isosceles";
                }
                else
                {
                    return "O triangulo e do tipo: Escaleno";
                }
            }
            else
            {
                return "Nao e Triangulo";
            }
        }

        static void Main(string[] args)
        {
            double lado1, lado2, lado3;
            string entrada;
            try
            {
                // Solicitar ao usuario os tres lados do triangulo
                while (true)
                {
                    Console.WriteLine("Digite o valor do primeiro lado: \n");
                    entrada = Console.ReadLine();

                    if (double.TryParse(entrada,out double d))
                    {
                        lado1 = double.Parse(entrada,CultureInfo.InvariantCulture);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Digite um numero válido!");
                    }
                }

                while (true)
                {
                    Console.WriteLine("Digite o valor do segundo lado: \n");
                    entrada = Console.ReadLine();

                    if (double.TryParse(entrada, out double d))
                    {
                        lado2 = double.Parse(entrada, CultureInfo.InvariantCulture);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Digite um numero válido!");
                    }
                }

                while (true)
                {
                    Console.WriteLine("Digite o valor do terceiro lado: \n");
                    entrada = Console.ReadLine();

                    if (double.TryParse(entrada, out double d))
                    {
                        lado3 = double.Parse(entrada, CultureInfo.InvariantCulture);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Digite um numero válido!");
                    }
                }

                // Chamar a funcao para determinar o tipo de triangulo e imprimir o resultado
                Console.WriteLine(tipoTriangulo(lado1, lado2, lado3));
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message.ToString());
            }
        }
    }
}
