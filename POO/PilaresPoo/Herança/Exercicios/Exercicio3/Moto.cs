namespace Heranca
{
    public class Moto : Veiculo
    {
        public string TipoCapacete;

        public override void MostrarInfo()
        {
            Console.WriteLine("=== Moto ===");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Capacete recomendado: {TipoCapacete}");
        }
    }
}
