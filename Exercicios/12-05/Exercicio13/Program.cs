/* 13. Elaborar um programa que apresente o somatório dos valores pares existentes 
entre 1 e 500. */

int i;
int soma = 0;

for (i = 2; i <= 500; i += 2) soma = soma + i;

Console.WriteLine("Total da soma dos valores pares existentes entre 1 e 500: " + soma);