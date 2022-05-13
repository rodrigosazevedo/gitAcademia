/* 15.Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado 
ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente. 
Considerar nota 7,0 como mínima para aprovação. */

double primeiraNota, segundaNota, terceiraNota, quartaNota;

Console.Write("Digite a primeira nota do aluno: ");
primeiraNota = double.Parse(Console.ReadLine());

Console.Write("Digite a segunda nota do aluno: ");
segundaNota = double.Parse(Console.ReadLine());

Console.Write("Digite a terceira nota do aluno: ");
terceiraNota = double.Parse(Console.ReadLine());

Console.Write("Digite a quarta nota do aluno: ");
quartaNota = double.Parse(Console.ReadLine());

if ((primeiraNota * 2 + segundaNota * 1 + terceiraNota * 2 + quartaNota * 4) / 9 >= 7.0) Console.WriteLine("Aluno aprovado!");
else Console.WriteLine("Aluno reprovado!");
