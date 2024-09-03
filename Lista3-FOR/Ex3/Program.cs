/*
 Faça um algoritmo que imprima a soma dos números multiplos de 11 em um intervalo digitado pelo usuário;
 */

Console.WriteLine("Digite o número do ínicio do intervalo");
int inicio = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o número do final do intervalo");
int fim = Convert.ToInt32(Console.ReadLine());

int soma = 0;

for (int i = inicio; i <= fim; i++)
{
    if (i % 11 == 0)
    {
        soma += i;
    }
}
Console.WriteLine($"Soma: {soma}");