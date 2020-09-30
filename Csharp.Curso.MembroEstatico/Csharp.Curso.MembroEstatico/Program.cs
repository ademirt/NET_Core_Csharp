using System;
using System.Globalization;

namespace Csharp.Curso.MembroEstatico
{
    class Program
    {
        //membro estático
        static double Pi = 3.14;

        static void Main(string[] args)
        {
            Console.Write("Informe o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circulo = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferência: " + circulo.ToString("F2" ,CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        //membro estático
        static double Circunferencia(double _raio)
        {
            return 2.0 * Pi * _raio;
        }

        //membro estático
        static double Volume(double _raio)
        {
            return 4.0 / 3.0 * Pi * _raio * _raio * _raio;
        }
    }
}
