/* 16.Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da 
multiplicação sucessiva de N por 3 enquanto o produto for menor que 250 
(N*3; N * 3 * 3; N * 3 * 3 * 3; etc). */

int numeroInformado, valorMultiplicacao;

Console.Write("Informe um número entre 1 e 50: ");
numeroInformado = int.Parse(Console.ReadLine());

while (numeroInformado <= 0 || numeroInformado > 50)
{
    Console.WriteLine("Número inválido. Informe-o novamente: ");
    numeroInformado = int.Parse(Console.ReadLine());
}

valorMultiplicacao = numeroInformado * 3;

while (valorMultiplicacao < 250)
{
    Console.WriteLine(valorMultiplicacao);
    valorMultiplicacao = valorMultiplicacao * 3;
} 