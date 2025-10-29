using System.Reflection.Emit;
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
    Console.WriteLine($"1) Batata .....................R$10,00");
    Console.WriteLine($"2) Hamburguer..................R$20,00");
    Console.WriteLine($"3) Pizza.......................R$50,00");
    Console.WriteLine($"4) Sushi.......................R$35,00");
    Console.WriteLine($"5) Feijoada....................R$25,00");
    Console.WriteLine($"0) Sair");
    Console.Write($"Opção: ");
    opcao = int.Parse(Console.ReadLine());


    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo...");
            Console.WriteLine($"Digite <Enter> para continuar ...");
            Console.WriteLine();
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
            Console.WriteLine($"Opção Inválida");
            break;
    }

    Console.WriteLine($"Digite <Enter> para continuar...");
    Console.ReadLine();
} while (opcao != 0);


void Batata()
{
    Console.WriteLine($"boa escolha, vamos prepara sua batata com {5 * 2}");

}
 
 void Hamburguer()
{
    Console.WriteLine($"boa escolha, vamos prepara seu hamburguer");

}

void Pizza()
{
    Console.WriteLine($"boa escolha, vamos prepara sua pizza");

}

void Sushi()
{
    Console.WriteLine($"boa escolha, vamos prepara seu sushi");

}

void Feijoada()
{
    Console.WriteLine($"boa escolha, vamos prepara sua feijoada");
    
}