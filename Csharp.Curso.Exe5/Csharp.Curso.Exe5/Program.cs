using System;
using System.Globalization;

namespace Csharp.Curso.Exe5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dolar? ");
            //membro estático classe ConversorMoeda
            ConversorMoeda.ValorDolar = double.Parse(Console.ReadLine() ,CultureInfo.InvariantCulture);

            Console.Write("Quantidade em dólares a ser comprado? ");
            double qtdDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //chamar um método estático
            double dolares = ConversorMoeda.ConverterDolar(qtdDolar);


            Console.Write("Valor a ser pago em reais = R$ " +ConversorMoeda.CalcularIOF(dolares));
        }
    }
}
