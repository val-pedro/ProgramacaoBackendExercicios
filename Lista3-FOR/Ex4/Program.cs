/*
 Faça um algoritmo que imprima o somatório de todos os números entre 1 e um valor digitado pelo usuário. Por exemplo, se o usuário digitar o número 4, o programa deverá calcular o somatório 1 + 2 + 3 + 4 = 10.
  */

Console.WriteLine("Digite o número do final do intervalo");
int fim = Convert.ToInt32(Console.ReadLine());

int soma = 0;

for (int i = 1; i <= fim; i++)
{
    soma += i;
}

Console.WriteLine($"Soma: {soma}");