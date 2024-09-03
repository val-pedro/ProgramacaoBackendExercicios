/*
 Desenvolver um algoritmo que leia 8 números, calcule e escreva a média aritmética dos valores lidos, a quantidade de valores positivos, a quantidade de valores negativos e o percentual de valores negativos e positivos.
 */
int num = 0;
int somaTotal = 0;
int qtdePositivos = 0;
int qtdeNegativos = 0;

for (int i = 1; i <= 8; i++)
{
    Console.WriteLine("Digite um número");
    num = Convert.ToInt32(Console.ReadLine());

    somaTotal += num;

    if(num > 0)
    {
        qtdePositivos++;
    } 
    else if(num < 0)
    {   
        qtdeNegativos++;
    }
}

Console.WriteLine($"Média geral: {somaTotal / 8.0}");
Console.WriteLine($"Quantidade de positivos: {qtdePositivos}");
Console.WriteLine($"Quantidade de negativos: {qtdeNegativos}");

Console.WriteLine($"Percentual de positivos: {qtdePositivos / 8.0 * 100}%");
Console.WriteLine($"Percentual de negativos: {qtdeNegativos / 8.0 * 100}%");