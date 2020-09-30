using System;
using System.Collections.Generic;

namespace Csharp.Curso.Listas
{
    class Program
    {
        static void Main()
        {
            List<string> list = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                list.Add("Teste_" + i);
            }
            list.Insert(0, "insert!!!");
            list.Insert(1, "test");

            List<double> valores = new List<double>();
            valores.Add(4.55);
            valores.Add(5.211);
            valores.Insert(0, 9);

            Console.WriteLine("**** dados de list...");
            Console.WriteLine("\nQtd elementos = " + list.Count);
            foreach (var l in list)
            {
                Console.WriteLine(l);
            }

            Console.WriteLine("\n**** dados de valores...");
            Console.WriteLine("\nQtd elementos = "+ valores.Count);
            foreach (var v in valores)
            {
                Console.WriteLine(v);
            }

            //Expressões lambda
            Console.WriteLine("\nProcurando por 'i': " + list.Find(x => x[0] == 'i'));

            Console.WriteLine("\nListando dados de 'list', com max 6 caracteres!");
            List<string> lista2 = list.FindAll(x => x.Length <= 6);
            foreach (var obj in lista2)
            {
                Console.WriteLine(obj);
            }



        }
    }
}
