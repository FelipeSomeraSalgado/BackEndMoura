namespace ClassesEObjetos
{
    public class Produto
    {
        public string Nome;

        public double Preco = 0;


        public void Desconto(double percentual)
        {
          if(percentual > 100)
            {
             Console.WriteLine($"O disconto esta indisponivel, proucure o gerente");
             
            }
            else
            {
                Preco -= Preco / 100 * percentual;
                Console.WriteLine($"O seu  desconto de {percentual}% foi aplicado, o preco atual eh R${PreAllocatedOverlapped}");
                
            }
        }
    }


}