/*
12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90,
escreva um algoritmo para ler a marcação do odômetro (marcador de quilometragem) no início do dia, a marcação no final do dia, 
o número de litros de combustível gasto e o valor total (R$) recebido dos passageiros. Calcule e escreva a média do consumo em
Km/l e o lucro líquido do dia.

Fórmulas: Total quilometragem =  marcação odômetro final do dia - marcação odômetro inicio do dia 

Média do consumo = Total quilometragem/ quantidade de combustível gasto

Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)
 */

Console.WriteLine("Esse programa irá receber a marcação do odômetro no início do dia, a marcação no final\ndo dia," +
                   "o número de litros de combustível gasto e o valor total (em reais) recebido \ndos passageiros, devolvendo" +
                   "a média do consumo em km/l e o lucro líquido do dia.\n");

Console.Write("Insira a marcação do odômetro no início do dia: ");
double odometroInicio = double.Parse(Console.ReadLine());

Console.Write("Insira a marcação do odômetro no final do dia: ");
double odometroFim = double.Parse(Console.ReadLine());

Console.Write("Insira o número de litros de combustível gastos: ");
double litrosGastos = double.Parse(Console.ReadLine());

Console.Write("Insira o total em reais recebido dos passageiros: ");
double totalPassageiros = double.Parse(Console.ReadLine());

Console.WriteLine("Média do consumo: " + Math.Round((odometroFim - odometroInicio) / litrosGastos, 2) +
                "km/l Lucro do dia: " + Math.Round(totalPassageiros - litrosGastos * 6.90, 2) + " reais");