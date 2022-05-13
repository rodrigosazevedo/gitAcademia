/* 9. Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
o zoológico num determinado dia, imprimindo:
Quantas pessoas tem entre 1 e 3 filhos.
Quantas pessoas tem entre 4 e 7 filhos.
Quantas pessoas tem mais de 8 filhos.
Quantas pessoas não tem filhos. */

int i, quantidadeFilhos;
int nenhumFilho = 0;
int umTresFilhos = 0;
int quatroSeteFilhos = 0;
int oitoFilhos = 0;

for (i = 1; i <= 30; i++)
{
    Console.Write("Pessoa número " + i + ". Digite o número de filhos da pessoa: ");
    quantidadeFilhos = int.Parse(Console.ReadLine());

    switch (quantidadeFilhos)
    {
        case (0):
            nenhumFilho++;
            break;
        case (>= 1 and <= 3):
            umTresFilhos++;
            break;
        case (>= 4 and <= 7):
            quatroSeteFilhos++;
            break;
        case (>= 8):
            oitoFilhos++;
            break;
        default:
            Console.WriteLine("Valor inválido!");
            break;
    }
}

Console.WriteLine("Número de pessoas com 1 a 3 filhos: " + umTresFilhos + " | Número de pessoas com 4 a 7 filhos:" +
                  quatroSeteFilhos + "\nNúmero de pessoas com mais de 8 filhos: " + oitoFilhos + " | Número de pessoas" +
                  " sem nenhum filho: " + nenhumFilho);
