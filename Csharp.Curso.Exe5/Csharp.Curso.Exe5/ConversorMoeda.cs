using System;
using System.Runtime.CompilerServices;

namespace Csharp.Curso.Exe5
{
    class ConversorMoeda
    {
        public static double ValorDolar;

        public static double ConverterDolar(double _qtdDolar)
        {
            return _qtdDolar * ValorDolar;
        }

        public static double CalcularIOF(double _valor)
        {
            return _valor + ((_valor * 6) / 100);
        }
    }
}
