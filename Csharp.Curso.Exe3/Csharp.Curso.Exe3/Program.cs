using System;

namespace Csharp.Curso.Exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            p.SalBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            p.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + p);

            Console.WriteLine();
            Console.Write("Digite o % de aumento do salário: ");
            double prc = double.Parse(Console.ReadLine());

            p.AumentarSalPerc(prc);

            Console.WriteLine("Dados atualizados: " + p);


        }
    }
}
