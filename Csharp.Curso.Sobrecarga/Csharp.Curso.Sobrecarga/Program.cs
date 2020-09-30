using System;

namespace Csharp.Curso.Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
                       

            Produto prd = new Produto(nome ,preco);
            Console.WriteLine("Produto: " + prd);

            //alternativa para inicializar valores mesmo se não houver construtor!
            Produto prd_novo = new Produto
            {
                Nome = "IPad",
                Preco = 1250.00,
                Qtde = 20
            };

            Console.Write("Novo produto!! -> " + prd_novo);
            /*
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