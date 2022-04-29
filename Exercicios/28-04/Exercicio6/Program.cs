/*
6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso 
A e para o parafuso B, isto é, o código, a quantidade de peças e o valor unitário
de cada parafuso e a porcentagem de IPI (única) a ser acrescentada.
 */

Console.WriteLine("Esse programa irá receber dados dos parafusos A e B (código," +
                   "quantidade de peças e porcentagem de IPI) \n");

Console.Write("## Parafuso A ##: ");

Console.Write("Código: ");
string codigoParafusoA = Console.ReadLine();

Console.Write("Quantidade: ");
int quantidadeParafusoA = int.Parse(Console.ReadLine());

Console.Write("Porcentagem de IPI: ");
float ipiParafusoA = float.Parse(Console.ReadLine());

Console.Write("## Parafuso B ##: ");

Console.Write("Código: ");
string codigoParafusoB = Console.ReadLine();

Console.Write("Quantidade: ");
int quantidadeParafusoB = int.Parse(Console.ReadLine());

Console.Write("Porcentagem de IPI: ");
float ipiParafusoB = float.Parse(Console.ReadLine());

Console.WriteLine("\n# Parafuso A # código: " + codigoParafusoA + " quantidade: " + quantidadeParafusoA +
                   " porcentagem de IPI: " + ipiParafusoA + "%" + "\n# Parafuso B # código: " + codigoParafusoB +
                   " quantidade: " + quantidadeParafusoB + " porcentagem de IPI: " + ipiParafusoB + "%");

