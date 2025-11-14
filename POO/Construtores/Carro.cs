
namespace Construtores
{
    public class Carro
    {
        public string Marca;

        public string Modelo;

        public int Ano;

        public Carro(string marca,string modelo,int ano)
        {
            //preenchendo os dados inicias na classe
            Marca = marca;
            Modelo = modelo;
            Ano = ano;

            ExibirDados();//exibe as informações da classe
        }
            
        public void ExibirDados()
        {
            Console.WriteLine($"O seu carro é da marca {Marca}, do modelo {Modelo} do ano {Ano}");
            
        }
    }
}