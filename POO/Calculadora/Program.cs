using System;

class Calculator
{
    // Atributos
    public double Numero1 { get; set; }
    public double Numero2 { get; set; }

    // Métodos
    public double Somar() => Numero1 + Numero2;
    public double Subtrair() => Numero1 - Numero2;
    public double Multiplicar() => Numero1 * Numero2;
    public double Dividir()
    {
        if (Numero2 == 0)
        {
            Console.WriteLine("Erro: divisão por zero não é permitida!");
            return 0;
        }
        return Numero1 / Numero2;
    }
}

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("=========================================");
        Console.WriteLine("=== Bem-vindo à Calculadora Interativa ===");
        Console.WriteLine("=========================================");
        Console.WriteLine();

        Calculator calc = new Calculator();
        int opcao = 0;

        do
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1) Somar");
            Console.WriteLine("2) Subtrair");
            Console.WriteLine("3) Multiplicar");
            Console.WriteLine("4) Dividir");
            Console.WriteLine("5) Sair");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());
            Console.Clear();

            if (opcao == 5)
            {
                Console.WriteLine("Encerrando o programa... Obrigado!");
                break;
            }

            Console.Write("Digite o primeiro número: ");
            calc.Numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            calc.Numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("== Resultado ==");

            switch (opcao)
            {
                case 1:
                    Console.WriteLine($"Soma: {calc.Somar()}");
                    break;
                case 2:
                    Console.WriteLine($"Subtração: {calc.Subtrair()}");
                    break;
                case 3:
                    Console.WriteLine($"Multiplicação: {calc.Multiplicar()}");
                    break;
                case 4:
                    Console.WriteLine($"Divisão: {calc.Dividir()}");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();

        } while (opcao != 5);
    }
}
