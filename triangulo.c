/******************************************************************************

                            Online C Compiler.
                Code, Compile, Run and Debug C program online.
Write your code in this editor and press "Run" button to compile and execute it.

*******************************************************************************/

#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

// Fun��o para verificar se � poss�vel formar um tri�ngulo
bool ehTriangulo(double lado1, double lado2, double lado3) {
    if ((lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1)) {
        return true; // � poss�vel formar um tri�ngulo
    } else {
        return false; // N�o � poss�vel formar um tri�ngulo
    }
}

// Fun��o para determinar o tipo de tri�ngulo
const char* tipoTriangulo(double lado1, double lado2, double lado3) {
    if (ehTriangulo(lado1, lado2, lado3)) {
        if (lado1 == lado2 && lado2 == lado3) {
            return "O tri�ngulo � do tipo: Equil�tero";
        } else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3) {
            return "O tri�ngulo � do tipo: Is�sceles";
        } else {
            return "O tri�ngulo � do tipo: Escaleno";
        }
    } else {
        return "N�o � Tri�ngulo";
    }
}

int main() {
    double lado1, lado2, lado3;

    // Solicitar ao usu�rio os tr�s lados do tri�ngulo
    printf("Digite o valor do primeiro lado: ");
    scanf("%lf", &lado1);

    printf("Digite o valor do segundo lado: ");
    scanf("%lf", &lado2);

    printf("Digite o valor do terceiro lado: ");
    scanf("%lf", &lado3);

    // Chamar a fun��o para determinar o tipo de tri�ngulo e imprimir o resultado
    printf("%s\n", tipoTriangulo(lado1, lado2, lado3));

    return 0;
}
