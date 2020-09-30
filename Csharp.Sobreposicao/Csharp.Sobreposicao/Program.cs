using Csharp.Sobreposicao.Entities;
using System;

namespace Csharp.Sobreposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta cc1 = new Conta(1001, "Fulano", 500.00);
            Conta cc2 = new ContaPoupanca(1002, "JJJ", 500.00, 0.01);

            cc1.Sacar(50);
            cc2.Sacar(50);

            Console.WriteLine(cc1.Saldo);
            Console.WriteLine(cc2.Saldo);
        }
    }
}

