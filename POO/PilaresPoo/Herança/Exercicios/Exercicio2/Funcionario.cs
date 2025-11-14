namespace Herança
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBase;

        public virtual double CalcularSalario()
        {
            return SalarioBase;
        }
    }
}