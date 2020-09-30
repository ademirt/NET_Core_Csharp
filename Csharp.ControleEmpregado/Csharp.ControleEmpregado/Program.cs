using Csharp.ControleEmpregado.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Csharp.ControleEmpregado
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Programa demonstrando uso de Poliformismo.
             */


            Console.Write("Informe a quantidade de funcionários: ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> func = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nEmpregado #{i}");
                Console.Write("Terceiro <s/n> ? ");
                char t = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas trabalhadas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Valor hora: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (t == 'S')
                {
                    Console.Write("Despesa adicional: ");
                    double despesa = double.Parse(Console.ReadLine());
                    func.Add(new Terceiro(nome, horas, valor, despesa));
                }
                else
                {
                    func.Add(new Funcionario(nome, horas, valor));
                }                
            }

            Console.Write("\nPagamentos-----------");
            foreach (Funcionario f in func)
            {
                Console.Write("\n" + f.Nome + " - $" + f.Pagamento());
            }
        }
    }
}
