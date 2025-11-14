namespace Heranca
{
    public class Carro : Veiculo
    {
        public int NumeroPortas;

        public override void MostrarInfo()
        {
            Console.WriteLine("=== Carro ===");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Número de portas: {NumeroPortas}");
        }
    }
}
