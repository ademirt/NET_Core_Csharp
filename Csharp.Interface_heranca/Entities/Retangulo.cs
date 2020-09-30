namespace Csharp.Interface_heranca.Entities
{
    public class Retangulo : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Retangulo(double width, double height, Colors colors) : base(Colors)
        {
            Width = width;
            Height = height;
            Colors = colors;         
        }

        public double Area()
        {
            return 1;
        }

    }
}