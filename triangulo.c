#include <stdio.h>
#include<stdlib.h>
#include<stdbool.h>

double lado[3],ladosmenores[2],soma = 0;
double maior = 0;

bool triangulo(double *lado){
for(int i=0;i<3;i++){
	if(maior > lado[i]){
	maior=lado[i];
	}
}
for(int i=0;i<3;i++){
	if(maior != lado[i]){
	soma = soma + lado[i];
	}
}
if(soma > maior){
return true;
}
else{
return false;
}
}

int main (void){
double lado[3],ladosmenores[2],soma = 0;
double maior = 0;
printf("digite o lado 1 do triangulo:");
scanf("%e",&lado[0]);
printf("digite o lado 2 do triangulo:");
scanf("%e",&lado[1]);
printf("digite o lado 3 do triangulo:");
scanf("%e",&lado[2]);

bool value = triangulo(lado);
if(value){
    printf("Forma um triangulo!");
}
else{
    printf("Não forma um triangulo!");
}

return 0;
}
