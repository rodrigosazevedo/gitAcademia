/* 4.Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA. 
Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário 
escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número 
de votos em branco. */

string votoEscolhido;
int totalVotosZeca = 0;
int totalVotosJoao = 0;
int totalVotosBranco = 0;

Console.WriteLine("Esse programa receberá o voto do eleitor para um dos candidatos (JOAO E ZECA), terminando a contabilização " +
                    "quando o usuário digitar FIM, e no final exibirá o total de votos para cada.");

Console.Write("Digite JOAO, ZECA ou BRANCO para votar: ");
votoEscolhido = Console.ReadLine().ToUpper();

do
{
    Console.Clear();
    switch (votoEscolhido)
    {
        case "ZECA":
            totalVotosZeca++;
            Console.WriteLine("Obrigado por votar nessas eleições!"); 
            break;
        case "JOAO":
            totalVotosJoao++;
            Console.WriteLine("Obrigado por votar nessas eleições!");
            break;
        case "BRANCO":
            totalVotosBranco++;
            Console.WriteLine("Obrigado por votar nessas eleições!");
            break;
        case "FIM":
            Console.WriteLine("Programa encerrado!");
            break;
        default:
            Console.WriteLine("Candidato inexistente!");
            break;
    }

    Console.Write("Digite JOAO, ZECA ou BRANCO para votar: ");
    votoEscolhido = Console.ReadLine().ToUpper();

} while (votoEscolhido != "FIM");

Console.WriteLine("Total de votos pro candidato ZECA: " + totalVotosZeca);
Console.WriteLine("Total de votos pro candidato JOAO: " + totalVotosJoao);
Console.WriteLine("Total de votos em BRANCO: " + totalVotosBranco);
