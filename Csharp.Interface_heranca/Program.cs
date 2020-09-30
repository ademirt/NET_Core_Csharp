using System;
using Csharp.Interface_heranca.Entities;

namespace Csharp.Interface_heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("H");

            Circulo circulo = new Circulo(30,"Red");
            Console.Write("Circulo = " + circulo.Radius + ", cor: " + circulo.Colors);

        }
    }
}
