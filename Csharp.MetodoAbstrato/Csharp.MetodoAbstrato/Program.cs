using Csharp.MetodoAbstrato.Entities;
using Csharp.MetodoAbstrato.Entities.Enum;
using System;
using System.Collections.Generic;

namespace Csharp.MetodoAbstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a qtd de figuras: ");
            int n = int.Parse(Console.ReadLine());

            List<Shape> list = new List<Shape>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nShape #{i} dados:");
                Console.Write("Retangulo ou Círculo (r/c) ? ");
                char c = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Cores: Vermelho/Azul/Amarelo: ");
                Cor cor = Enum.Parse<Cor>(Console.ReadLine());

                if (c == 'R')
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine());
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine());

                    list.Add(new Retangulo(largura, altura, cor));
                }
                else
                {
                    Console.Write("Raio: ");
                    double raio = double.Parse(Console.ReadLine());

                    list.Add(new Circulo(raio, cor));
                }
            }

            Console.WriteLine("\nSHAPE AREAS");
            foreach (Shape s in list)
            {
                Console.WriteLine(s.Area().ToString("F2"));
            }            
        }
    }
}