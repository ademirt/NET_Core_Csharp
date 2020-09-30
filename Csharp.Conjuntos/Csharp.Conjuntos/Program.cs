using Csharp.Conjuntos.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace Csharp.Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Caminho do arquivo log:");
            string path = "C:/Users/teste/source/repos/logs.txt";

            HashSet<LogRegs> setLogs = new HashSet<LogRegs>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] linha = sr.ReadLine().Split(" ");
                        string nome = linha[0];
                        DateTime data = DateTime.Parse(linha[1]);
                        setLogs.Add(new LogRegs {Nome = nome, Data = data});
                    }
                }

                Console.WriteLine("Total regs: " + setLogs.Count);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
