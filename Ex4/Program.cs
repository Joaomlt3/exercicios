string nome;
int chamada;
double custo, limite;
Console.WriteLine("Digite o seu nome completo :");
nome = Console.ReadLine();
Console.WriteLine("Digite o seu número de chamada :");
chamada = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o custo total :");
custo = double.Parse(Console.ReadLine());
limite = 1500 + (chamada * 15);
if (limite >= custo)
{
    Console.WriteLine(nome + "o seu limite é de" + limite);
}
else
{
    Console.WriteLine(nome + "você excedeu o limite");
}