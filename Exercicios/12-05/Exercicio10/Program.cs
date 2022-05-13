/* 10. Ler nome, sexo e idade de 50 pessoas e após imprimir:
Número de pessoas do sexo masculino.
Número de pessoas do sexo feminino.
Número de pessoas com idade inferior a 30 anos.
Número de pessoas com idade superior a 60 anos.
Média de idade das mulheres. */

int i, idadeInformada;
string sexoInformado, nomeInformado;
int trintaAnos = 0;
int sessentaAnos = 0;
double somaIdadeMulheres = 0;
int totalHomens = 0;
int totalMulheres = 0;

for (i = 1; i <= 50; i++)
{
    Console.Write("\nPessoa número " + i + ".\nDigite o nome da pessoa: ");
    nomeInformado = Console.ReadLine();
    
    while(nomeInformado.Length == 0 || nomeInformado.All(char.IsDigit))
    {
        Console.Write("Nome inválido! Digite novamente: ");
        nomeInformado = Console.ReadLine();
    }

    Console.Write("Digite o sexo da pessoa (masculino ou feminino): ");
    sexoInformado = Console.ReadLine().ToUpper();

    while(sexoInformado != "MASCULINO" && sexoInformado != "FEMININO")
    {
        Console.Write("Sexo inválido! Digite novamente (masculino ou feminino): ");
        sexoInformado = Console.ReadLine();
    }
    
    Console.Write("Digite a idade da pessoa: ");
    idadeInformada = int.Parse(Console.ReadLine());

    while (idadeInformada <= 0)
    {
        Console.Write("Idade inválida! Digite novamente: ");
        idadeInformada = int.Parse(Console.ReadLine());
    }

    if (sexoInformado == "FEMININO")
    {
        totalMulheres++;
        somaIdadeMulheres += idadeInformada;
    }
    else totalHomens++;

    switch (idadeInformada)
    {
        case (< 30):
            trintaAnos++;
            break;
        case (> 60):
            sessentaAnos++;
            break;
    }
}

Console.WriteLine("Número de pessoas do sexo masculino: " + totalHomens + " | Número de pessoas do sexo feminino:" +
                  totalMulheres + "\nNúmero de pessoas com menos de 30 anos: " + trintaAnos + " | Número de pessoas" +
                  " com mais de 60 anos: " + sessentaAnos + "\nMédia da idade das mulheres: " + somaIdadeMulheres/totalMulheres);
