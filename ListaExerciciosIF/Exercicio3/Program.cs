// 3)	As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor total da compra.
Console.WriteLine("Quantas maçãs você comprou?");
int macasCompradas = Convert.ToInt32(Console.ReadLine());
double precoMacas = 0;

if (macasCompradas < 12)
{
    precoMacas = 0.30;

}
else
{
    precoMacas = 0.25;
}

var valorTotal = macasCompradas * precoMacas;
Console.WriteLine($"O preço total é de: {valorTotal} Reais");
