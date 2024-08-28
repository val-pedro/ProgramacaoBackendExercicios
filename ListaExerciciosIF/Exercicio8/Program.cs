/* 8)Faça um programa para o cálculo de uma folha de pagamento, sabendo que os descontos são do imposto de Renda, que depende do salário bruto (conforme tabela abaixo) e 3% para o Sindicato e que o FGTS corresponde a 11% do salário bruto, mas não é descontado (é a empresa que deposita.)
 O salário líquido corresponde ao salário bruto menos os descontos O programa deverá pedir ao usuário o valor da sua hora e a quantidade de horas trabalhadas no mês.
 Desconto do IR;
  b. Salário Bruto ate R$900,00 (inclusive) – Isento;
  c. Salário Bruto de R$ 1500, 00 (inclusive) – desconto de 5%;
  d. Salario bruto até R$ 2500,00 (Inclusive) – desconto de 10%;
  e. Salário bruto acima de 2500 – Desconto de 20%.

 Imprima na tela as informações, dispostas conforme o exemplo abaixo, no exemplo valor da hora é 5 e a quantidade de horas é 220.  
 Salário bruto (5 * 220)           : R$    1100,00
 ( – ) IR (5%)                     : R$      55,00
 ( – ) INSS ( 10% )                : R$     110,00
 ( - ) Sindicato                   : R$     xxx,xx 
 FGTS ( 11%)                       : R$     121,00
 Total de descontos                : R$     165,00
 Salário Líquido                   : R$     935,00
*/
Console.WriteLine("Digite o valor da hora");
double valorHora = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a quantidade de horas trabalhadas no mês");
double horasTrabalhadas = Convert.ToDouble(Console.ReadLine());

double salarioBruto = valorHora * horasTrabalhadas;

double descontoIR = 0;

double descontoINSS = salarioBruto * 0.10;
double descontoSindicato = salarioBruto * 0.03;
double valorFGTS = salarioBruto * 0.11;
double percentualIRDescontado = 0;


if (salarioBruto <= 900)
{
    descontoIR = 0;
}
else if (salarioBruto > 900 && salarioBruto <= 1500)
{
    percentualIRDescontado = 0.05;
    descontoIR = salarioBruto * percentualIRDescontado;
}
else if (salarioBruto > 1500 && salarioBruto <= 2500)
{
    percentualIRDescontado = 0.10;
    descontoIR = salarioBruto * percentualIRDescontado;
}
else
{
    percentualIRDescontado = 0.20;
    descontoIR = salarioBruto * percentualIRDescontado;
}

double totalDescontos = descontoIR + descontoINSS + descontoSindicato;
double salarioLiquido = salarioBruto - totalDescontos;

Console.WriteLine($"Salário Bruto é de R${salarioBruto}");
Console.WriteLine($"- IR ({percentualIRDescontado * 100}%) R${descontoIR}");
Console.WriteLine($"- INSS ( 10% ) R${descontoINSS}");
Console.WriteLine($"- Sindicato ( 3% ) R${descontoSindicato}");
Console.WriteLine($"+ FGTS ( 11% ) R${valorFGTS}");
Console.WriteLine($"Total de descontos R${totalDescontos}");
Console.WriteLine($"Salário Líquido R${salarioLiquido}");