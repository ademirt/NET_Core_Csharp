using System;

namespace Csharp.Curso.Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto p;
            p.X = 2;
            p.Y = 3;

            Console.WriteLine(p);

            p = new Ponto();
            Console.WriteLine(p);

            //Nullable
            Nullable<double> A = null;

            //nullable
            double? B = null;
            double? Z = 55.5;

            Console.WriteLine("\nGetValueOrDefault...");
            Console.WriteLine(B.GetValueOrDefault());
            Console.WriteLine(Z.GetValueOrDefault());

            Console.WriteLine("\nHasValue...");
            Console.WriteLine(B.HasValue);
            Console.WriteLine(Z.HasValue);

            Console.WriteLine("\nValue...");
            if (B.HasValue) { Console.WriteLine(B.Value); } else { Console.WriteLine("B é nulo"); }
            if (Z.HasValue) { Console.WriteLine(Z.Value); } else { Console.WriteLine("Z é nulo"); }

            //Operador de coalescência nula
            int? a1 = null;
            int? a2 = 10;
            int a3 = a1 ?? 5;
            int a4 = a2 ?? 5;

            Console.WriteLine("\nOperador coalescência...");
            Console.WriteLine("A3 = "+a3+", A4 = "+a4);

        }
    }
}
