namespace Exemplos
{
    public class Gato : Animal
    {
        public override void fazersom()
        {
            Console.WriteLine($"Miauzinho");
            
        }

        public override void Mover()
        {
            Console.WriteLine($"ploc ploc ploc....");
            
        }
         public override void Dormir()
        {
            Console.WriteLine($"zzzzzz.....");
            
        }
    }
}