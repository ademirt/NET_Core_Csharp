using System;
using System.Globalization;


namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.00;
            double medida = 53.12344544545454;

            Console.WriteLine("Produtos");
            Console.WriteLine("{0}, cujo preço é ${1:F2}",produto1, preco1);
            Console.WriteLine("{0}, cujo preço é ${1:F2}",produto2, preco2);
            Console.WriteLine("");
            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);
            Console.WriteLine("");
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (c/ 3 casas decimais): {medida:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString(CultureInfo.InvariantCulture)}");
        }
    }
}