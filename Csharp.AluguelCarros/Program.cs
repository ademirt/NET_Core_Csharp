using System;
using System.Globalization;
using Csharp.AluguelCarros.Entities;
using Csharp.AluguelCarros.Services;

namespace Csharp.AluguelCarros
{
    class Program
    {
        static void Main()
        {
            /*
            *   Exemplo programa sem interface....
            *
            */

            Console.WriteLine("Informe os dados do alguel:");
            Console.Write("\nModelo do carro: ");
            string modelo = Console.ReadLine();

            Console.Write("Data retirada (dd/MM/aaaa hh:mm): ");
            DateTime dtRetirada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Data devolução (dd/MM/aaaa hh:mm): ");
            DateTime dtDevolucao = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Informe o preço por hora: ");
            double vlrhora = double.Parse(Console.ReadLine());

            Console.Write("Informe o preço por dia: ");
            double vlrdia = double.Parse(Console.ReadLine());

            Aluguel aluguel = new Aluguel(dtRetirada ,dtDevolucao ,new Veiculo(modelo));
            AluguelService aluguelService = new AluguelService(vlrhora ,vlrdia , new BrasilTaxaService());
            
            aluguelService.ProcessaFatura(aluguel);

            Console.WriteLine("\nFATURA: ");
            Console.WriteLine(aluguel.Fatura);
        }
    }
}
