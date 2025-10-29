int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("       MENU PRINCIPAL - LISTA DE EXERCÍCIOS");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Escolha o exercício que deseja executar:");
            Console.WriteLine();
            Console.WriteLine("1) Exercício 1");
            Console.WriteLine("2) Exercício 2");
            Console.WriteLine("3) Exercício 3");
            Console.WriteLine("4) Exercício 4");
            Console.WriteLine("5) Exercício 5");
            Console.WriteLine("6) Exercício 6");
            Console.WriteLine("0) Sair");
            Console.WriteLine();
            Console.Write("Opção: ");

            bool valido = int.TryParse(Console.ReadLine(), out opcao);

            if (!valido)
            {
                Console.WriteLine("\n⚠️ Entrada inválida! Digite apenas números.");
            }
            else
            {
                switch (opcao)
                {
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    case 5:
                        Exercicio5();
                        break;
                    case 6:
                        Exercicio6();
                        break;
                    case 0:
                        Console.WriteLine("\nSaindo do programa... Até mais!");
                        break;
                    default:
                        Console.WriteLine("\n❌ Opção inválida!");
                        break;
                }
            }

            if (opcao != 0)
            {
                Console.WriteLine("\nPressione <Enter> para voltar ao menu principal...");
                Console.ReadLine();
            }

        } while (opcao != 0);
    

    // ======= Funções simulando os exercícios =======

    static void Exercicio1()
    {
        Console.WriteLine("\nExecutando o Exercício 1...");
        Console.WriteLine("→ Aqui ficaria o código do exercício 1.");
    }

    static void Exercicio2()
    {
        Console.WriteLine("\nExecutando o Exercício 2...");
        Console.WriteLine("→ Aqui ficaria o código do exercício 2.");
    }

    static void Exercicio3()
    {
        Console.WriteLine("\nExecutando o Exercício 3...");
        Console.WriteLine("→ Aqui ficaria o código do exercício 3.");
    }

    static void Exercicio4()
    {
        Console.WriteLine("\nExecutando o Exercício 4...");
        Console.WriteLine("→ Aqui ficaria o código do exercício 4.");
    }

    static void Exercicio5()
    {
        Console.WriteLine("\nExecutando o Exercício 5...");
        Console.WriteLine("→ Aqui ficaria o código do exercício 5.");
    }

    static void Exercicio6()
    {
        Console.WriteLine("\nExecutando o Exercício 6...");
        Console.WriteLine("→ Aqui ficaria o código do exercício 6.");
    }

