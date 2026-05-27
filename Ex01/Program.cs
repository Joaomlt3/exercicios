string nome;
int num;
Console.WriteLine("digite o nome :");
nome = Console.ReadLine();

Console.WriteLine("Digite seu numero");
num = int.Parse(Console.ReadLine());

if (num % 2 == 0) 
{
    Console.WriteLine($"{nome}, acesso liberado Às Terças e Quintas");
}
else
{
    Console.WriteLine($"{nome},acesso liberado às Segundas e Quartas");
}