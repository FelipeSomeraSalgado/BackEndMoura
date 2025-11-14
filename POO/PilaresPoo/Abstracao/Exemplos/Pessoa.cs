

namespace Exemplos
{
    public class Pessoa : Animal
    {
        public string Nome;

        public int Idade;

        public override void fazersom()
        {
            Console.WriteLine($"ou fih!");
            
        }

        public override void Mover()
        {
            Console.WriteLine($"pah pah pah....");
            
        }
        public override void Dormir()
        {
            Console.WriteLine($"zzzzzz.....");
            
        }
    }
}