/*5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra
“Aprovado” se a média das duas notas for maior ou igual a 7,0. Caso a média seja inferior a 7,0,
o programa deve ler a nota do exame e calcular a média final. Se esta média for maior ou igual a 5,0,
o programa deve escrever “Aprovado”, caso contrário deve escrever “Reprovado”.
*/

double notaP1, notaP2, notaExame;

Console.WriteLine("Esse programa receberá duas notas de um aluno e calculará a média," +
                  "\nmostrando se ele foi aprovado ou não depois de considerar a nota do exame.");

Console.Write("Digite a primeira nota do aluno: ");
notaP1 = double.Parse(Console.ReadLine());

Console.Write("Digite a segunda nota do aluno: ");
notaP2 = double.Parse(Console.ReadLine());

if ((notaP1 + notaP2) / 2 >= 7.0) Console.WriteLine("\nAprovado!");
else
{
    Console.Write("\nAluno em recuperação. Digite a nota do exame: ");
    notaExame = double.Parse(Console.ReadLine());

    if (notaExame >= 5.0) Console.WriteLine("\nAprovado!");
    else Console.WriteLine("\nReprovado!");
}
