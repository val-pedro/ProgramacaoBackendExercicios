// 6) Faça um algoritmo que leia do usuário, os nomes de dois times e o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.
Console.WriteLine("Digite o primeiro time");
string timeA = Console.ReadLine();

Console.WriteLine("Digite o segundo time");
string timeB = Console.ReadLine();

Console.WriteLine($"Digite os gols do {timeA}");
int golsTimeA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Digite os gols do {timeB}");
int golsTimeB = Convert.ToInt32(Console.ReadLine());

if (golsTimeA > golsTimeB)
{
    Console.WriteLine($"Vitória do {timeA}");
}
else if (golsTimeB > golsTimeA)
{
    Console.WriteLine($"Vitória do {timeB}");
}
else
{
    Console.WriteLine("Empate");
}