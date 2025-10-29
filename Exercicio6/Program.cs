double media, frequencia;

        Console.Write("Digite a média do aluno: ");
        media = double.Parse(Console.ReadLine());

        Console.Write("Digite a frequência do aluno (em %): ");
        frequencia = double.Parse(Console.ReadLine());

        if (frequencia < 75)
        {
            Console.WriteLine("Aluno reprovado por frequência.");
        }
        else
        {
            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado!");
            }
            else if (media >= 3.0)
            {
                Console.WriteLine("Aluno em recuperação.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado por nota.");
            }
        }
