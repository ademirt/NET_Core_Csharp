using System.Globalization;
using Csharp.Conta_abstrato.Entities;
using System;
using System.Collections.Generic;

namespace Csharp.Conta_abstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Conta> cc = new List<Conta>();

            cc.Add(new Poupanca(1001, "AAA", 500.00, 0.01));
            cc.Add(new Empresarial(1002, "BBB", 500.00, 400.00));
            cc.Add(new Poupanca(1003, "CCC", 500.00, 0.01));
            cc.Add(new Empresarial(1004, "DDD", 500.00, 600.00));

            double sum = 0.0;
            foreach (Conta c in cc)
            {
                sum += c.Saldo;
            }

            Console.WriteLine("Total saldo: $" + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Conta c in cc)
            {
                c.Sacar(15.35);
            }

            foreach (Conta c in cc)
            {
                Console.WriteLine("Saldo atualizado para conta " + c.Numero + ": $" + c.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
