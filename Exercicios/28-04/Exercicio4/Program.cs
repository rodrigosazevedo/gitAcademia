/*
 * 4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA 
 * e imprima na forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser
 * lidos em variáveis diferentes.
 */

Console.WriteLine("Esse programa irá receber um dia, mês e ano e exibir \n" +
    "a essa data no formato AAAAMMDD e AAMMDD. \n");

Console.Write("Digite o dia desejado: ");
int dia = int.Parse(Console.ReadLine());

Console.Write("Digite o mês desejado (1 a 12): ");
int mes = int.Parse(Console.ReadLine());

Console.Write("Digite o ano: ");
int ano = int.Parse(Console.ReadLine());

if (dia < 1 || dia > 31 || mes < 1 || mes > 12 || ano.ToString().Length != 4)
{
    Console.WriteLine("Data digitada inválida. Tente novamente.");
}
else if (dia > 28 && mes == 2)
{
    Console.WriteLine("O mês de fevereiro não aceita mais de 28 dias.");
}

Console.WriteLine("Data no formato AAAAMMDD: " + ano + (mes.ToString()).PadLeft(2, '0') + (dia.ToString()).PadLeft(2, '0') +
                  "\nData no formato AAMMDD: " + (ano.ToString()).Substring(2) + (mes.ToString()).PadLeft(2, '0') + (dia.ToString()).PadLeft(2, '0'));

