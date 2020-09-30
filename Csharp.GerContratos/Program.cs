using Csharp.GerContratos.Entities;
using Csharp.GerContratos.Services;
using System;
using System.Globalization;

namespace Csharp.GerContratos
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("----- Informe dados do contrato:");

            Console.Write("\nNúmero: ");
            int nrContrato = int.Parse(Console.ReadLine());

            Console.Write("Data do contrato (dd/MM/aaaa): ");
            DateTime dtContrato = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Valor do contrato: ");
            double vlContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contrato contrato = new Contrato(nrContrato,dtContrato,vlContrato);

            Console.Write("Numero de parcelas: ");
            int nrParcelas = int.Parse(Console.ReadLine()); 

            ContratoService contratoService = new ContratoService(new PayPalService());

            contratoService.GerarParcela(contrato ,nrParcelas);

            Console.WriteLine("\nPARCELAS.............");
            foreach (Parcela par in contrato.Parcela)
            {
                Console.WriteLine(par);                
            }
            

        }
    }
}
