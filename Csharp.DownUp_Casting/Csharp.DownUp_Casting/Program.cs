using Csharp.DownUp_Casting.Entities;
using System;

namespace Csharp.DownUp_Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta cc = new Conta(1004, "Fulano", 0.0);
            ContaEmpresarial ccEmp = new ContaEmpresarial(1008, "Circlano", 0.0, 500.00);

            //UPCASTING
            Conta cc1 = ccEmp;
            Conta cc2 = new ContaEmpresarial(1009, "Juca", 0.0, 600);
            Conta cc3 = new ContaPoupanca(1010, "Sr.Juca", 0.0, 0.01);

            //DOWNCASTING            
            //ContaEmpresarial c1 = cc2;
            ContaEmpresarial ce1 = (ContaEmpresarial)cc2;
            ce1.Emprestimo(200.00);

            //ContaEmpresarial ccEmp2 = (ContaEmpresarial)cc3;
            if (cc3 is ContaEmpresarial)
            {
                ContaEmpresarial conta = (ContaEmpresarial)cc3;
                conta.Emprestimo(200);
                Console.WriteLine("Emprestimo");
            }

            if (cc3 is ContaPoupanca)
            {
                //ContaPoupanca conta = (ContaPoupanca)cc3;
                ContaPoupanca conta = cc3 as ContaPoupanca;
                conta.AtualizarSaldo();
                Console.WriteLine("AtualizarSaldo");
            }
        }
    }
}

