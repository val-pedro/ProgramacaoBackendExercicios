// 5)	Um posto está vendendo combustíveis com a seguinte tabela de descontos:   
// Álcool:
//     	Até 20 litros: desconto de 3% por litro
//  	Acima de 20 litros: Desconto de 5% por litro.
// Gasolina:
//      Até 20 litros: desconto de 4% por litro
//      Acima de 20 litros, desconto de 6% por litro
// Escreva um algoritmo que leia o número de litros vendidos, o valor do litro de combustível e o tipo de combustível (codificado da seguinte forma: A-álcool. G-gasolina), calcule e imprima o valor a ser pago pelo cliente.
Console.WriteLine("Digite o tipo de combustível que deseja como A-álcool e G-gasolina");
string tipoCombustivel = Console.ReadLine();

Console.WriteLine("Quantos litros foram vendidos?");
double litrosVendidos = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o preço do combustível");
double precoLitro = Convert.ToDouble(Console.ReadLine());

double valorTotalSemDesconto = precoLitro * litrosVendidos;
double valorTotalComDesconto = 0;

if (tipoCombustivel.ToUpper() == "A")
{
    if (litrosVendidos <= 20)
    {
        valorTotalComDesconto = valorTotalSemDesconto -
            (valorTotalSemDesconto * 0.03);
    }
    else
    {
        valorTotalComDesconto = valorTotalSemDesconto - (valorTotalSemDesconto * 0.05);
    }

}
else if (tipoCombustivel.ToUpper() == "G")
{

    if (litrosVendidos <= 20)
    {
        valorTotalComDesconto = valorTotalSemDesconto - (valorTotalSemDesconto * 0.04);
    }
    else
    {
        valorTotalComDesconto = valorTotalSemDesconto - (valorTotalSemDesconto * 0.06);
    }
}

Console.WriteLine($"O valor total é de { valorTotalComDesconto} reais");
