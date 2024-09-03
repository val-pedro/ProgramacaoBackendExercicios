/*
Faça um algoritmo que calcule a tabuada de um número digitado pelo usuário.
Por exemplo: se o usuário digitar o número 2, o programa deverá exibir a
tabuada do 2 da seguinte forma:
2 x 0 = 0
2 x 1 = 2
2 x 2 = 4
...
2 x 10 = 20
*/

Console.WriteLine("Digite o número que deseja visualizar a tabuada");
int tabuada = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{tabuada} x {i} = {tabuada * i}");
}