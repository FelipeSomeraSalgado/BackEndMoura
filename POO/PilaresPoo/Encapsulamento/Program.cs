using Encapsulamento;

ContaBancaria contaEdu = new ContaBancaria();
ContaBancaria contaMaria= new ContaBancaria();

contaEdu.Depositar(-100);
contaEdu.Depositar(20);

contaEdu.Sacar(-200);
contaMaria.Sacar(300);

Console.WriteLine($"Saldo atual do Edu: R${contaEdu.GetSaldo()}");
Console.WriteLine($"Saldo atual ds Maria: R${contaEdu.GetSaldo()}");
