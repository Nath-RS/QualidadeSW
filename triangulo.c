/******************************************************************************

                            Online C Compiler.
                Code, Compile, Run and Debug C program online.
Write your code in this editor and press "Run" button to compile and execute it.

*******************************************************************************/
/*teste de caixa preta */
/* verificar se o código funciona com uma entrada negativa ou com uma entrada positiva*/



#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <stdbool.h>

// Funcao para verificar se e possivel formar um triangulo
bool ehTriangulo(double lado1, double lado2, double lado3) {
    if ((lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1)) {
        return true; // e possivel formar um triangulo
    } else {
        return false; // Nao e possivel formar um triangulo
    }
}

// Funcao para determinar o tipo de tri�ngulo
const char* tipoTriangulo(double lado1, double lado2, double lado3) {
    if (ehTriangulo(lado1, lado2, lado3)) {
        if (lado1 == lado2 && lado2 == lado3) {
            return "O triangulo e do tipo: Equilatero";
        } else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3) {
            return "O triangulo e do tipo: Isosceles";
        } else {
            return "O triangulo e do tipo: Escaleno";
        }
    } else {
        return "Nao e Triangulo";
    }
}



int main() {
    //testando com numero negativo
    double lado1, lado2, lado3;

    // Solicitar ao usuario os tres lados do triangulo
    printf("Digite o valor do primeiro lado: \n");
    scanf("%lf", &lado1);

    printf("Digite o valor do segundo lado: \n");
    scanf("%lf", &lado2);

    printf("Digite o valor do terceiro lado: \n");
    scanf("%lf", &lado3);

    // Chamar a funcao para determinar o tipo de triangulo e imprimir o resultado
    printf("%s\n", tipoTriangulo(lado1, lado2, lado3));
    
	system("pause");
    return 0;
}
