string nome;
int chamada;

Console.WriteLine("Digite o seu nome completo :");
nome = Console.ReadLine();
Console.WriteLine("Digite o seu número de chamada :");
chamada = int.Parse(Console.ReadLine());
if( chamada<= 15){
    Console.WriteLine($"{nome},seu projeto será focado em Desenvolvimento Web.");
}
else
{ 
    Console.WriteLine($"{nome},seu projeto será focado em Banco de Dados.");
}