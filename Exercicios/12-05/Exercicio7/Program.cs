/* 7.Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
A cada solicitação, teste se o usuário informou um valor válido. 
Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
informe que ele está incorreto e saia do programa em VS. 
Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
informe que está errada e saia. Se estiver correta, solicite o salário. 
Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
Se estiver correto, mostre todos os valores lidos. */

string nomePessoa;
int idadePessoa;
double salarioPessoa;

Console.Write("Digite o nome: ");
nomePessoa = Console.ReadLine();  

if (nomePessoa.Length == 0 || nomePessoa.Any(char.IsDigit))
{
    Console.WriteLine("Nome inválido!");
    Environment.Exit(0);
}

Console.Write("Digite a idade: ");
idadePessoa = int.Parse(Console.ReadLine());

if (idadePessoa <= 0)
{
    Console.WriteLine("Idade inválida!");
    Environment.Exit(0);
}

Console.Write("Digite o salário: ");
salarioPessoa = double.Parse(Console.ReadLine());

if (salarioPessoa <= 0)
{
    Console.WriteLine("Salário inválido!");
    Environment.Exit(0);
}

Console.WriteLine("\nNome: " + nomePessoa + " | Idade: " + idadePessoa + " | Salário: " + salarioPessoa);
