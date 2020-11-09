using System;

namespace Csharp.TratamentoExcecao
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine("resultado: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro divisão por zero!");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro de formatação: " + e.Message);
            }
        }
    }
}
