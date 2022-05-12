/* 5. Modifique o programa em VS anterior para aceitar votos nulos 
(qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
Ao final, informe o nome do candidato vencedor, o número de votos nulos e o número de pessoas que votaram. */

string votoEscolhido;
int totalVotosZeca = 0;
int totalVotosJoao = 0;
int totalVotosBranco = 0;
int totalVotosNulos = 0;
int totalEleitores = 0;

Console.WriteLine("Esse programa receberá o voto do eleitor para um dos candidatos (JOAO E ZECA), terminando\na contabilização " +
                    "quando o usuário digitar FIM, e no final exibirá o total de votos para\ncada e o candidato vencedor.");

Console.Write("\nDigite JOAO, ZECA ou BRANCO para votar: ");
votoEscolhido = Console.ReadLine().ToUpper();

do
{
    switch (votoEscolhido)
    {
        case "ZECA":
            totalEleitores++;
            totalVotosZeca++;
            Console.WriteLine("Obrigado por votar nessas eleições!");
            break;
        case "JOAO":
            totalEleitores++;
            totalVotosJoao++;
            Console.WriteLine("Obrigado por votar nessas eleições!");
            break;
        case "BRANCO":
            totalEleitores++;
            totalVotosBranco++;
            Console.WriteLine("Obrigado por votar nessas eleições!");
            break;
        case "FIM":
            Console.WriteLine("Programa encerrado!");
            break;
        default:
            totalEleitores++;
            totalVotosNulos++;
            Console.WriteLine("Candidato inexistente! Voto contabilizado como NULO");
            Console.WriteLine("Obrigado por votar nessas eleições!");
            break;
    }

    Console.Write("\nDigite JOAO, ZECA ou BRANCO para votar: ");
    votoEscolhido = Console.ReadLine().ToUpper();

} while (votoEscolhido != "FIM");

Console.WriteLine("\n## Eleições Encerradas ##");
Console.WriteLine("Total de pessoas que votaram nessas eleições: " + totalEleitores);
Console.WriteLine("Total de votos pro candidato ZECA: " + totalVotosZeca);
Console.WriteLine("Total de votos pro candidato JOAO: " + totalVotosJoao);
Console.WriteLine("Total de votos em BRANCO: " + totalVotosBranco);
Console.WriteLine("Total de votos NULOS: " + totalVotosNulos);

if (totalVotosZeca > totalVotosJoao) Console.WriteLine("\nCandidato vencedor: ZECA, com " + totalVotosZeca + " votos.");
else if (totalVotosJoao > totalVotosZeca) Console.WriteLine("\nCandidato vencedor: JOAO, com " + totalVotosJoao + " votos.");
else if (totalVotosJoao == totalVotosZeca) Console.WriteLine("\nEmpate entre os candidatos ZECA e JOAO");