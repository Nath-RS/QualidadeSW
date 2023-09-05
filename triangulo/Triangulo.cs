using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulo
{
    public class Triangulo
    {
        public Triangulo() { }
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

    }
}
