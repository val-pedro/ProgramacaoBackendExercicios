/* 
Escreva um programa que pergunte um número n para o usuário e exiba todos os seus divisores. Exemplo: se o usuário digitar o número 100, os seguintes números deverão ser exibidos: 1, 2, 4, 5, 10, 20, 25, 50, 100.
*/
Console.WriteLine("Digite um número");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    if (num % i == 0)
    {
        Console.WriteLine(i);
    }
}