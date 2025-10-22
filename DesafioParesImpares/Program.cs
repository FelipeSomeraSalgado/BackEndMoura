//CRIAR UM NOVO PROJETO CHAMADO DesafioParesImpares
//PERGUNTAR AO USUARIO QUANTOS NUMEROS ELE QUER DIGITAR
//EXIBIR,SEPARADAMENTE OS NUMEROS PARES E OS NUMEROS IMPARES QUE ELE DIGITAR
Console.WriteLine($"Quantos numeros voce quer digitar?");
int qtdNumero = int.Parse(Console.ReadLine());
string pares = "Pares: ";
string impares = "impares: ";

for (int i = 1; i < qtdNumero; i++)
{
    Console.WriteLine($"Digite o {i}º numero");
    int numeroDigitado = int.Parse(Console.ReadLine());

    if (numeroDigitado % 2 == 0)
    {
        pares += numeroDigitado.ToString() + ",";
    }
    else
    {
        impares += numeroDigitado.ToString() + ",";
    }
}

Console.Clear();
Console.WriteLine($"RESULTADO:");
Console.WriteLine();
Console.WriteLine(pares);   
Console.WriteLine(impares); 
