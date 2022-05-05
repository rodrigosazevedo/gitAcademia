/* 2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. */

Console.WriteLine("Esse programa receberá um número e dirá se ele é par ou ímpar");

int numeroDigitado;

Console.Write("Digite um número: ");
numeroDigitado = int.Parse(Console.ReadLine());

if (numeroDigitado % 2 == 0)
{
    Console.WriteLine("O número é par!");
}
else
{
    Console.WriteLine("O número é ímpar!");
}
