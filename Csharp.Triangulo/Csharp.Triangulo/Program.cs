using System;
using System.Globalization;

namespace Csharp.Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando as var´s x e y
            Triangulo x, y;

            //Instanciando os objetos x e y
            x = new Triangulo();
            y = new Triangulo();


            Console.WriteLine("Informe as medidas do triangulo X:");
            x.A = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );
            x.B = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );
            x.C = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );

            Console.WriteLine("Informe as medidas do triangulo Y:");
            y.A = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );
            y.B = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );
            y.C = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );

            double areaX = x.CalcularArea();
            double areaY = y.CalcularArea();

            Console.WriteLine("Área do X: {0}", areaX.ToString("F4" ,CultureInfo.InvariantCulture));
            Console.WriteLine("Área do Y: {0}", areaY.ToString("F4" ,CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }

        }
    }
}
