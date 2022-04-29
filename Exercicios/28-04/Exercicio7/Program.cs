/*
7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor,
o seu salário fixo, o total de vendas por ele efetuadas e o percentual que ganha
sobre o total de vendas. Calcule o salário total do vendedor. Escreva o número do 
vendedor e o salário total do vendedor.
 */

Console.WriteLine("Esse programa irá receber dados de um vendedor, como o número, " +
                   "salário fixo, total de vendas efetuadas e o percentual que " +
                   "ele ganha sobre esse total, e calculará o salário total dele.\n");

Console.Write("Digite o número do vendedor: ");
int numeroVendedor = int.Parse(Console.ReadLine());

Console.Write("Digite o salário fixo do vendedor: ");
float salarioVendedor = float.Parse(Console.ReadLine());

Console.Write("Digite o total de vendas efetuadas: ");
int vendasVendedor = int.Parse(Console.ReadLine());

Console.Write("Digite o percentual que o vendedor recebe sobre o total: ");
float percentualVendedor = float.Parse(Console.ReadLine());

Console.Write("O vendedor de número " + numeroVendedor + " terá um salário total de " +
             (salarioVendedor + (vendasVendedor * percentualVendedor / 100.0)));
