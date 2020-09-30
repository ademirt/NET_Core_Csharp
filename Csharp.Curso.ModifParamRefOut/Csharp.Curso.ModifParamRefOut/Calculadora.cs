using System;

namespace Csharp.Curso.ModifParamRefOut
{
    class Calculadora
    {
        public static void Triplicar(ref int x)
        {
            x = x * 3;
        }

        public static void Duplicar(int x, out int result)
        {
            result = x * 2;
        }
    }
}