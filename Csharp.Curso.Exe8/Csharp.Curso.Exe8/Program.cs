using System;
using System.Globalization;
using System.Collections.Generic;

namespace Csharp.Curso.Exe8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Deseja cadastrar quantos funcionários? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> Listafuncionarios = new List<Funcionario>();
            int id;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nEmpregado #{0}:", (i+1));
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Listafuncionarios.Add(new Funcionario(id, nome, salario));
            }

            Console.Write("\nInforme o ID do funcinário para aumento de salário: ");
            id = int.Parse(Console.ReadLine());

            Funcionario funcionario = Listafuncionarios.Find(x => x.Id == id);

            //
            //verifica se o ID informado existe na lista...
            if (funcionario != null) { 

                Console.Write("Informe o % de aumento: ");
                double percentual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                               
                //
                //Calcula o % de reajuste de salário...
                funcionario.AjusteSalario(percentual);
            }
            else
            {
                Console.WriteLine("Id funcionário inexistente!!!");
            }            

            Console.WriteLine("\nLista atualizada de empregados:");
            Listafuncionarios.ForEach(f => Console.WriteLine(f));
        }
    }
}