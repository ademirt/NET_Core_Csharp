using Csharp.Interface_heranca.Enums;

namespace Csharp.Interface_heranca.Entities
{
    class Retangulo : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }


        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Retangulo - w/h: " + Width +"/"+ Height + ", cor: " + Colors + ", Area: " + Area();
        }
    }
}