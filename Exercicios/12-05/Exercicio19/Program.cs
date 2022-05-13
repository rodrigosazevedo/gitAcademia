/* 19. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, 
coletando dados sobre o salário e número de filhos. A prefeitura deseja saber: 
 
a) média do salário da população;
b) média do número de filhos;
c) maior salário;
d) percentual de pessoas com salário até R$ 100,00.
O final da leitura de dados se dará com a entrada de um salário negativo. */

double salarioInformado;
double maiorSalario = 0;
double somaSalario = 0;
double salarioMenor100 = 0;
double quantidadeHabitantes = 0;
int numeroFilhos;
int i = 1;
int somaFilhos = 0;


do
{
    Console.Write("Pessoa " + i + ". Informe o salário: ");
    salarioInformado = double.Parse(Console.ReadLine());

    if (salarioInformado >= 0)
    {
        if (salarioInformado > maiorSalario || i == 1)
        {
            maiorSalario = salarioInformado;   
        }
        if (salarioInformado < 100.0) salarioMenor100++;
        quantidadeHabitantes++;
        somaSalario = somaSalario + salarioInformado;
        Console.Write("Informe o número de filhos: ");
        numeroFilhos = int.Parse(Console.ReadLine());
        somaFilhos = somaFilhos + numeroFilhos;
    }

    i++;

} while (salarioInformado >= 0);

Console.WriteLine("Média do salário da população: " + somaSalario / quantidadeHabitantes + " | Média do número de filhos: " +
                  somaFilhos / quantidadeHabitantes + "\nMaior salário: " + maiorSalario + " | Percentual de pessoas" +
                  " com salário inferior a R$100,00: " + (salarioMenor100 / quantidadeHabitantes) * 100 + "%");