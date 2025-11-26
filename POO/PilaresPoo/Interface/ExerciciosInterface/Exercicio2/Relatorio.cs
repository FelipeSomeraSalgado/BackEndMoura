namespace Exercicio02
{
    public class Relatorio : IInprimivel
    {
        public string NomeResponsavel = "";
        public string TextoRalatorio = "";

         public Relatorio(string Responsavel, string textoRe)
        {
            NomeResponsavel = Responsavel;
            TextoRalatorio = textoRe;
            
        }

        public void Imprimir()
        {
            Console.WriteLine($@"
            {NomeResponsavel}
            {TextoRalatorio}");
            Console.WriteLine($"Imprimndo o Relatorio......");
            
        }
    }
}