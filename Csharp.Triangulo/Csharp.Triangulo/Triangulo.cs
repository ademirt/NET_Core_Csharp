using System;

namespace Csharp.Triangulo
{
    class Triangulo
    {
        //atributos
        public double A;
        public double B;
        public double C;

        //método
        public double CalcularArea()
        {
            double _p = (A + B + C) / 2.0;
            return Math.Sqrt(_p * (_p - A) * (_p - B) * (_p - C));
        }
    }
}