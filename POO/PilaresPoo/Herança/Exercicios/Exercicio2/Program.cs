using Herança;

Funcionario funcionario1 = new Funcionario();
Gerente gerente1 = new Gerente();

funcionario1.Nome = "Carlos";
funcionario1.SalarioBase = 2000;

gerente1.Nome = "Fernanda";
gerente1.SalarioBase = 3000;
gerente1.Bonus = 1500;

Console.WriteLine("=== Folha de Pagamento ===\n");

Console.WriteLine($"{funcionario1.Nome}");
Console.WriteLine($"Salário: R$ {funcionario1.CalcularSalario()}\n");

Console.WriteLine($"{gerente1.Nome}");
Console.WriteLine($"Salário (com bônus): R$ {gerente1.CalcularSalario()}\n");
