double salario, gasto;

Console.WriteLine($"Digite qual é o seu salario?");
salario = double.Parse(Console.ReadLine());

Console.WriteLine($"Digite qual é o seu gasto?");
gasto = double.Parse(Console.ReadLine());

 if (salario > gasto)
    {
        Console.WriteLine($"Gastos dentro do orçamento");
    }
     else if( gasto > salario)
    {
        Console.WriteLine($"Orçamento estourado");
    }

