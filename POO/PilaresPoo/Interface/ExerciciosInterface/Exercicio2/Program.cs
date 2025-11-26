using Exercicio02;
// List<Fatura> listafatura = new List<Fatura>();
// List<Relatorio> listaRelatorio = new List<Relatorio>();
// List<Contrato> listaContrato = new List<Contrato>();

/*Fatura fatSal = new Fatura();
Documentos.Add(fatSal);

Fatura Ale = new Fatura();
Documentos.Add(Ale);



Relatorio relSal = new Relatorio();
Documentos.Add(relSal);

Relatorio Alex = new Relatorio();
Documentos.Add(Alex);


Contrato conSal = new Contrato();
Documentos.Add(conSal);

Contrato Edu = new Contrato();
Documentos.Add(Edu);


// fatRafa.Imprimir();
// relRafa.Imprimir();
// conRafa.Imprimir();


//Listar os Dados 
// for(int i = 0; i < listafatura.Count; i++)
// {
//     listafatura[i].Imprimir();
// }
Console.WriteLine($"FATURAS");
foreach (var fat in Documentos)
{
    if (fat is Fatura)
    {
        fat.Imprimir();
    }
}

Console.WriteLine($"");

Console.WriteLine($"RELATORIOS");
foreach (var rel in Documentos)
{
    if (rel is Relatorio)
    {
        rel.Imprimir();
    }
}

Console.WriteLine($"");

Console.WriteLine($"CONTRATOS");
foreach (var con in Documentos)
{
    if (con is Contrato)
    {
        con.Imprimir();
    }
}
*/
List<IInprimivel> Documentos = new List<IInprimivel>();

int opcao;

do
{
    Console.Clear();
    Console.WriteLine($@"Menu de Opções
    1) Cadastrar Fatura
    2) Cadastrar Relatório
    3) Cadastrar Contrato
    4) Listar Faturas
    5) Listar Relatórios
    6) Listar Contratos
    0) Sair
    Escolha a opção:
    ");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            CadastrarFaturas();
            break;

        case 2:
            CadastrarRalatorio();
            break;

        case 3:
            CadastrarContrato();
            break;

        case 4:
            listaFatura();
            break;

        case 5:
            listaRelatorio();
            break;

        case 6:
            listaContrato();
            break;

        case 0:
            Console.WriteLine($"Saindo...");
            break;

        default:
            Console.WriteLine($"Opção Inválida!");
            break;
    }

    Console.WriteLine("Pressione <Enter> para continuar...");
    Console.ReadLine();

} while (opcao != 0);

void CadastrarFaturas()
{
    Console.WriteLine($"Digite o nome do Cliente Devedor");
    string Dev = Console.ReadLine();

    Console.WriteLine($"Digite o nome da empresa");
    string empresa = Console.ReadLine();

    Console.WriteLine($"Digite o valor da fatura");
    float Valor = float.Parse(Console.ReadLine());

    Console.WriteLine($"Digite o atraso da fatura");
    int qtdDiasAtraso = int.Parse(Console.ReadLine());

    Fatura fat = new Fatura(Dev, empresa, Valor, qtdDiasAtraso);
    Documentos.Add(fat);

    
    
}

void CadastrarRalatorio()
{
    Console.WriteLine($"Digite o nome do resposável do relatório:");
    string Responsavel = Console.ReadLine();

    Console.WriteLine($"Digite qual o texto do relatório:");
    string textoRe = Console.ReadLine();

    Relatorio rel = new Relatorio(Responsavel, textoRe);
    Documentos.Add(rel);
    Console.WriteLine($"Relatório cadastrado com sucesso!");
    
}

void CadastrarContrato()
{
    Console.WriteLine($"Digite o nome do resposável do contrato:");
    string NomeContrato = Console.ReadLine();

    Console.WriteLine($"Digite a clausula do contrato:");
    string textoCla = Console.ReadLine();

    Contrato con = new Contrato(NomeContrato, textoCla);
    Documentos.Add(con);
    Console.WriteLine($"Contrato cadastrado com sucesso!");
    
}

void listaFatura()
{
    Console.WriteLine($"Listando Faturas:");
    foreach (var item in Documentos)
    {
        if(item is Fatura)
        {
            item.Imprimir();
        }
    }
    
}

void listaRelatorio()
{
    Console.WriteLine($"listando Relatório:");
    foreach (var item in Documentos)
    {
        if(item is Relatorio)
        {
            item.Imprimir();
        }
    }
    
}

void listaContrato()
{
    Console.WriteLine($"listando Relatório:");
    foreach (var item in Documentos)
    {
        if(item is Contrato)
        {
            item.Imprimir();
        }
    }
}