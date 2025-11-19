namespace Exemplos
{
    public class Moto : IMotor
    {
               //Propiedades
        public string Cor;
        public string Marca;
        public string Modelo;
        public int Ano;

        //Construtores
        public Moto(string c, string m, string md , int a )
        {
            Cor = c;
            Marca = m;
            Modelo = md; 
            Ano = a;
        }
        //Metodos
        public void ExibirInfo()
        {
          Console.WriteLine($@"Informação do veículo:
          Marca: {Marca}
          Modelo:{Modelo} 
          Ano: {Ano} 
          Cor: {Cor}
          ");
          
        }
        public void Acelerar()
        {
             Console.WriteLine($"Dando partida vrumm , vrummm....");
        }

        public void Freiar()
        {
            Console.WriteLine($"irrrrrrrrrrirrrrrrrrr.....");
            
        }
    }
}