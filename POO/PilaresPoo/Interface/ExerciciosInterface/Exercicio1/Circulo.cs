

namespace Exercicio1
{
    public class Circulo : IForma
    {
        public double Raio;

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public double CalcularArea()
        {
            return Math.PI * Raio * Raio;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($@"Informações da Forma: Círculo
Raio: {Raio}
Área: {CalcularArea()}
");
        }
    }
}
