using System;

namespace Csharp.Curso.Exe6
{
    class Program
    {
        static void Main()
        {            
            Console.Write("Entre com o número da ContaBancaria: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o títular da ContaBancaria: ");
            string titular = Console.ReadLine();

            double valor;

            //instancia a Classe ContaBancaria passando: nr. ContaBancaria/titular
            ContaBancaria ct = new ContaBancaria(numero, titular);

            Console.Write("Haverá depósito inicial (s/n) ? ");
            char depini = char.Parse(Console.ReadLine().ToUpper());

            if ( depini == 'S')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine());

                //instancia a Classe ContaBancaria passando: nr.ContaBancaria/titular/valor
                ct = new ContaBancaria(numero, titular, valor);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da ContaBancaria:");
            Console.WriteLine(ct);

            Console.WriteLine();
            Console.Write("Digite um valor para depósito: ");
            valor = double.Parse(Console.ReadLine());
            ct.Depositar(valor);
            Console.WriteLine("Dados da ContaBancaria atualizados:");
            Console.WriteLine(ct);

            Console.WriteLine();
            Console.Write("Digite um valor para saque: ");
            valor = double.Parse(Console.ReadLine());            
            ct.Sacar(valor);
            Console.WriteLine("Dados da ContaBancaria atualizados:");
            Console.WriteLine(ct);
        }
    }
}
