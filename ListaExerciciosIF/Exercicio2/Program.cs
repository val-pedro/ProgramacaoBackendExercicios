// 2)	Faça um programa que pergunte em que turno você estuda. Peça para digitar M-matutino ou V-vespertino ou N-noturno. Imprima a mensagem “Bom dia!” ou  “Boa Noite” ou “Valor inválido”, conforme o caso. 
Console.WriteLine("Em que turno você estuda? M-matutino ou V-vespertino ou N-noturno");
string turno = Console.ReadLine();

if (turno.ToUpper() == "M")
{
    Console.WriteLine("Bom dia!");
}
else if (turno.ToUpper() == "V")
{
    Console.WriteLine("Boa tarde!");
}
else if (turno.ToUpper() == "N")
{
    Console.WriteLine("Boa noite!");
}
else
{
    Console.WriteLine("Valor inválido");
}