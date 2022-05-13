/* 18.Elaborar um programa que apresente o valor de uma potência de uma base qualquer 
elevada a um expoente qualquer, ou seja, NM. */

int baseInformada, expoenteInformado;

Console.Write("Digite um número para a base: ");
baseInformada = int.Parse(Console.ReadLine());

Console.Write("Digite um número para o expoente: ");
expoenteInformado = int.Parse(Console.ReadLine());

Console.WriteLine(baseInformada + " elevado a " + expoenteInformado + " = " + Math.Pow(baseInformada, expoenteInformado));