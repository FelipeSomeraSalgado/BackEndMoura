namespace Exemplos
{
    public class Cachorro : Animal
    {
        public override void fazersom()
        {
            Console.WriteLine($"Au-Au-Au..");
            
        }

        public override void Mover()
        {
            Console.WriteLine($"puf puf puf....");
            
        }
        public override void Dormir()
        {
            Console.WriteLine($"zzzzzz.....");
            
        }
    }
}