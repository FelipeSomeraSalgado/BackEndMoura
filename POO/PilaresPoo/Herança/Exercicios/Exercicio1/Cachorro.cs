
namespace Herança
{
    public class Cachorro : Animal
    {
        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Raça: {Raca}");
            Console.WriteLine($"Idade: {Idade}");
        }

          public void FazerSomlatido()
        {
            Console.WriteLine($"Au-Au-Au...");
            
        }
    }
}