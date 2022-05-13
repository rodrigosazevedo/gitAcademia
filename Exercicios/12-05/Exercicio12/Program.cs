/* 12. Apresentar o total da soma dos cem primeiros números inteiros. */

int i;
int soma = 0;

for (i = 1; i <= 100; i++) soma = soma + i;

Console.WriteLine("Total da soma dos cem primeiros números inteiros: " + soma);