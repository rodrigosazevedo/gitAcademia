/* 3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média,
 e escrever na tela os que são superiores à média. */

int primeiroNumero, segundoNumero, terceiroNumero, quartoNumero, mediaAritmetica;

Console.WriteLine("Esse programa irá receber quatro números inteiros, calcular a média e mostrar" +
                  "quais deles são superiores à média");

Console.Write("Digite o primeiro número: ");
primeiroNumero = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
segundoNumero = int.Parse(Console.ReadLine());

Console.Write("Digite o terceiro número: ");
terceiroNumero = int.Parse(Console.ReadLine());

Console.Write("Digite o quarto número: ");
quartoNumero = int.Parse(Console.ReadLine());

mediaAritmetica = (primeiroNumero + segundoNumero + terceiroNumero + quartoNumero) / 4;

Console.WriteLine("Números acima da média: ");

if (primeiroNumero > mediaAritmetica) Console.WriteLine(primeiroNumero);
if (segundoNumero > mediaAritmetica) Console.WriteLine(segundoNumero);
if (terceiroNumero > mediaAritmetica) Console.WriteLine(terceiroNumero);
if (quartoNumero > mediaAritmetica) Console.WriteLine(quartoNumero);