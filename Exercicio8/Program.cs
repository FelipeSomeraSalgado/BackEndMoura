int opcao;

do
{
    Console.Clear();
    Console.WriteLine($"--------------------------------");
    Console.WriteLine($"           BEM VINDO            ");
    Console.WriteLine($"              ao                ");
    Console.WriteLine($"         Jacareca Food          ");
    Console.WriteLine($"--------------------------------");
    Console.WriteLine();
    Console.WriteLine($"Escolha uma opção no menu abaixo:");
    Console.WriteLine();
    Console.WriteLine($"1) Batata ..................... R$10,00");
    Console.WriteLine($"2) Hamburguer ................. R$20,00");
    Console.WriteLine($"3) Pizza ...................... R$50,00");
    Console.WriteLine($"4) Sushi ...................... R$35,00");
    Console.WriteLine($"5) Feijoada ................... R$25,00");
    Console.WriteLine($"0) Sair");
    Console.WriteLine();
    Console.Write($"Opção: ");

    // ✅ Usa TryParse para evitar erro se o usuário digitar letras
    bool entradaValida = int.TryParse(Console.ReadLine(), out opcao);

    if (!entradaValida)
    {
        Console.WriteLine("\n⚠️ Entrada inválida! Digite apenas números.");
    }
    else
    {
        switch (opcao)
        {
            case 0:
                Console.WriteLine("\nSaindo...");
                break;

            case 1:
                Batata();
                break;

            case 2:
                Hamburguer();
                break;

            case 3:
                Pizza();
                break;

            case 4:
                Sushi();
                break;

            case 5:
                Feijoada();
                break;

            default:
                Console.WriteLine("\n❌ Opção inválida!");
                break;
        }
    }

    if (opcao != 0)
    {
        Console.WriteLine("\nPressione <Enter> para continuar...");
        Console.ReadLine();
    }

} while (opcao != 0);

// ======= FUNÇÕES =======
void Batata()
{
    Console.WriteLine($"\nBoa escolha! Vamos preparar sua batata 🍟 por R$10,00");
}

void Hamburguer()
{
    Console.WriteLine($"\nBoa escolha! Vamos preparar seu hambúrguer 🍔 por R$20,00");
}

void Pizza()
{
    Console.WriteLine($"\nBoa escolha! Vamos preparar sua pizza 🍕 por R$50,00");
}

void Sushi()
{
    Console.WriteLine($"\nBoa escolha! Vamos preparar seu sushi 🍣 por R$35,00");
}

void Feijoada()
{
    Console.WriteLine($"\nBoa escolha! Vamos preparar sua feijoada 🍛 por R$25,00");
}
