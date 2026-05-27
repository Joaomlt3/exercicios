string nome;
int dia;
double notabruta, bonus, notafinal;
Console.WriteLine("Digite o seu nome completo :");
nome = Console.ReadLine();
Console.WriteLine("Digite o seu dia de nascimento:");
dia = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a sua nota bruta de 0 a 100:");
notabruta = double.Parse(Console.ReadLine());
bonus = dia / 10;
notafinal = bonus + notabruta;
if (notafinal >= 60)
{
    Console.WriteLine(nome + "aluno APROVADO com a nota " + notafinal);
}
else
{
    Console.WriteLine(nome + "aluno de Recuperação com a nota " + notafinal);
    }