// See https://aka.ms/new-console-template for more information

string nome;
string sobrenomeDoFulano;
int idade;
float saldoBancario;
float investimentos;

Console.WriteLine("Olá, qual é seu nome?");
nome = Console.ReadLine();

Console.WriteLine("Qual é seu sobrenome?");
sobrenomeDoFulano = Console.ReadLine();

Console.WriteLine("Qual é a sua idade?");
idade = int.Parse(Console.ReadLine()); // converte o texto em int antes de jogar na variável

Console.WriteLine("Qual é o saldo bancário?");
saldoBancario = float.Parse(Console.ReadLine()); // converte o texto digitado no console em float

Console.WriteLine("Qual é seu investimento?");
investimentos = float.Parse(Console.ReadLine()); // converte o texto digitado no console em float

// Limpa a tela e exibe os dados formatados
Console.Clear();
Console.WriteLine("Saida de dados:");
Console.WriteLine($"Nome: {nome} {sobrenomeDoFulano}");
Console.WriteLine($"Idade do {nome} é {idade}");
Console.WriteLine($"Saldo Bancário: R${saldoBancario}");
Console.WriteLine($"Investimentos este ano: R${investimentos}");