using System;

namespace Csharp.Curso.Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[5, 3];

            Console.WriteLine("Matriz length: " + mat.Length);
            Console.WriteLine("Matriz rank: " + mat.Rank);
            Console.WriteLine("Matriz getLength(0): " + mat.GetLength(0));
            Console.WriteLine("Matriz getLength(1): " + mat.GetLength(1));

        }
    }
}
