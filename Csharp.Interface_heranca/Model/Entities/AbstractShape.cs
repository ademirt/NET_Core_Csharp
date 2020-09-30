using Csharp.Interface_heranca.Enums;
using Csharp.Interface_heranca.Services;

namespace Csharp.Interface_heranca.Entities
{
    abstract class AbstractShape : IShape
    {
        public Colors Colors { get; set; }

        public abstract double Area();
    }
}