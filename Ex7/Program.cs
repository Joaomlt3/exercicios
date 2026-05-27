string nome;
int ano, idade;
Console.WriteLine("Digite o seu nome completo :");
nome = Console.ReadLine();
Console.WriteLine("Digite o seu ano de nascimento :");
ano = int.Parse(Console.ReadLine());
idade = 2026 - ano;
if (idade >= 18)
{
    Console.WriteLine(nome + ", você tem" + idade + " anos e já pode assinar o contrato.");
}
else
{
    Console.WriteLine(nome + ", você tem" + idade + " anos e precisará da asinatura de um responsável.");
}