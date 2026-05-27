string nome;
int num;
int ano;

Console.WriteLine("Digite seu nome");
nome = Console.ReadLine();

Console.WriteLine("Digite o numero de chamada");
num = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o seu Ano de Nascimento");
ano = int.Parse(Console.ReadLine());

int SenhaMestra = ano + num;
int senhaDigitada;
Console.WriteLine("digite a senha para abrir o cofre:");
senhaDigitada = int.Parse(Console.ReadLine());

if (senhaDigitada == SenhaMestra) 
{
    Console.WriteLine("cofre aberto com sucesso!");
}
else
{
    Console.WriteLine("senha incorreta! acesso negado.");
}
