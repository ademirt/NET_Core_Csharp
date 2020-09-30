using Csharp.Colecoes_Hash.Entities;
using System;
using System.Collections.Generic;

namespace Csharp.Colecoes_Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Produto> a = new HashSet<Produto>();
            a.Add(new Produto("TV", 1200.00));
            a.Add(new Produto("Notebook", 1233.00));
            
            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(2, 3));
            b.Add(new Point(12, 13));

            Produto p = new Produto("Notebook", 1233.00);

            Console.WriteLine(a.Contains(p));

            //testanto struct
            Point pnt = new Point(2, 3);
            Console.WriteLine(b.Contains(pnt));

        }
    }
}
