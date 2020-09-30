using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Csharp.Curso.Vetores
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

             /*double[] vetor = new double[n];

            for (int i = 0; i < n; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }*/

            //Vetor Classe
            Produto[] vetp = new Produto[n];
            
            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vetp[i] = new Produto { Nome = nome, Preco = preco };
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vetp[i].Preco;
            }
            double avg = soma / n;
            Console.WriteLine("Média preço: "  +  avg.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
