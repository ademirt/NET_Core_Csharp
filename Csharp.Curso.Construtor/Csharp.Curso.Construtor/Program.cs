using System;

namespace Csharp.Curso.Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto prd = new Produto("TV",915.00,15);
            Console.WriteLine("Produto: " + prd);

            /*
            Console.WriteLine("Informe os dados do produto:");

            Console.Write("Nome: ");
            prd.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            prd.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            prd.Qtde = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto = " + prd);

            Console.WriteLine();
            Console.Write("Informe a quantidade de produtos a ser adicionada ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            prd.AdicionaProduto(qtd);
            Console.WriteLine("Dados atualizados: " + prd);

            Console.WriteLine();
            Console.Write("Informe a quantidade de produtos a ser removida do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            prd.RemoveProduto(qtd);
            Console.WriteLine("Dados atualizados: " + prd);*/
        }
    }
}