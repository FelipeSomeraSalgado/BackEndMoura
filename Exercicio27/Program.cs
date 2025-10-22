int qtdn = 0;
int ctm = 1; 

Console.WriteLine("Quantos vezes voce quer repetir?");
qtdn = int.Parse(Console.ReadLine());

while( ctm <= qtdn)
{
    Console.WriteLine($"Digite um Numero:");
    int N1 = int.Parse(Console.ReadLine());
    if(N1 % 2 == 0)
    {
        Console.WriteLine($"Numero Digitado e par {N1}");
    }
    else
    {
        Console.WriteLine($"Numero Digitado e impar {N1}");
    }

 ctm++;
}