using System;
using System.Collections.Generic;

namespace Csharp.Conjunto_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> a = new HashSet<int>();
            HashSet<int> b = new HashSet<int>();
            HashSet<int> c = new HashSet<int>();            

            a.Add(21);
            a.Add(35);
            a.Add(22);

            b.Add(21);
            b.Add(50);

            c.Add(42);
            c.Add(35);
            c.Add(13);

            c.UnionWith(a);
            c.UnionWith(b);

            Console.WriteLine($" Total valores --> {c.Count}");

        }
    }
}
