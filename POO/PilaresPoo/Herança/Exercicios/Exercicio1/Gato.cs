namespace Herança
{
    public class Gato : Animal
    {
        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Raça: {Raca}");
            Console.WriteLine($"Idade: {Idade}");
        }

          public void FazerSom()
        {
            Console.WriteLine($"Miau...");
            
        }
    }
}