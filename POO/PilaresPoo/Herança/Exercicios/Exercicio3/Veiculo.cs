namespace Heranca
{
    public class Veiculo
    {
        public string Marca;
        public string Modelo;

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
        }
    }
}
