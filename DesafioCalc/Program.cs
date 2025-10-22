//pedir para o usuario digitar dois numeros e exibir a soma desses dois numeros


int n1, n2;

Console.WriteLine("Olá, qual é o seu primeiro numero?");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Qual é seu segundo numero");
n2 = int.Parse(Console.ReadLine());

int soma = n1 + n2;

Console.WriteLine($"A soma de {n1} + {n2} é {soma}");



