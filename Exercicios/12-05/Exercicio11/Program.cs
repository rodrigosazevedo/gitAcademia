/* 11. Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa, 
a média aritmética da turma e a quantidade de alunos da turma. Usar como flag a nota 12. */

double notaAluno;
double somaNotas = 0;
double notaMaisBaixa = 0;
double notaMaisAlta = 0;
int quantidadeAlunos = 0;
int i = 1;


do
{
    Console.Write("Aluno " + i + ". Digite a nota: ");
    notaAluno = double.Parse(Console.ReadLine());

    if(notaAluno != 12)
    {
        somaNotas = somaNotas + notaAluno;
        quantidadeAlunos++;

        if (notaAluno > notaMaisAlta || i == 1) notaMaisAlta = notaAluno;
        if (notaAluno < notaMaisBaixa || i == 1 ) notaMaisBaixa = notaAluno;
    }

    i++;
} while (notaAluno != 12);

Console.WriteLine("Nota mais alta: " + notaMaisAlta + " | Nota mais baixa: " + notaMaisBaixa + "\nMédia aritmética" +
                  " da turma: " + somaNotas / quantidadeAlunos + " | Quantidade de alunos: " + quantidadeAlunos);
