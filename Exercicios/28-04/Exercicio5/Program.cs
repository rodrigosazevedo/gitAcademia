/*
 * 5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio 
 * de um automóvel (medido em Km/l), sendo que são conhecidos a distância total 
 * percorrida e o volume de combustível consumido para percorrê-la (medido em l).
 */

Console.WriteLine("Esse programa irá receber a distância percorrida e o volume \n" +
                "de combustível consumido (em litros), e com base nisso calcular" +
                "o consumo médio desse automóvel.\n");

Console.Write("Digite a distância total percorrida: ");
float distancia = float.Parse(Console.ReadLine());

Console.Write("Digite o volume de combustível consumido, em litros: ");
float combustivel = float.Parse(Console.ReadLine());

Console.WriteLine("O consumo médio desse automóvel é de: " +
                  distancia / combustivel + "km/l");