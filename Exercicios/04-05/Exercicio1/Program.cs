/*1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base
 * e da altura lidos pelo teclado: Área do triangulo = (base * altura) / 2; 
Teste se a base ou a altura digitada não foi igual a zero. */

double baseTriangulo, alturaTriangulo;

Console.WriteLine("Esse programa receberá o valor da altura e da base de um triângulo, e retornará a área.");

Console.Write("Digite o valor da base do triângulo: ");
baseTriangulo = double.Parse(Console.ReadLine());

Console.Write("Digite o valor da altura do triângulo: ");
alturaTriangulo = double.Parse(Console.ReadLine()); 

if (baseTriangulo == 0 || alturaTriangulo == 0)
{
    Console.WriteLine("\nAltura ou base do triângulo não podem iguais a 0");
}
else
{
    Console.WriteLine("\nÁrea do triângulo = " + (baseTriangulo * alturaTriangulo) / 2);
}