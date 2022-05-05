/* Fazer um programa que receba o nome completo de uma pessoa e exiba em maiúsculo
 * o primeiro nome e o último sobrenome dessa pessoa */

Console.WriteLine("Esse programa irá receber o nome completo do usuário e exibir\n " +
                    "o primeiro nome e o último sobrenome em maiúsculo");

string nomeCompleto;
string[] nomeSplit;

Console.Write("Insira o nome completo da pessoa: ");
nomeCompleto = Console.ReadLine();

nomeSplit = nomeCompleto.Split();

Console.WriteLine("Primeiro nome: " + nomeSplit[0] + " Último sobrenome: " + nomeSplit[nomeSplit.Length-1]);
