namespace Herança
{
    public class Conta
    {
        public int Numero;
        public double Saldo;

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R${valor:F2} realizado com sucesso!");
        }

        public void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R${valor:F2} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Número da conta: {Numero}");
            Console.WriteLine($"Saldo atual: R${Saldo:F2}");
        }
    }
}
