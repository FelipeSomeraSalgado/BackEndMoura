int qtdN, N2, N1;
int i = 0;

Console.WriteLine("Insira um numero de repeticoes");
qtdN = int.Parse(Console.ReadLine());

while (i < qtdN)
{
    Console.WriteLine("Insira um numero");
    N1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Insira o segundo numero");
    N2 = int.Parse(Console.ReadLine());

    if (N1 > N2)
    {
        Console.WriteLine($"o numero {N1} e maior que o {N2}");
    }
     else if( N2 > N1)
    {
        Console.WriteLine($"o numero {N2} e maior que o {N1}");
    }
    else
    {
         Console.WriteLine("Os dois sao iguais");
    }

Thread.Sleep(1500);

    i++;
}

Thread.Sleep(1500);

Console.WriteLine("Numero de repeticoes excedidas");
