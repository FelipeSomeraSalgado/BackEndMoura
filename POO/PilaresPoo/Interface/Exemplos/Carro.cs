

namespace Exemplos
{
    public class Carro : IMotor
    {
        //propriedades
        public string Cor;
        public string Marca;
        public string Modelo;
        public int Ano;

        //construtotres
        public Carro(string c, string m, string md, int a)
        {
            Cor = c;
            Marca = m;
            Modelo = md;
            Ano = a;
        }

        //método
        public void ExibirInfo()
        {
            Console.WriteLine($@"Informação do veículo:
            Cor: {Cor}
            Marca: {Marca}
            Modelo: {Modelo}
            Ano: {Ano}
            ");
            
        }

        public void Acelerar()
        {
            Console.WriteLine($"Carro acelerando... vrumm vrumm");
            
        }

        public void Freiar()
        {
            Console.WriteLine($"Carro freiando irrrrrr....");
           
        }
    }
}