using ClassesEstaticas;

/*Console.WriteLine($"Número de PI: {CalculosMatematicos.PI}");

Console.WriteLine($"digite o primeiro número");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"digite o primeiro segundo número");
float n2 = float.Parse(Console.ReadLine());

Console.WriteLine($"digite qual calculo você quer:");
Console.WriteLine($"Soma: {CalculosMatematicos.Somar(n1,n2)}");
Console.WriteLine($"Subtração: {CalculosMatematicos.Subtrair(n1,n2)}");
Console.WriteLine($"Dividir: {CalculosMatematicos.Dividir(n1,n2)}");
Console.WriteLine($"Multiplicação: {CalculosMatematicos.Multiplicacao(n1,n2)}");*/

Console.WriteLine($"digite o primeiro número:");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"digite o primeiro segundo número:");
float n2 = float.Parse(Console.ReadLine());

float maior = Math.Max(n1, n2);

float menor = Math.Min(n1, n2);

if(n1 > n2)
{
    Console.WriteLine($"o primeiro número é maior que o segundo");
}
else if(n2 > n1)
{
    Console.WriteLine($"o segundo número é maior que o primeiro");
}
else
{
    Console.WriteLine($"os dois números são iguais!");   
}