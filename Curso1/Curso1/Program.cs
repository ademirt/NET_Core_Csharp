using System;
using System.Globalization;

namespace Curso1
{
    class Program
    {
        static void Main(string[] args)
        {
            SByte x = 100;
            sbyte a = 55;
            long b = 1234564654654L;
            bool full = false;

            char sexo = 'F';

            //unicode...
            char v_uni = '\u0041';//irá imprimir A

            float _fl = 4.5f;
            double _db = 5.6;

            string _nm = "String teste....";
            object _obj = "black soul foda";

            int valMax = int.MaxValue;
            int valMin = int.MinValue;
            double valorManutencao = 10.95989;

            Console.WriteLine("x={0}, a={1}, b={2}", x, a, b);
            Console.WriteLine("completo ? " + full);
            Console.WriteLine("Sexo : " + sexo);
            Console.WriteLine("Teste unicode = " + v_uni);
            Console.WriteLine("Float = {0}, Double={1}", _fl, _db);
            Console.WriteLine("String=" + _nm);
            Console.WriteLine("Objeto=" + _obj);
            Console.WriteLine("Max int:{0}, Min int:{1}", valMax, valMin);
            
            //arredondamento de valor para 3 casas...
            Console.WriteLine("Valor manutenção: " +valorManutencao.ToString("F3") );

            //irá formatar conforme o país...
            Console.WriteLine("Valor manutenção..: " + valorManutencao.ToString("F4",CultureInfo.InvariantCulture) );

            //interpolação...
            Console.WriteLine($"Valor manutenção..: {valorManutencao:F2}");
        }
    }
}