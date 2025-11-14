

namespace Herança
{
    public class Professor : Pessoa
    {
        public string Disciplina;

        public void Escola()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Disciplina: {Disciplina}");
        }
    }
}