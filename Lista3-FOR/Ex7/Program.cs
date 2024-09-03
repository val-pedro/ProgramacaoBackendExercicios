/*
 Faça um algoritmo que leia o peso de 8 pessoas e exiba o maior peso.
 */
double num = 0;
double maiorPeso = 0;

for (int i = 1; i <= 8; i++)
{
    Console.WriteLine("Digite o peso");
    num = Convert.ToDouble(Console.ReadLine());
    if(num > maiorPeso)
    {
        maiorPeso = num;
    }
}

Console.WriteLine($"O maior peso é {maiorPeso}");