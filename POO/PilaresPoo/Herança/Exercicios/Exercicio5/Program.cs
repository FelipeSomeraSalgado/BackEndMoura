using Herança;

Conta conta1 = new Conta();
ContaPoupanca poupanca1 = new ContaPoupanca();

conta1.Numero = 101;
conta1.Saldo = 500;

poupanca1.Numero = 202;
poupanca1.Saldo = 1000;

Console.WriteLine("=== Contas Bancárias ===\n");

Console.WriteLine("Conta comum:");
conta1.ExibirInfo();
conta1.Depositar(200);
conta1.Sacar(100);
Console.WriteLine();

Console.WriteLine("Conta poupança:");
poupanca1.ExibirInfo();
poupanca1.Depositar(300);
poupanca1.CalcularRendimento();
poupanca1.Sacar(250);
