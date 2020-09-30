using Csharp.LinQ_Sql.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Csharp.LinQ_Sql
{
    class Program
    {
        static void Print<T>(string msg, IEnumerable<T> colecao)
        {
            Console.WriteLine("\n" + msg);
            foreach (T obj in colecao)
            {
                Console.WriteLine("  " + obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            /*
             * LinQ notação similar ao SQL
             * 
             */

            var c1 = new Categoria() { Id = 1, Nome = "Ferramentas", Camada = 1 };
            var c2 = new Categoria() { Id = 2, Nome = "Máquinas", Camada = 100 };
            var c3 = new Categoria() { Id = 3, Nome = "Eletrônicos", Camada = 150 };

            List<Produto> prods = new List<Produto>()
            {
                new Produto(){Id = 1, Nome = "Computador", Preco = 1200.00, Categoria = c2},
                new Produto(){Id = 2, Nome = "Tablet", Preco = 950.00, Categoria = c2},
                new Produto(){Id = 3, Nome = "Martelo", Preco = 30.00, Categoria = c1},
                new Produto(){Id = 4, Nome = "Serrote", Preco = 48.00, Categoria = c1},
                new Produto(){Id = 5, Nome = "Sensor", Preco = 45.00, Categoria = c3},
                new Produto(){Id = 6, Nome = "PlacaX", Preco = 40.00, Categoria = c3},
                new Produto(){Id = 7, Nome = "alicate", Preco = 48.00, Categoria = c1},
                new Produto(){Id = 8, Nome = "chave philips", Preco = 56, Categoria = c1},
                new Produto(){Id = 9, Nome = "trena", Preco = 77, Categoria = c1},
                new Produto(){Id = 10, Nome = "XXXXXX", Preco = 148.00, Categoria = c1}
            };


            var r1 = from p in prods
                     where p.Categoria.Camada == 1 && p.Preco < 900.00
                     select p;
            Print("Produto Camada=1,  Preço < 900.00  :", r1);

            var r2 = from p in prods
                     where p.Categoria.Nome == "Eletrônicos"
                     select p.Nome;
            Print("lista de eletronicos: ", r2);

            var r3 = from p in prods
                     where p.Nome[0] == 'C'
                     select new { p.Nome, p.Preco, CategNome = p.Categoria.Nome };
            Print("Nomes que iniciam com C:", r3);

            //var r4 = prods.Where(p => p.Categoria.Camada == 1).OrderByDescending(p => p.Preco).ThenBy(p => p.Nome);
            var r4 = from p in prods
                     where p.Categoria.Camada == 1
                     orderby p.Nome
                     orderby p.Preco
                     select p;
            Print("Categoria 1, ordenados por preço e nome:", r4);

            //var r5 = r4.Skip(2).Take(4);
            var r5 = (from p in prods select p).Skip(2).Take(4);
            Print("Categoria 1, ordenados p/ preço/nome , pulando 1 e pegando 4:", r5);


            Console.WriteLine("\nlistagem de produtos:");
            //var r16 = prods.GroupBy(p => p.Categoria);
            var r16 = from p in prods
                      group p by p.Categoria;
            foreach (IGrouping<Categoria, Produto> grp in r16)
            {
                Console.WriteLine("Categ: " + grp.Key.Nome + ":");
                foreach (Produto p in grp)
                {
                    Console.WriteLine(p);
                }
            }


        }
    }
}