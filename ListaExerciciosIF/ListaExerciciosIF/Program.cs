// 1)	Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.
Console.WriteLine("Qual foi o salário recebido?");
double salarioRecebido = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Qual foi o total gasto?");
double totalGasto = Convert.ToDouble(Console.ReadLine());

if (totalGasto <= salarioRecebido)
{
    Console.WriteLine("Gastos dentro do orçamento");
}
else
{
    Console.WriteLine("Orçamento estourado");
}
