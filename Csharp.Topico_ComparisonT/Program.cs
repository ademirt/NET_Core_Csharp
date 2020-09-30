using System.Collections.Generic;
using System;
using Csharp.Topico_ComparisonT.Entities;

namespace Csharp.Topico_ComparisonT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            List<Produto> list = new List<Produto>();

            list.Add(new Produto("TV",950.00));
            list.Add(new Produto("Notebook",1280.00));
            list.Add(new Produto("Tablet",950.00));


            Comparison<Produto> comp = (a, b) => a.Nome.ToUpper().CompareTo(b.Nome.ToUpper()); //<-- lambda, ou função anônima
            list.Sort(comp);

            //expressão lambda in line
            list.Sort( (a, b) => a.Nome.ToUpper().CompareTo(b.Nome.ToUpper()) );

            //delegate
            list.Sort(CompareProd);

            foreach (Produto p in list)
            {
                Console.WriteLine(p);
            }
        }

        static int CompareProd(Produto a, Produto b)
        {
            return a.Nome.ToUpper().CompareTo(b.Nome.ToUpper());
        }
    }
}

