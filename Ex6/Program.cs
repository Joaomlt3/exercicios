string nome;
int ano, idade, limite;
double temp;
Console.WriteLine("Digite o seu nome completo:");
nome = Console.ReadLine();
Console.WriteLine("Digite o ano de nascimento:");
ano = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a temperatura atual:");
temp = double.Parse(Console.ReadLine());
idade = 2026 - ano;
limite = 80 - idade;
if (temp > 80)
{
    Console.WriteLine("ALERTA:" + nome + "desligue a máquina!");
}
else
{
    Console.WriteLine(nome + " o sistema está em segurança.");
}