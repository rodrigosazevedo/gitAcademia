/*
 * 1) Escreva um programa em C# e no Visual Studio
 * para calcular a média aritmética entre dois números quaisquer.
 */

Console.WriteLine("Esse programa irá receber dois números quaisquer digitados \n" +
    "pelo usuário e calculará a média aritmética deles \n");

Console.Write("Digite o primeiro número: ");
float primeiroNumero = float.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
float segundoNumero = float.Parse(Console.ReadLine());

Console.WriteLine("\nA média aritmética dos valores inseridos é: " +
                    (primeiroNumero + segundoNumero) / 2);