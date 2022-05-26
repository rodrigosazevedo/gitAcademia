/* 
#4
Imagine um jogo com asteroides e uma nave de ataque, que deve destruir os asteróides que voam em todas as direções. Dessa forma, crie um programa em C# que represente
uma lista de asteroides que deveriam ser 'inseridos' no jogo. Para isso, faça uma classe que contenha os atributos (privados) posição x, posição y (do asteroide em
um plano cartesiano), tamanho do asteroide(1 a 10), velocidade do asteroide(1 a 5) e energia(1 a 5).Para esses atributos privados, gerar os métodos de acesso
(propriedades getter e setter). Além disso, implementar 3 construtores (sobrecarga): um vazio, outro passando todos os parâmetros de um objeto tipo Asteroide, e um 
terceiro que constrói um asteroide com posição x e posição y. 
O programa principal (main) deve conter a lista de Asteroides, preenchida pelo usuário. Nesse programa principal, construir um método de classe que exiba todos os
asteróides da lista. 
*/

using Exercicio3;

double XcoordAsteroide, ycoordAsteroide;
int tamanhoAsteroide, velocidadeAsteroide, energiaAsteroide, opcao;
string escolheContinuar;
bool flagCriar;

List<Asteroide> ListaAsteroide = new List<Asteroide>();

do
{
    Console.Clear();
    Console.WriteLine("## MENU ##");
    Console.WriteLine("1 - Criar os asteróides do jogo.");
    Console.WriteLine("2 - Exibir os asteróides do jogo.");
    Console.WriteLine("3 - Sair");
    opcao = int.Parse(Console.ReadLine()); 

    switch (opcao)
    {
        case 1:

            flagCriar = true;

            do
            {
                Console.Clear();
                do
                {   
                    Console.Write("Digite o tamanho do asteróide (de 1 a 10): ");
                    tamanhoAsteroide = int.Parse(Console.ReadLine()); 
                } while (tamanhoAsteroide < 1 || tamanhoAsteroide > 10);

                do
                {
                    Console.Write("Digite a velocidade do asteróide (de 1 a 5): ");
                    velocidadeAsteroide = int.Parse(Console.ReadLine());
                } while (velocidadeAsteroide < 1 || velocidadeAsteroide > 5);

                do
                {
                    Console.Write("Digite a energia do asteróide (de 1 a 5): ");
                    energiaAsteroide = int.Parse(Console.ReadLine());
                } while (energiaAsteroide < 1 || energiaAsteroide > 5);

                Asteroide asteroideCriado = new Asteroide(tamanhoAsteroide, velocidadeAsteroide, energiaAsteroide);

                Console.Write("Digite a coordenada X que esse asteróide se encontra: ");
                XcoordAsteroide = double.Parse(Console.ReadLine());

                Console.Write("Digite a coordenada Y que esse asteróide se encontra: ");
                ycoordAsteroide = double.Parse(Console.ReadLine());

                Asteroide asteroidePosicionado = new Asteroide(XcoordAsteroide, ycoordAsteroide, asteroideCriado, asteroideCriado, asteroideCriado);
                ListaAsteroide.Add(asteroidePosicionado);

                do
                {
                    Console.WriteLine("Deseja digitar mais asteróides? (s pra continuar / n pra voltar pro menu)");
                    escolheContinuar = Console.ReadLine().ToUpper();
                } while (escolheContinuar != "S" && escolheContinuar != "N");

                if (escolheContinuar == "N") flagCriar = false;

            } while (flagCriar == true);

            break;
        case 2:
            if (ListaAsteroide.Count > 0)
            {
                Asteroide.ExibirAsteroides(ListaAsteroide);
                Console.Write("\nAperte qualquer tecla para voltar para o menu...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("A lista está vazia. Crie os asteróides primeiro.");
                Console.Write("Aperte qualquer tecla para voltar para o menu...");
                Console.ReadKey();
            }
            break;
        case 3:
            break;
        default:
            Console.WriteLine("Opção inválida, tente novamente.");
            Console.Write("Aperte qualquer tecla para voltar para o menu...");
            Console.ReadKey();
            break;
    }
} while (opcao != 3);