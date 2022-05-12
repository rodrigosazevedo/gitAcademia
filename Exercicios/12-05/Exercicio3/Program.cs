/* 3.Fazer um laço(repetição) que fique solicitando números ao usuário. 
Se o usuário digitar 0 o programa em VS deve parar. 
Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.  */

int numeroInformado;

Console.WriteLine("Esse programa receberá números e informará se eles são pares ou ímpares, e também se são primos." +
                    "\nDigite 0 a qualquer momento para parar o programa.\n");

Console.Write("Digite um número: ");
numeroInformado = int.Parse(Console.ReadLine());

if(numeroInformado == 0)
{
    Environment.Exit(0);
}

do
{
    if (numeroInformado % 2 == 0) Console.WriteLine("Esse número é par.");
    else Console.WriteLine("Esse número é ímpar.");

    if (isPrime(numeroInformado)) Console.WriteLine("Esse número é primo.");
    else Console.WriteLine("Esse número não é primo.");

    Console.Write("\nDigite um número: ");
    numeroInformado = int.Parse(Console.ReadLine());
}
while (numeroInformado != 0);


static bool isPrime(int n)
{
    if (n <= 1)
        return false;
    else if (n % 2 == 0)
        return n == 2;

    int max = (int)(Math.Sqrt(n) + 0.5);

    for (int divisor = 3; divisor <= max; divisor += 2)
        if (n % divisor == 0)
            return false;

    return true;
}