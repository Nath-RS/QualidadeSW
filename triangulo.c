/******************************************************************************

                            Online C Compiler.
                Code, Compile, Run and Debug C program online.
Write your code in this editor and press "Run" button to compile and execute it.

*******************************************************************************/

#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

// Função para verificar se é possível formar um triângulo
bool ehTriangulo(double lado1, double lado2, double lado3) {
    if ((lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1)) {
        return true; // É possível formar um triângulo
    } else {
        return false; // Não é possível formar um triângulo
    }
}

// Função para determinar o tipo de triângulo
const char* tipoTriangulo(double lado1, double lado2, double lado3) {
    if (ehTriangulo(lado1, lado2, lado3)) {
        if (lado1 == lado2 && lado2 == lado3) {
            return "O triângulo é do tipo: Equilátero";
        } else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3) {
            return "O triângulo é do tipo: Isósceles";
        } else {
            return "O triângulo é do tipo: Escaleno";
        }
    } else {
        return "Não é Triângulo";
    }
}

int main() {
    double lado1, lado2, lado3;

    // Solicitar ao usuário os três lados do triângulo
    printf("Digite o valor do primeiro lado: ");
    scanf("%lf", &lado1);

    printf("Digite o valor do segundo lado: ");
    scanf("%lf", &lado2);

    printf("Digite o valor do terceiro lado: ");
    scanf("%lf", &lado3);

    // Chamar a função para determinar o tipo de triângulo e imprimir o resultado
    printf("%s\n", tipoTriangulo(lado1, lado2, lado3));

    return 0;
}
