
namespace Herança
{
    public class Aluno : Pessoa
    {
        public string Curso;

         public void Escola()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Curso: {Curso}");
        }
    }
}