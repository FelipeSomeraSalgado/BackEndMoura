namespace Herança
{
    public class ContaPoupanca : Conta
    {
        public void CalcularRendimento()
        {
            double rendimento = Saldo * 0.02;
            Saldo += rendimento;
            Console.WriteLine($"Rendimento de 2% aplicado: R${rendimento:F2}");
        }
    }
}
