using Herança;

Aluno aluno1 = new Aluno();
Professor prof1 = new Professor();

aluno1.Nome = "Marcos";
aluno1.idade = 17;
aluno1.Curso = "Informática";

prof1.Nome = "Fernanda";
prof1.idade = 32;
prof1.Disciplina = "Matemática";

Console.WriteLine("=== Dados da Escola ===\n");

Console.WriteLine("Aluno:");
aluno1.Escola();

Console.WriteLine("\nProfessor:");
prof1.Escola();
