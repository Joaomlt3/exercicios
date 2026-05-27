string nome;
int chamada, vendas, meta, faltou;
Console.WriteLine("Digite o seu nome completo:");
nome = Console.ReadLine();
Console.WriteLine("Digite o seu número de chamada:");
chamada = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a qantidade de vendas: ");
vendas = int.Parse(Console.ReadLine());
meta = 30 + chamada;
faltou = meta - vendas;
if (vendas >= meta)
{
    Console.WriteLine("Parabéns" + nome + "você bateu a meta de vendas");
}else
{
    Console.WriteLine(nome + "faltou" + faltou + " para você bater a meta de vendas");
}