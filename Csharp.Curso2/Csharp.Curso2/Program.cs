using System;

namespace Csharp.Curso2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a++;
            Console.WriteLine("a: {0},  b:{1}", a, b);

            //conversão implícita de tipos...
            float x = 4.5f;
            double y = x;
            Console.WriteLine("x=" + x + ", y=" + y);

            //conversão explícita de tipos...
            double n1;
            float n2;

            n1 = 5.1;
            n2 = (float)n1;
            Console.WriteLine("n1=" + n1 + " , n2=" + n2);

            //
            int v1 = 5;
            int v2 = 2;
            double resultado = (double) v1 / v2;
            Console.WriteLine(resultado);
        }
    }
}
