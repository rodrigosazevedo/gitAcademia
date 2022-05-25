/*2
Crie um programa em C# no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação. 
O programa deverá exibir na tela para o usuário quantos Cachorros, Gatos e Peixes foram informados.

Regras que deverão ser seguidas para a implementação do programa:

Os únicos tipos de animais válidos são Cachorro, Gato, Peixe.
Caso seja informado um tipo diferente o programa repetir até o usuário digitar um tipo válido.
É obrigatório criar uma classe para representar o Animal.
A classe deverá possuir dois dados privados (propriedades) para representar as características do animal.
A classe deverá possuir métodos de acesso (propriedade getter e setter) para permitir que o usuário armazene/leia os dados dos dois dados privados (propriedades).
*/

using Exercicio2;

string nomeAnimal, tipoAnimal;
int quantidadeAnimais = 1;
List<Animal> ListaAnimais = new List<Animal>();

do
{
    Console.Clear();

    do
    {
        Console.Write("Digite o nome do " + quantidadeAnimais + "º animal: ");
        nomeAnimal = Console.ReadLine();
    } while (!(nomeAnimal.Length > 0 && nomeAnimal.All(Char.IsLetter)));

    do
    {
        Console.Write("Digite o tipo (gato, cachorro ou peixe) do " + quantidadeAnimais + "º animal: ");
        tipoAnimal = Console.ReadLine().ToUpper();
    } while (!(tipoAnimal == "GATO" || tipoAnimal == "CACHORRO" || tipoAnimal == "PEIXE"));

    Animal AnimalEstimacao = new Animal(nomeAnimal, tipoAnimal);
    ListaAnimais.Add(AnimalEstimacao);

    quantidadeAnimais++;

} while (quantidadeAnimais <= 5);

Console.WriteLine(Animal.ContarAnimais(ListaAnimais));