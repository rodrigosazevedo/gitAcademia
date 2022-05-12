/* 2. Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
informar um outro número. Caso positivo, o programa em VS deve ser repetido.
 
Exemplo:
Digite um número inteiro positivo: 8
Numero digitado: 8
Números inteiros pares entre 1 e 8: 2, 4, 6.
 
Deseja informar outro número (s/n)? S
 
Digite um número inteiro positivo: 12
Numero digitado: 20
Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.
 
Deseja informar outro número (s/n)? N  */

int numeroInformado, i;
string escolhaUsuario;
bool flagExecutar = true;

Console.WriteLine("Esse programa irá receber um número inteiro positivo e imprimir todos os\nnúmeros pares existentes entre 1 " +
                   "e o número informado");

do
{
    Console.Write("Informe um número inteiro positivo: ");
    numeroInformado = int.Parse(Console.ReadLine());

    while (numeroInformado <= 0)
    {
        Console.WriteLine("Número inválido!");
        Console.Write("Informe um número inteiro positivo: ");
        numeroInformado = int.Parse(Console.ReadLine());
    }

    if (numeroInformado == 1 || numeroInformado == 2 || numeroInformado == 3) Console.WriteLine("Não há nenhum número par entre 1 e o número informado");

    for (i = 1; i < numeroInformado; i++)
    {
        if (i == 2) Console.Write("Números pares entre 1 e o número informado: " + i);
        else if (i % 2 == 0) Console.Write(", " + i);        
        if (i == numeroInformado - 1) Console.WriteLine(".");
    }

    Console.Write("Deseja informar um outro número (s/n)? ");
    escolhaUsuario = Console.ReadLine();

    while (!(escolhaUsuario.Equals("S", StringComparison.OrdinalIgnoreCase)) && !(escolhaUsuario.Equals("N", StringComparison.OrdinalIgnoreCase)))
    {
        Console.WriteLine("A opção informada difere de S ou N!");
        Console.Write("Deseja informar um outro número (s/n)? ");
        escolhaUsuario = Console.ReadLine();
    }
        
    if (String.Equals(escolhaUsuario, "S", StringComparison.OrdinalIgnoreCase)) flagExecutar = true;
    else if (String.Equals(escolhaUsuario, "N", StringComparison.OrdinalIgnoreCase)) flagExecutar = false;
}
while (flagExecutar == true);

