/*
13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários 
mínimos mensais, mais uma comissão de 15% sobre o preço de custo de cada bicicleta vendida. Desenvolva um algoritmo
que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas vendidas pelo vendedor, 
calcule e mostre: o salário do empregado
 */

Console.WriteLine("Esse programa irá receber o valor do salário mínimo, o preço do custo de cada bicicleta e o " +
                   "número\nde bicicletas vendidas pelo vendedor para calcular quanto ele deveria receber de " +
                   "salário. ");

Console.Write("Insira o valor do salário mínimo: ");
double valorSalario = double.Parse(Console.ReadLine());

Console.Write("Insira o preço de custo de cada bicicleta: ");
double custoBicicleta = double.Parse(Console.ReadLine());

Console.Write("Insira o número de bicicletas vendidas pelo vendedor: ");
double quantidadeBicicleta = double.Parse(Console.ReadLine());

Console.WriteLine("Salário do vendedor: " + Math.Round(valorSalario + ((custoBicicleta * 0.15) * quantidadeBicicleta),2)+ " reais");