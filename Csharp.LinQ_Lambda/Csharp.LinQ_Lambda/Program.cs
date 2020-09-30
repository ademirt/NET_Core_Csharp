using Csharp.LinQ_Lambda.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Csharp.LinQ_Lambda
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
            var c1 = new Categoria() { Id = 1, Nome = "Ferramentas", Camada = 1 };
            var c2 = new Categoria() { Id = 2, Nome = "Máquinas", Camada = 100 };
            var c3 = new Categoria() { Id = 3, Nome = "Eletrônicos", Camada = 150 };

            List<Produto> list = new List<Produto>()
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


            var r1 = list.Where(p => p.Categoria.Camada == 1 && p.Preco < 900.00);
            Print("Produto Camada=1,  Preço < 900.00  :", r1);

            var r2 = list.Where(p => p.Categoria.Nome == "Eletrônicos").Select(p => p.Nome);
            Print("Lista de ferramentas: ", r2);

            var r3 = list.Where(p => p.Nome[0] == 'C').Select(p => new { p.Nome, p.Preco, CategNome = p.Categoria.Nome });
            Print("Nomes que iniciam com C:", r3);

            var r4 = list.Where(p => p.Categoria.Camada == 1).OrderByDescending(p => p.Preco).ThenBy(p => p.Nome);
            Print("Categoria 1, ordenados por preço e nome:", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("Categoria 1, ordenados p/ preço/nome , pulando 1 e pegando 4:", r5);

            var r6 = list.FirstOrDefault();
            Console.WriteLine("\nFirst or default r6 -> " + r6);

            var r7 = list.Where(p => p.Preco > 3500.00).FirstOrDefault();
            Console.WriteLine("\nFirst or default r7 -> " + r7);

            var r8 = list.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("\nSingle or default -> " + r8);

            var r9 = list.Where(p => p.Id == 97979).SingleOrDefault();
            Console.WriteLine("\nSingle or default -> " + r9);

            //agregação....
            var r10 = list.Max(p => p.Preco);
            Console.WriteLine("Preco max: " + r10);

            var r11 = list.Min(p => p.Preco);
            Console.WriteLine("Preco min: " + r11);

            var r12 = list.Where(p => p.Categoria.Id == 1).Sum(p => p.Preco);
            Console.WriteLine("Soma dos produtos categ 1: " + r12);

            var r13 = list.Where(p => p.Categoria.Id == 1).Average(p => p.Preco);
            Console.WriteLine("Média dos produtos categ 1: " + r13);

            var r14 = list.Where(p => p.Categoria.Id == 5).Select(p => p.Preco).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Média(segurança) dos produtos categ 5: " + r14);

            var r15 = list.Where(p => p.Categoria.Id == 7).Select(p => p.Preco).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("função aggregate: " + r15);

            Console.WriteLine("\nListagem de produtos:");
            var r16 = list.GroupBy(p => p.Categoria);
            foreach (IGrouping<Categoria,Produto> grp in r16)
            {
                Console.WriteLine("Categ: "+grp.Key.Nome + ":");
                foreach (Produto p in grp)
                {
                    Console.WriteLine(p);
                }
            }
            

        }
    }
}