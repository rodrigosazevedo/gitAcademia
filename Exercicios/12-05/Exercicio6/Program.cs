/* 6.Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados,
ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
Ao final, mostre a idade digitada. */

Console.WriteLine("Esse programa receberá a idade do usuário e a exibirá em seguida.");

int idadeInformada;

Console.Write("Digite a idade: ");
idadeInformada = int.Parse(Console.ReadLine());

while (idadeInformada <= 0)
{
    Console.WriteLine("Idade inválida! Deve ser maior que 0");
    Console.Write("Digite a idade: ");
    idadeInformada = int.Parse(Console.ReadLine());
}

Console.WriteLine("Idade digitada: " + idadeInformada + " anos.");