#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

// Função para verificar se é possível formar um triângulo
bool podeFormarTriangulo(double lado1, double lado2, double lado3) {
    if ((lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1)) {
        return true; // É possível formar um triângulo
    } else {
        return false; // Não é possível formar um triângulo
    }
}

// Função para determinar o tipo de triângulo
void tipoTriangulo(double lado1, double lado2, double lado3) {
    if (podeFormarTriangulo(lado1, lado2, lado3)) {
        if (lado1 == lado2 && lado2 == lado3) {
            printf("É um triângulo equilátero.\n");
        } else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3) {
            printf("É um triângulo isósceles.\n");
        } else {
            printf("É um triângulo escaleno.\n");
        }
    } else {
        printf("Não é possível formar um triângulo com esses lados.\n");
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

    // Chamar a função para determinar o tipo de triângulo
    tipoTriangulo(lado1, lado2, lado3);

    return 0;
}

