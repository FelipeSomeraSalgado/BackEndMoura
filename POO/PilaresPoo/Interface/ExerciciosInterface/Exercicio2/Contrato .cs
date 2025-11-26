namespace Exercicio02
{
    public class Contrato : IInprimivel
    {
        public string Nome;
        public string TextoClausulas;

         public Contrato(string NomeContrato, string textoCla)
        {
            Nome = NomeContrato;
            TextoClausulas = textoCla;
            
        }
        public void Imprimir()
        {
            Console.WriteLine($@"
            {Nome}
            {TextoClausulas}");
            Console.WriteLine($"Imprimindo o Contrato.....");
            
        }
    }
}
