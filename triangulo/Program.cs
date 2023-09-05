using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace triangulo
{
    internal class program
    {
       
        static void Main(string[] args)
        {
            double[] lado = new double[3];
            string entrada;
            try
            {

                for (int i = 0; i < lado.Length; i++)
                {
                    while (true)
                    {
                        Console.WriteLine("Digite o valor do" + i + "° lado: \n");
                        entrada = Console.ReadLine();

                        if (double.TryParse(entrada, out double d))
                        {
                            lado[i] = double.Parse(entrada, CultureInfo.InvariantCulture);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Digite um numero válido!");
                        }
                    }
                }
                Console.WriteLine(Triangulo.tipoTriangulo(lado[0], lado[1], lado[2]));
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}
