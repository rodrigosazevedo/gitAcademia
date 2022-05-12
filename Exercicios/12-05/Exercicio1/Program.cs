/* 1. Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
(informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

Exemplo:
Digite um número inteiro positivo: -8
Valor incorreto!
Digite um número inteiro positivo: 8
Numero digitado: 8
Números inteiros pares entre 1 e 8: 2, 4, 6. */

int numeroInformado, i;

Console.WriteLine("Esse programa irá receber um número inteiro positivo e imprimir todos os\nnúmeros pares existentes entre 1 " +
                   "e o número informado");

Console.Write("Informe um número inteiro positivo: ");
numeroInformado = int.Parse(Console.ReadLine());

while (numeroInformado <= 0)
{
    Console.WriteLine("Número inválido!");
    Console.Write("Informe um número inteiro positivo: ");
    numeroInformado = int.Parse(Console.ReadLine());
}

if (numeroInformado == 1 || numeroInformado == 2 || numeroInformado == 3) Console.WriteLine("Não há nenhum número par entre 1 e o número informado");

for (i = 1; i < numeroInformado; i++)
{
    if (i == 2) Console.Write("Números pares entre 1 e o número informado: " + i);
    else if (i % 2 == 0 && i != numeroInformado - 1) Console.Write(", " + i);
    else if (i == numeroInformado - 1) Console.Write(".");   
}

