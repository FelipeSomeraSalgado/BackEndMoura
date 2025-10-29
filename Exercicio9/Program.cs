 int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("        BEM VINDO AO MENU       ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção no menu abaixo:");
            Console.WriteLine();
            Console.WriteLine("1) Opção 1");
            Console.WriteLine("2) Opção 2");
            Console.WriteLine("3) Opção 3");
            Console.WriteLine("4) Opção 4");
            Console.WriteLine("5) Opção 5");
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
                        Opcao1();
                        break;
                    case 2:
                        Opcao2();
                        break;
                    case 3:
                        Opcao3();
                        break;
                    case 4:
                        Opcao4();
                        break;
                    case 5:
                        Opcao5();
                        break;
                    case 0:
                        Console.WriteLine("\nSaindo... Até mais!");
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
    

    // ====== Funções para cada opção ======

    static void Opcao1()
    {
        Console.WriteLine("\nVocê escolheu a Opção 1!");
    }

    static void Opcao2()
    {
        Console.WriteLine("\nVocê escolheu a Opção 2!");
    }

    static void Opcao3()
    {
        Console.WriteLine("\nVocê escolheu a Opção 3!");
    }

    static void Opcao4()
    {
        Console.WriteLine("\nVocê escolheu a Opção 4!");
    }

    static void Opcao5()
    {
        Console.WriteLine("\nVocê escolheu a Opção 5!");
    }

