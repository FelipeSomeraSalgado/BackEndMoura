// using Exemplos; 

// Gato birobinha = new Gato();
// Cachorro Neto = new Cachorro();
// Pessoa Salgado = new Pessoa();


// birobinha.fazersom();
// birobinha.Mover();
// birobinha.Dormir();

// Neto.fazersom();
// Neto.Mover();
// Neto.Dormir();

// Salgado.Nome = "Felipe Salgado";
// Salgado.Idade = 16;
// Salgado.fazersom();
// Salgado.Mover();
// Salgado.Dormir();

/*crie uma classe conta bancaria com propriedade depositar e sacar depois crie  as classes contapoupanca (double valor) e conta corrente (double valor) cada uma com a sua propria forma de calcular o saldo após saque*/



using Exemplos;

Console.Clear();

ContaCorrente cc = new ContaCorrente(10);
Console.WriteLine($"Saldo inicial da conta: R${cc.Saldo}");
cc.Depositar(0.5);
Console.WriteLine($"Saldo após depósito: R${cc.Saldo}");
cc.Sacar(10);
Console.WriteLine($"Saldo após saque: R${cc.Saldo}");


Console.WriteLine($"CONTA POUPANÇA:");
ContaPoupanca cp = new ContaPoupanca(10);
Console.WriteLine($"Saldo inicial da conta: R${cp.Saldo}");
cc.Depositar(0.5);
Console.WriteLine($"Saldo após depósito: R${cp.Saldo}");
cc.Sacar(10);
Console.WriteLine($"Saldo após saque: R${cp.Saldo}");