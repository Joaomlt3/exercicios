using System.Data;
using System.Security;
double vt;
string nome;
int mes;
double vl;
Console.WriteLine("Qual seu nome:");
nome = Console.ReadLine();

Console.WriteLine("qual seu mês de aniversario");
mes = int.Parse(Console.ReadLine());

Console.WriteLine("Este e o valor final");
vl =  double.Parse(Console.ReadLine());

if (mes <= 6)
{
    vt = vl - (vl * 0.10);
}
else
{
    vt = vl - (vl * 0.05);
}
Console.WriteLine($"{nome},Vai pagar um valor de igual a :{vt}");