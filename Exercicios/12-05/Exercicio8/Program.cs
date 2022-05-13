/* Faça um programa em VS que solicite um numero inteiro. Se o numero não for inteiro, solicite-o até q
ue seja. após, informe se ele é par ou impar. 
Finalmente, pergunte ao usuário se ele quer repetir o programa em VS. */

double numeroInformado;
string escolhaUsuario;
bool flagExecutar = true;

do
{
    Console.Write("Digite um número inteiro: ");
    numeroInformado = double.Parse(Console.ReadLine());

    while (numeroInformado % 1 != 0 || numeroInformado == 0)
    {
        Console.Write("Número inválido (0 ou não inteiro), digite novamente: ");
        numeroInformado = double.Parse(Console.ReadLine());
    }

    if (numeroInformado % 2 == 0) Console.WriteLine("O número é par.");
    else Console.WriteLine("O número é ímpar.");

    Console.Write("\nDeseja iniciar o programa novamente (s/n)? ");
    escolhaUsuario = Console.ReadLine().ToUpper();

    while (escolhaUsuario != "S" && escolhaUsuario != "N")
    {
        Console.Write("Escolha inválida. Deseja iniciar o programa novamente (s/n)? ");
        escolhaUsuario = Console.ReadLine().ToUpper();
    }

    if (escolhaUsuario == "S") flagExecutar = true;
    else if (escolhaUsuario == "N") flagExecutar = false;
}
while (flagExecutar == true);