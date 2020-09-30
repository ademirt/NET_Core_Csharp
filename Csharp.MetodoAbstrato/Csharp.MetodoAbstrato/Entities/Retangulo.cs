using Csharp.MetodoAbstrato.Entities.Enum;

namespace Csharp.MetodoAbstrato.Entities
{
    class Retangulo : Shape
    {
        //properties
        public double Largura { get; set; }
        public double Altura { get; set; }
        
        public Retangulo(double largura, double altura, Cor cores) : base(cores)
        {
            Largura = largura;
            Altura = altura;
        }


        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
