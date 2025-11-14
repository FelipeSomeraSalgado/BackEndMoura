namespace Herança
{
    public class Gerente : Funcionario
    {
        public double Bonus;

        public override double CalcularSalario()
        {
            return SalarioBase + Bonus;
        }
    }
}
