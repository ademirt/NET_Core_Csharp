using Csharp.ManagerProduto.Entities;
using System;
using System.Collections.Generic;

namespace Csharp.ManagerProduto
{
    class Program
    {
        static void Main()
        {

            /*
             * 
             * Mais um programa demonstrando poliformismo!!
             * 
             */

            Console.Write("Informe a quantidade de produtos: ");
            int qtd = int.Parse(Console.ReadLine());

            List<Produto> listProdutos = new List<Produto>();

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"\nDados do Produto #{i}:");
                Console.Write("Produto: Comum/Usado/Importado (c/u/i)? ");
                char tipo = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine());

                if (tipo == 'I') 
                {
                    Console.Write("Taxa alfandega: ");
                    double taxa = double.Parse(Console.ReadLine());

                    listProdutos.Add(new Importado(nome,preco,taxa));
                }
                else if (tipo == 'U')
                {
                    Console.Write("Data fabricação: ");
                    DateTime dtfabricacao = DateTime.Parse(Console.ReadLine());

                    listProdutos.Add(new Usado(nome, preco, dtfabricacao));
                }
                else
                {
                    listProdutos.Add(new Produto(nome,preco));
                }
            }

            Console.WriteLine("\n---------Imprimindo Tag Preço..........");
            foreach (Produto p in listProdutos)
            {
                Console.WriteLine(p.PrecoTag());
            }
        }
    }
}
