string[] nomes = new string[10];
float[] saldos = new float[10];
int totalClientes = 0;

int opcao;

do
{
    Console.Clear();
    Console.WriteLine($"=== SISTEMA BANCÁRIO SIMPLES ===");
    Console.WriteLine($"1) Cadastrar Cliente");
    Console.WriteLine($"2) Depositar");
    Console.WriteLine($"3) Sacar");
    Console.WriteLine($"4) Transferir");
    Console.WriteLine($"5) Listar Clientes");
    Console.WriteLine($"0) Sair");
    Console.WriteLine($"Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando o programa...");
            break;
        case 1:
            CadastrarCliente();
            break;
        case 2:
            Depositar();
            break;
        case 3:
            Sacar();
            break;
        case 4:
            Transferir();
            break;
        case 5:
            ListarClientes();
            break;
        default:
            Console.WriteLine($"Opção Inválida");
            break;
    }


    //ao final de cada opção, faz uma para no sistema
    Console.WriteLine($"Pressione <Enter> para continuar...");
    Console.ReadLine();

} while (opcao != 0);//recomeça o menu

void CadastrarCliente()
{
    Console.WriteLine($"=== Cadastro de Clientes ===");

    //verificar se eu posso cadastrar
    if (totalClientes >= 10)
    {
        Console.WriteLine($"Limite de clientes atingido");
        return;
    }

    Console.WriteLine($"Nome do cliente: ");
    nomes[totalClientes] = Console.ReadLine();
    saldos[totalClientes] = 0;
    totalClientes++;
    
    Console.WriteLine($"cliente cadastrado com sucesso!");
}

void Depositar()
{
    int idCliente = BuscarClientes();

    if (idCliente == -1)
    {
        return;
    }
    Console.WriteLine($"Valor para depósito: ");
    float valor = float.Parse(Console.ReadLine());
    saldos[idCliente] += valor;
    Console.WriteLine($"Depósito de R$ {valor:F2} realizado");
    

    
}
void Sacar()
{
    int idCliente = BuscarClientes();
    if (idCliente == -1)
    {
        return;
    }
   
    Console.WriteLine($"Valor para saque");
    float valor = float.Parse(Console.ReadLine());
    
     if(saldos[idCliente] >= valor && valor > 0)
    {
        saldos[idCliente] -= valor;
        Console.WriteLine($"Saque realizado com sucesso!");
        
    }
    else
    {
        Console.WriteLine($"Saldo Insuficiente!");
    }
}
void Transferir()
{
    Console.WriteLine($"== Transferência ==");
    Console.WriteLine($"Conta de Origem:");
    int idOrigem = BuscarClientes();
    int idDestino = BuscarClientes();

    if (idOrigem == -1) return;

    Console.WriteLine($"Valor para transferir: ");
    float valor = float.Parse(Console.ReadLine());
    
    if (saldos[idDestino] >= valor && valor > 0)
    {
        saldos[idOrigem] -= valor;
        saldos[idDestino] += valor;
        Console.WriteLine($"Transferência concluída!");
        
    }
    else
    {
        Console.WriteLine($"Saldo Insuficiente!"); 
    }
}
void ListarClientes()
{
    Console.WriteLine($"=== Lista Clientes ===");
    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine($"Nome: {nomes[i]} , R${saldos[i]}");

    }
}
int BuscarClientes()
{
    ListarClientes();//mostra a lista de clientes
    //pedir pro usuário escolher o cliente
    Console.WriteLine($"Digite o desenvolvimentonúmero do cliente: ");
    int idCliente = int.Parse(Console.ReadLine());

    if (idCliente < 0 || idCliente >= totalClientes)
    {
        Console.WriteLine($"Cliente não encontrado!");
        return -1;
        
    }


    //retornar/devolver o id do cliente
    return idCliente;// vamos trocar pelo id do usuário buscado!
}