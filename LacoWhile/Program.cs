// See https://aka.ms/new-console-template for more information

int contador = 1;

Console.WriteLine($"Quantas vezes voce quer rodar o while?");

int qtdVezes = int.Parse(Console.ReadLine());

while (contador <= qtdVezes)
{
    Console.WriteLine($"Contador é:  {contador}");
    contador++;
}

