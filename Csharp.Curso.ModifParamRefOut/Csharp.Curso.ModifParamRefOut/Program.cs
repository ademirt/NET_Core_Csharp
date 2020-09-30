using System;

namespace Csharp.Curso.ModifParamRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            //Modificadores de parâmetros Ref / Out

            //--> Ref
            int a = 10;
            Calculadora.Triplicar(ref a);
            Console.WriteLine("A - triplicar = " + a);

            //--> Out
            a = 7;
            int result;
            Calculadora.Duplicar(a, out result);
            Console.WriteLine("A - duplicar = " + result);
        }
    }
}
