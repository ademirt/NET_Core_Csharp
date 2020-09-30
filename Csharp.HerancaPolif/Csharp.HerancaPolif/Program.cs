using Csharp.HerancaPolif.Entities;
using System;

namespace Csharp.HerancaPolif
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaEmpresarial conta = new ContaEmpresarial(2934, "Fulano", 100.00, 500.00);

            Console.WriteLine(conta.Saldo);
        }
    }
}
