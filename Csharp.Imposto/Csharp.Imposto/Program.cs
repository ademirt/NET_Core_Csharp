using Csharp.Imposto.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;

namespace Csharp.Imposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de taxas a pagar: ");
            int n = int.Parse(Console.ReadLine());

            List<Pessoa> list = new List<Pessoa>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nTaxa pagamento #{i} dados:");

                Console.Write("Físico ou Jurídico (F/J) ? ");
                char t = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Ganho anual: ");
                double ganho = double.Parse(Console.ReadLine());

                if (t == 'F')
                {
                    Console.Write("Gastos c/ saúde: ");
                    double vlrGastosSaude = double.Parse(Console.ReadLine());

                    list.Add(new Fisica(nome, ganho, vlrGastosSaude));
                }
                else
                {
                    Console.Write("Número de colaboradores: ");
                    int qtdFun = int.Parse(Console.ReadLine());

                    list.Add(new Juridica(nome, ganho, qtdFun));
                }
            }

            Console.WriteLine("\nTAXAS A PAGAR:");
            double vlrTotalTaxas = 0;
            foreach (Pessoa p in list)
            {
                Console.WriteLine(p.Nome + ": $" + p.CalcImposto());
                vlrTotalTaxas += p.CalcImposto();
            }

            Console.Write("\nTOTAL TAXAS: " + vlrTotalTaxas + "\n");

        }
    }
}
