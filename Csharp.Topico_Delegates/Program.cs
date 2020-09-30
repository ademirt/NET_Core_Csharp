using System;
using Csharp.Topico_Delegates.Services;
using Csharp.Topico_Delegates.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.Topico_Delegates
{

    delegate double BinaryNumericOperation(double a, double b);
    delegate void BinaryNumericOperationM(double a, double b);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            /*
             * 
             * Delegates....
             * 
             */
            Console.WriteLine("***Delegates.....");
            BinaryNumericOperation op = CalculationServices.Sum;

            double result = CalculationServices.Sum(a, b);
            Console.WriteLine("Resultado: " + result);

            double novo = op(a, b);
            Console.WriteLine("função delegate - Resultado: " + novo);


            /*
             * 
             * multicast delegates
             * 
             */

            Console.WriteLine("\n***Multicast delegates...");
            BinaryNumericOperationM o = CalculationServices.ShowSum;
            o += CalculationServices.ShowMax;

            o.Invoke(a, b);



            /*
             * 
             * Predicate...
             * 
             */
            Console.WriteLine("\n***Predicate....");
            List<Produto> list = new List<Produto>();
            list.Add(new Produto("Tv", 900.00));
            list.Add(new Produto("Mouse", 50.00));
            list.Add(new Produto("Tablet", 350.50));
            list.Add(new Produto("HD Case", 80.90));
            list.Add(new Produto("suporte", 85.90));

            list.RemoveAll(ProRemove);
            foreach (var x in list)
            {
                Console.WriteLine(x);
            }


            /*
             * 
             * Action....
             * 
             */
            Console.WriteLine("\n***Action.....");

            Action<Produto> act = UpdPreco;
            list.ForEach(act);

            list.ForEach(UpdPreco);

            foreach (var x in list)
            {
                Console.WriteLine(x);
            }

            /*
             * 
             * Func.....
             * 
             */
            Console.WriteLine("\n***Func.....");

            //    Func<Produto, string> fun = NomeUpper;
            //    List<string> lista = list.Select(NomeUpper).ToList();
            //    List<string> lista = list.Select(fun).ToList();

            Func<Produto, string> fun = p => p.Nome.ToUpper();
            List<string> lista = list.Select(fun).ToList();

            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }



        }

        public static bool ProRemove(Produto p)
        {
            return p.Preco >= 100.0;
        }

        static void UpdPreco(Produto p)
        {
            p.Preco += p.Preco * 0.1;
        }

        static string NomeUpper(Produto p)
        {
            return p.Nome.ToUpper();
        }
    }
}
