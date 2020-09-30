using System;

namespace Csharp.Interface_heranca.Entities
{
    class Circulo : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circulo - raio: " + Radius + ", cor: " + Colors + ", Area: " + Area();
        }
    }
}