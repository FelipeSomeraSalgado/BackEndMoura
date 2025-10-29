int NumSenha;
int NumSenhaCorreta = 1234;

Console.WriteLine("Digite o numero da senha");
NumSenha = int.Parse(Console.ReadLine());

if (NumSenha == NumSenhaCorreta)
{
    Console.WriteLine("ACESSO PERMITIDO");
}

else
{
    Console.WriteLine("ACESSO NEGADO");
}
