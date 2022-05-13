/* 20. Foi realizada uma pesquisa de algumas características físicas da população de uma 
certa região, a qual coletou os seguintes dados referentes a cada habitante para 
serem analisados:
- sexo (masculino e feminino)
- cor dos olhos (azuis, verdes ou castanhos)
- cor dos cabelos ( louros, castanhos, pretos)
- idade 
 
Faça um algoritmo que determine e escreva: 
 
- a maior idade dos habitantes
- a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
e que tenham olhos verdes e cabelos louros.
O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade. */

int idadeInformada;
int quantidadePessoas = 0;
int maiorIdade = 0;
string sexoInformado, corOlhos, corCabelo;
int i = 1;

do
{
    Console.WriteLine("Dados da pessoa de número " + i);

    Console.Write("Digite a idade da pessoa: ");
    idadeInformada = int.Parse(Console.ReadLine());

    while (idadeInformada <= 0)
    {
        if (idadeInformada == -1) break;
        Console.Write("Idade inválida! Digite novamente: ");
        idadeInformada = int.Parse(Console.ReadLine());
    }

    if (idadeInformada == -1) break;
    else if (idadeInformada > maiorIdade || i == 1) maiorIdade = idadeInformada;

    Console.Write("Digite o sexo da pessoa (masculino ou feminino): ");
    sexoInformado = Console.ReadLine().ToUpper();

    while (sexoInformado != "MASCULINO" && sexoInformado != "FEMININO")
    {
        Console.Write("Sexo inválido! Digite novamente (masculino ou feminino): ");
        sexoInformado = Console.ReadLine();
    }

    Console.Write("Digite a cor dos olhos da pessoa: ");
    corOlhos = Console.ReadLine().ToUpper();

    Console.Write("Digite a cor dos cabelos da pessoa: ");
    corCabelo = Console.ReadLine().ToUpper();

    if (sexoInformado == "FEMININO" && idadeInformada >= 18 && idadeInformada <= 35 &&
      (corOlhos == "VERDE" || corOlhos == "VERDES") && (corCabelo == "LOIRO" || corCabelo == "LOUROS")) quantidadePessoas++;

    i++;
} while (idadeInformada != -1);

Console.WriteLine("Maior idade entre os habitantes: " + maiorIdade + " | Quantidade de habitantes que atendem às características" +
                  " desejadas: " + quantidadePessoas);