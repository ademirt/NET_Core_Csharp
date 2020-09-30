using System;
//using System.Globalization;

namespace Csharp.Curso.Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto prd = new Produto("TV",900.00);

            //prd.Nome = "TV 4K";

            Console.WriteLine("Produto (*Properties): " + prd);
        }
    }
}
