using Csharp.ArmazenaDados.Entities;
using System.IO;
using System.Collections.Generic;
using System;

namespace Csharp.ArmazenaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\teste.csv";

            try
            {
                using (StreamReader sr = File.OpenText(path)) 
                {
                    List<Funcionario> lista = new List<Funcionario>();

                    while (!sr.EndOfStream) 
                    {
                        lista.Add(new Funcionario(sr.ReadLine()));
                    }

                    lista.Sort();
                    foreach (var a in lista)
                    {
                        Console.WriteLine(a);                        
                    }                    
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }            
        }
    }
}
