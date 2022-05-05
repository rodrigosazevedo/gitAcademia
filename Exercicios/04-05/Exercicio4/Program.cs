/* 4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores
 e o valor por hora recebido por cada um deles. Mostrar na tela qual dos professores tem o 
 maior salário total. */

int horasPrimeiro, horasSegundo;
double valorPrimeiro, valorSegundo;

Console.WriteLine("Esse programa receberá a quantidade de horas e o valor/hora de dois professores. " +
                   "\nNo final, mostrará qual deles tem o maior salário total");

Console.Write("Digite a quantidade de horas trabalhada do primeiro professor: ");
horasPrimeiro = int.Parse(Console.ReadLine());

Console.Write("Digite o valor/hora do primeiro professor: ");
valorPrimeiro = double.Parse(Console.ReadLine());

Console.Write("Digite a quantidade de horas trabalhada do segundo professor: ");
horasSegundo = int.Parse(Console.ReadLine());

Console.Write("Digite o valor/hora do segundo professor: ");
valorSegundo = double.Parse(Console.ReadLine());

if((horasPrimeiro * valorPrimeiro) == (horasSegundo * valorSegundo))
{
    Console.WriteLine("\nOs dois professores recebem o mesmo!");
}
else if ((horasPrimeiro * valorPrimeiro) > (horasSegundo * valorSegundo))
{
    Console.WriteLine("\nO primeiro professor recebe mais!");
}
else
{
    Console.WriteLine("\nO segundo professor recebe mais!");
}