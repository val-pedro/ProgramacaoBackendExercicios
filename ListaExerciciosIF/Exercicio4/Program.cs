// 4)	Tendo como entrada a altura e o sexo (codificado da seguinte forma: 1: feminino 2: masculino) de uma pessoa, construa um programa que calcule e imprima seu peso ideal, utilizando as seguintes Fórmulas:
// •	Para homens: (72.7 * Altura) – 58 
// •	Para mulheres: (62.1 * Altura) – 44.7
Console.WriteLine("Digite seu sexo: 1: feminino 2: masculino");
int sexo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite sua altura");
double altura = Convert.ToDouble(Console.ReadLine());
double  pesoIdeal = 0;

if (sexo == 1)
{
    pesoIdeal = (62.1 * altura) - 44.7;
    Console.WriteLine($"O peso ideal é :  {pesoIdeal}KG");
}
else if (sexo == 2)
{
    pesoIdeal = (72.7 * altura) - 58;
    Console.WriteLine($"O peso ideal é :  {pesoIdeal}KG");
}
else
{
    Console.WriteLine("Sexo inválido");
}