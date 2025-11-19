using Exercicio1;

Console.Clear();
Console.WriteLine("=== Geometria ===");
Console.WriteLine();

// Criando um retângulo
Retangulo ret = new Retangulo(0, 0); // valores iniciais só para instanciar
ret.Largura = 12;
ret.Altura = 8;

Console.WriteLine("== Retângulo ==");
ret.ExibirInfo();
Console.WriteLine();

// Criando um círculo
Circulo circ = new Circulo(0); // valor inicial só para instanciar
circ.Raio = 5;

Console.WriteLine("== Círculo ==");
circ.ExibirInfo();

Console.WriteLine();
Console.WriteLine("Cálculos concluídos!");
