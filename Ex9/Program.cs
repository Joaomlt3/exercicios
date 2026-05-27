string nome;
int dia, mes, secret, palpite;
Console.WriteLine("Digite o seu nome:");
nome = Console.ReadLine();
Console.WriteLine("Digite o seu mes de nascimento:");
mes = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o seu dia de nascimento:");
dia = int.Parse(Console.ReadLine());
secret = dia * mes;
Console.WriteLine("Tente um palpite dé um número da sorte:");
palpite = int.Parse(Console.ReadLine());
if (palpite == secret)
{
    Console.WriteLine("Incrivel" + nome + "! Voce acertou");
}
else
{
    Console.WriteLine("Que pena," + nome + "! O número correto era" + secret);
}
