int NumeroPlacar1, NumeroPlacar2;

Console.WriteLine("Digite o placar do primeiro time");
NumeroPlacar1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o placar do segundo time");
NumeroPlacar2 = int.Parse(Console.ReadLine());

if (NumeroPlacar1 > NumeroPlacar2)
{
    Console.WriteLine("O primeiro time Ganhou!");
}
else if (NumeroPlacar1 < NumeroPlacar2)
{
    Console.WriteLine("O segundo time Ganhou!!");
}
else 
{
    Console.WriteLine("Deu empate!");
}