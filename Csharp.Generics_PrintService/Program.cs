using System;
using Csharp.Generics_PrintService.Services;

namespace Csharp.Generics_PrintService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de valores: ");
            int n = int.Parse(Console.ReadLine());

            PrintService<string> prt = new PrintService<string>();

            for (int i = 1; i <= n; i++)     
            {
                prt.AddValor(i + "_teste_!");
            }

            prt.Print();
            Console.WriteLine("\nPrimeiro valor --> "+prt.First());
        }
    }
}
