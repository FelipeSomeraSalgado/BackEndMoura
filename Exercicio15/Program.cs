//faça um programa que receba 4 notas de um aluno, calcule e imprima a média aritmética das notas e a mensagem de Aprovado para média superior ou igual a 7,0 Recuperação para notas entre 5,0 e 7,0 ou a mensagem de reprovado para média inferior a 5,0
float nota1, nota2, nota3, nota4, media;

Console.WriteLine("Digite a primeira nota:");
nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota:");
nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota:");
nota3 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a quarta nota:");
nota4 = float.Parse(Console.ReadLine());

// Calcula a média aritmética
media = (nota1 + nota2 + nota3 + nota4) / 4;

// Mostra a média e o resultado
Console.WriteLine($"A média do aluno é: {media:F1}");

if (media >= 7.0)
{
    Console.WriteLine("Situação: Aprovado ");
}
else if (media >= 5.0)
{
    Console.WriteLine("Situação: Recuperação ");
}
else
{
    Console.WriteLine("Situação: Reprovado ");
}