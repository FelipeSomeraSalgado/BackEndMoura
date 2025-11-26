
namespace Exercio
{ 

    public class Carro
    {
        // Atributos privados
        private string Marca;
        private string Modelo;
        private int velocidadeAtual;

        // Métodos de definição e obtenção da marca
        public void DefinirMarca(string valor)
        {
            Marca = valor;
        }

        public string ObterMarca()
        {
            return Marca;
        }

        // Métodos de definição e obtenção do modelo
        public void DefinirModelo(string valor)
        {
            Modelo = valor;
        }

        public string ObterModelo()
        {
            return Modelo;
        }

        public int ObterVelocidade()
        {
            return velocidadeAtual;
        }

        
      public void Acelerar(int valor)
        {
            velocidadeAtual += valor;
        }

        // Método para frear (sem permitir valor negativo)
        public void Frear(int valor)
        {
            velocidadeAtual -= valor;

            if (velocidadeAtual < 0)
            {
                velocidadeAtual = 0;
            }
        }
    }
 }

    
