using System.Collections.Generic;
using System;
using Csharp.Generics_Restricao.Entities;
using Csharp.Generics_Restricao.Services;

namespace Csharp.Generics_Retricao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe N: ");
            int n = int.Parse(Console.ReadLine());

            List<Produto> prod = new List<Produto>();

            for (int i = 1; i <= n; i++)     
            {
                string[] v = Console.ReadLine().Split(',');
                string nome = v[0];
                double preco = double.Parse(v[1]);

                prod.Add(new Produto(nome,preco));
            }

            CalcularService calcService = new CalcularService();
            Produto max = calcService.Max(prod);

            Console.WriteLine(" max -> "+max);
            
        }
    }
}
