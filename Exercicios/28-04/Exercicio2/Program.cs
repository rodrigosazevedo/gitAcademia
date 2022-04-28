/*
 * 2) Escreva um programa em C# e no Visual Studio
 * para calcular a média aritmética entre quatro números quaisquer.
 */

Console.WriteLine("Esse programa irá receber quatro números quaisquer digitados \n" +
    "pelo usuário e calculará a média aritmética deles \n");

Console.Write("Digite o primeiro número: ");
float primeiroNumero = float.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
float segundoNumero = float.Parse(Console.ReadLine());

Console.Write("Digite o terceiro número: ");
float terceiroNumero = float.Parse(Console.ReadLine());

Console.Write("Digite o quarto número: ");
float quartoNumero = float.Parse(Console.ReadLine());

Console.WriteLine("\nA média aritmética dos valores inseridos é: " +
                 (primeiroNumero + segundoNumero + terceiroNumero + quartoNumero) / 4);
