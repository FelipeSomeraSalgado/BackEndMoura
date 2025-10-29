int quantidade;
        double preco, total;

        Console.Write("Digite o número de maçãs compradas: ");
        quantidade = int.Parse(Console.ReadLine());

        if (quantidade < 12)
        {
            preco = 0.30;
        }
        else
        {
            preco = 0.25;
        }

        total = quantidade * preco;

        Console.WriteLine($"O valor total da compra é: R$ {total:F2}");
