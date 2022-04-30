/*
11) Escreva um algoritmo para ler o número de eleitores de um município, o número de votos brancos, nulos e válidos. 
Calcule e escreva o percentual que cada um representa em relação ao total de eleitores.
 */

Console.WriteLine("Esse programa irá receber o total de eleitores de um município, \no número de votos brancos, nulos" +
                   "e de votos válidos, e devolverá o\n percentual que cada um desses representa em relação ao total.\n");

Console.Write("Digite o número total de eleitores do município: ");
double numeroEleitores = int.Parse(Console.ReadLine());

Console.Write("Digite o total de votos brancos: ");
double votosBrancos = int.Parse(Console.ReadLine());

Console.Write("Digite o total de votos nulos: ");
double votosNulos = int.Parse(Console.ReadLine());

Console.Write("Digite o total de votos válidos: ");
double votosValidos = int.Parse(Console.ReadLine());

Console.WriteLine("Total de eleitores: " + numeroEleitores + " | Percentual de votos válidos: " + 
    Math.Round((votosValidos / numeroEleitores * 100), 2) + "% |\nPercentual de brancos: " + 
    Math.Round((votosBrancos / numeroEleitores * 100),2)+ "% | Percentual de nulos: " + 
    Math.Round((votosNulos / numeroEleitores * 100),2) + "%");