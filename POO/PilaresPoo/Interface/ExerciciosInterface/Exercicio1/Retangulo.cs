

namespace Exercicio1
{
    public class Retangulo : IForma
    {
        // Propriedades
        public double Largura;
        public double Altura;

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public double CalcularArea()
        {
            return Largura * Altura;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($@"Informações da Forma: Retângulo
Largura: {Largura}
Altura: {Altura}
Área: {CalcularArea()}
");
        }
    }
}
