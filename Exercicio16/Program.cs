// See https://aka.ms/new-console-template for more information
using System.Net.WebSockets;
using System.Runtime.CompilerServices;

string cargo;
double salario, NovoSalario;

float saldo = 200.95f;
double saldo2 = 200.95f;

Console.WriteLine($"Digite o cargo atual do funcionario producao, administrativo ou diretoria");

cargo = Console.ReadLine();

Console.WriteLine($"digite o salario do funcionario");
salario = double.Parse(Console.ReadLine());

if (cargo == "producao")
{
    NovoSalario = salario + (salario * 0.065f);
}

else if (cargo == "administrativo")
{
    NovoSalario = salario + (salario * 0.075f);
}

else if (cargo == "diretoria")
{
    NovoSalario = salario + (salario * 0.12f);
}

else
        {
            Console.WriteLine($"Cargo invalido");
            return;
        }

Console.WriteLine($"O novo salario reajustado é {NovoSalario}");