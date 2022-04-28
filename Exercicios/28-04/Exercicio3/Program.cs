/*
 * 1) Escreva um programa em C# e no Visual Studio
 * para calcular a média aritmética entre dois números quaisquer.
 */

Console.WriteLine("Esse programa irá receber dois números quaisquer e atribuí-los \n" +
    "às variáveis A e B. Depois, irá invertê-los (valor de A para B e do B para A) \n");

Console.Write("Digite um número para a variável A: ");
float A = float.Parse(Console.ReadLine());

Console.Write("Digite um número para a variável B: ");
float B = float.Parse(Console.ReadLine());

float C = A;

A = B;

B = C;

Console.WriteLine("\nValores invertidos. Novo valor de A: " + A +
                   " Novo valor de B: " + B);