
namespace Csharp.Interface_heranca.Entities
{
    public class Circulo : AbstractShape
    {
       public double Radius { get; set; } 

       public Circulo(double radius, Colors colors) : base(Colors)
       {
           Radius = radius;
           Colors = colors;                  
       }

       public double Area()
       {
           return 1;
       }
       
    }
}