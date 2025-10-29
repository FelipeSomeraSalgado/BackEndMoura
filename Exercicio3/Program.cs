double Lado1, Lado2, Lado3, NumLado ;

Console.WriteLine("Digite o primeiro numero");
Lado1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
Lado2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro numero");
Lado3 = double.Parse(Console.ReadLine());



if (Lado1 + Lado2 > Lado3 && Lado1 + Lado3 > Lado2 && Lado2 + Lado3 > Lado1)
        {
            if (Lado1 == Lado2 && Lado2 == Lado3)
            {
                Console.WriteLine("O triângulo é Equilátero.");
            }
            else if (Lado1 == Lado2 || Lado1 == Lado3 || Lado2 == Lado3)
            {
                Console.WriteLine("O triângulo é Isósceles.");
            }
            else
            {
                Console.WriteLine("O triângulo é Escaleno.");
            }
        }
        else
        {
            Console.WriteLine("As medidas informadas não formam um triângulo válido.");
  }
