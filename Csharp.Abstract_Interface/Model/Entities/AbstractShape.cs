using Csharp.Abastract_Interface.Model.Enums;

namespace Csharp.Abastract_Interface.Model.Entities 
{
    abstract class AbstractShape : IShape 
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
