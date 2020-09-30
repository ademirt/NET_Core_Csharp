using Csharp.MetodoAbstrato.Entities.Enum;
using System;

namespace Csharp.MetodoAbstrato.Entities
{
    class Circulo : Shape
    {
        public double Raio { get; set; }

        public Circulo(double raio, Cor cores) : base(cores)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
