/*
9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
do que ou igual às duas prestações, que devem ser iguais, inteiras e as maiores possíveis. 
Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00; 
se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
da entrada e das duas prestações, de acordo com as regras acima. 
Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o 
conseqüente pagamento dos boletos das duas prestações.
 */

Console.WriteLine("Esse programa irá receber o valor de uma mercadoria e decidir quanto deve ser pago" +
                "de entrada e para cada uma das duas prestações.\n");

Console.Write("Insira o valor da mercadoria: ");
double valorMercadoria = double.Parse(Console.ReadLine());

double valorEntrada = (valorMercadoria % 3) + ((valorMercadoria - (valorMercadoria % 3)) / 3);
double valorParcela = (valorMercadoria - valorEntrada) / 2;

Console.WriteLine("\nValor entrada: " + valorEntrada + " | Valor primeira parcela: " + valorParcela +
                 " | Valor segunda parcela: " + valorParcela);
