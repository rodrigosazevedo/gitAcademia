/* 6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) 
 e o peso (kg) de uma pessoa. O programa deve calcular o Indice de Massa Corpórea (IMC), exibi - lo ao usuário e
informar sua situação conforme a tabela. O cálculo do imc = peso / (altura * altura)

IMC
menor que 18                -> baixo peso
maior que 18 e menor que 25 -> peso normal
maior que 25 e menor que 30 -> sobrepeso
maior que 30 e menor que 35 -> obesidade
maior que 35                -> obesidade grau sério */

string nomeCompleto;
double alturaMetros, pesoKilograma, indiceIMC;

Console.WriteLine("Esse programa irá receber o nome (deve ser em MAIÚSCULO), a altura (em metros) e o peso (em kgs)" +
                    ",\n calcular o IMC e mostrar em qual faixa a pessoa se encaixa.");

Console.Write("Digite o nome (tudo maiúsculo): ");
nomeCompleto = Console.ReadLine();

if(!nomeCompleto.All(char.IsUpper)) Console.WriteLine("O nome deve estar todo em maiúsculo");
else
{
    Console.Write("Digite a altura (em metros): ");
    alturaMetros = double.Parse(Console.ReadLine());

    if (alturaMetros < 0.30 || alturaMetros > 2.50) Console.WriteLine("Altura inválida!");
    else
    {
        Console.Write("Digite o peso (em kilogramas): ");
        pesoKilograma = double.Parse(Console.ReadLine());

        if (pesoKilograma < 2.0 || pesoKilograma > 650.0) Console.WriteLine("Peso inválido!");
        else 
        {
            indiceIMC = pesoKilograma / (alturaMetros * alturaMetros);
            Console.Write("O IMC de " + nomeCompleto + " é de " + Math.Round(indiceIMC,2) + ". Sua faixa é: ");
            switch (indiceIMC)
            {
                case < 18.0:
                    Console.Write("Baixo peso");
                    break;
                case >= 18.0 and < 25.0:
                    Console.Write("Peso normal");
                    break;
                case >= 25.0 and < 30.0:
                    Console.Write("Sobrepeso");
                    break;
                case >= 30.0 and < 35.0:
                    Console.Write("Obesidade");
                    break;
                case >= 35.0:
                    Console.Write("Obesidade grau sério!");
                    break;
            }
        }
    }
    
}

