using System.Collections.ObjectModel;
using System.Collections.Generic;
using System;

namespace Csharp.HashSet_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            HashSet<string> setH = new HashSet<string>();

            setH.Add("teste1");
            setH.Add("teste2");
            setH.Add("teste3");

            Console.WriteLine(setH.Contains("teste2"));

            foreach (var s in setH)
            {
                Console.WriteLine(s);                
            }

            // SortedSET.........
            SortedSet<int> a = new SortedSet<int>() {0,1,5,7,5,15,24,48,99,6};
            SortedSet<int> b = new SortedSet<int>() {10,15,50,60,99};

            //Union....
            Console.WriteLine("Sorted Union......................");
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            ListaColecao(c);

            //intersection
            Console.WriteLine("Sorted Intersection......................");
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            ListaColecao(d);

            //diference...
            Console.WriteLine("Sorted Diference......................");
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            ListaColecao(e);

        }

        static void ListaColecao<T>(IEnumerable<T> colecao)
        {
            foreach (T obj in colecao)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}