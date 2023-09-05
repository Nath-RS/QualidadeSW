using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace triangulo
{
    public class program
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

        public static bool numValido(string entrada, double guardar)
        {
            if (double.TryParse(entrada, out double d))
            {
                guardar = double.Parse(entrada, CultureInfo.InvariantCulture);
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            double[] lado = new double[3];
            string entrada;
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    while (true)
                    {
                        Console.WriteLine("Digite o valor do " + (i + 1) + "° lado: \n");
                        entrada = Console.ReadLine();

                        if (!String.IsNullOrEmpty(entrada) && numValido(entrada, lado[i]))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("valor válido!");
                        }
                    }
                }
                Console.WriteLine(tipoTriangulo(lado[0], lado[1], lado[2]));
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}
