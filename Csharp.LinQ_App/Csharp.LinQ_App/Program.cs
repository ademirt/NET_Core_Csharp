using Csharp.LinQ_App.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;


namespace Csharp.LinQ_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lendo dados de 'C:/temp/in.txt.....'");

            string path = @"C:\temp\in.txt";            

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Produto> lista = new List<Produto>();

                    while (!sr.EndOfStream)
                    {
                        string[] dado = sr.ReadLine().Split(",");

                        string nome = dado[0];
                        double preco = double.Parse(dado[1],CultureInfo.InvariantCulture);

                        lista.Add(new Produto() { Nome = nome, Preco = preco});
                    }

                    var media = lista.Select(p => p.Preco).DefaultIfEmpty(0.0).Average();
                    Console.WriteLine("Média de preço --> " +media);

                    var prods = lista.Where(p => p.Preco <= media).OrderByDescending(p => p.Nome);
                    foreach (var p in prods)
                    {
                        Console.WriteLine(p.Nome);
                    }


                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
