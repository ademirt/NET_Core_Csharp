using System;

namespace Csharp.Curso.Params
{
    class Program
    {
        static void Main()
        {
            Calculadora calc = new Calculadora();
            
            int soma = calc.Soma(4,6);
            Console.WriteLine("soma = " + soma);

            soma = calc.Soma(5, 3, 4, 6,9,4,5,15,95,78,15,4,5);
            Console.WriteLine("soma = " + soma);
        }
    }
}
