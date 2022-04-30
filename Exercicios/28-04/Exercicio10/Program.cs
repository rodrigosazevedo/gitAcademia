/*
10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
notas de menor valor fossem distribuídas em número mínimo possível. 
Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, 
três notas de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
de acordo com o critério da “distribuição ótima”.
 */

Console.WriteLine("Esse programa irá receber um valor em reais digitado pelo usuário e dividí-lo" +
                   "nas maiores cédulas possíveis para o saque.\n");

Console.Write("Digite o valor (inteiro) desejado para o saque: ");
int valorSacado = int.Parse(Console.ReadLine());

Console.WriteLine("Foram sacadas as seguintes quantidades de cédulas:" + "\nCédulas de 200: " + valorSacado / 200 +
                  " \nCédulas de 100: " + (valorSacado % 200) / 100 + "\nCédulas de 50: " + (valorSacado % 100) / 50 + "\nCédulas de 20: " 
                  + (((valorSacado % 200) % 100) % 50) / 20 + "\nCédulas de 10: " + ((((valorSacado % 200) % 100) % 50) % 20) / 10 + 
                  "\nCédulas de 5: " + (((((valorSacado % 200) % 100) % 50) % 20) % 10) / 5 + "\nCédulas de 2: " +
                  ((((((valorSacado % 200) % 100) % 50) % 20) % 10) % 5) / 2 + "\nRestante: " +
                  ((((((valorSacado % 200) % 100) % 50) % 20) % 10) % 5) % 2);