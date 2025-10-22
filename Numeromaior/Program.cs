// Pedir para o usuário digitar dois números
// Em seguida verificar e exibir qual é o maior dos dois números
// Caso sejam iguais, exibir mensagem dizendo que não há número maior

int num1, num2;

Console.WriteLine("Olá, qual é o seu primeiro número?");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Qual é o seu segundo número?");
num2 = int.Parse(Console.ReadLine());

// Verifica qual número é maior ou se são iguais
if (num1 > num2)
{
    Console.WriteLine($"O número maior é {num1}");
}
else if (num2 > num1)
{
    Console.WriteLine($"O número maior é {num2}");
}
else
{
    Console.WriteLine("Os dois números são iguais, portanto não há número maior.");
}


