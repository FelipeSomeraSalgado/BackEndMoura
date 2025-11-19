

namespace Exemplos
{
    public class ControleRemoto : IControle
    {
        //propriedades
        public int NivelVolume = 0;
        public int VolumeMaximo = 100;
 

        //construtotres
        public void AumentarVolume()
        {
           if (NivelVolume == VolumeMaximo)
           {
             Console.WriteLine($"Nivel de Volume Maximo atingido {NivelVolume}");
             return;
           }

           NivelVolume++;
           Console.WriteLine($"Volume: {NivelVolume}");
           
        }

        //método
        public void Desligar()
        {
           Console.WriteLine($"Desligando a TV....");
           
        }

        public void ligar()
        {
           Console.WriteLine($"Ligando a TV....");
           
        }

        public void DiminuirVolume()
        {
            if(NivelVolume == 0)
            {
                Console.WriteLine($"Volume já está no minimo: {NivelVolume}");
                return;
            }
            NivelVolume--;
            Console.WriteLine($"Volume: {NivelVolume}");
            
        }
    }
}