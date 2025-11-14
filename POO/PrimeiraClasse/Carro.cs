
using System.ComponentModel.Design;

namespace PrimeiraClasse
{
    public class Carro
    {
        //atributos
        public string modelo;
        public string marca;
        public string cor;
        public string potencia;


        //métodos
        public void Ligar()
        {
            Console.WriteLine($"zizizi... vrum");
       

        }
        
        public void Acelerar()
        {
            Console.WriteLine($"vrum vrum ...");
            
        }
    
    }
}