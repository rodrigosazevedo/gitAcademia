/*
8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
A fórmula da conversão é F=(9*C+160)/5.
 */

Console.WriteLine("Esse programa irá receber uma temperatura em graus Celsius e convertê-la" +
                    "para Fahrenheit.\n");

Console.Write("Digite a temperatura em graus Celsius: ");
double temperaturaCelsius = double.Parse(Console.ReadLine());

Console.WriteLine("\nA temperatura inserida em Fahrenheit é: " + (9 * temperaturaCelsius + 160)/5);