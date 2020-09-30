using System;
using System.Globalization;

namespace Csharp.Curso3
{
    class Program
    {
        static void Main(string[] args)
        {
            //entrada de dados
            Console.WriteLine("Digite um texto:");
            string str = Console.ReadLine();
            Console.WriteLine("Você digitou: " + str);

            //vetor
            Console.WriteLine("Digite a b c d:");
            string[] vet = Console.ReadLine().Split(' ');

            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine("Vetor pos={0}, valor={1}",i,vet[i]);
            }

            Console.WriteLine("Digite um valor com decimal:");
            double v1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite um valor inteiro:");
            int v2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor double-> {0}" , v1);
            Console.WriteLine("Valor int-> {0}" , v2);

        }
    }
}
