using Csharp.SisPedido.Entities;
using Csharp.SisPedido.Entities.Enums;
using System;

namespace Csharp.SisPedido
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("----- Informe dados do Cliente --------");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Dt. Nascimento (DD/MM/AAAA): ");
            DateTime dtaniversario = DateTime.Parse(Console.ReadLine());

            //cliente...
            Cliente cliente = new Cliente(nome, email, dtaniversario);


            Console.WriteLine("\n----- Informe dados do Pedido --------");
            
            //instanciando pedido...
            Pedido pedido = new Pedido(PedidoStatus.Processando, DateTime.Now, cliente);
            
            Console.Write("Status do pedido: " + pedido.Status);
            Console.Write("\nQuantos itens de pedido ? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\n--> Informe dados de #{i} item pedido:");
                Console.Write("Nome produto: ");
                string nmProduto = Console.ReadLine();
                Console.Write("Preço produto: ");
                double prProduto = double.Parse(Console.ReadLine());

                //dados do produto
                Produto produto = new Produto(nmProduto, prProduto);
                
                Console.Write("Quantidade: ");
                int qtde = int.Parse(Console.ReadLine());

                //Dados do item do pedido....
                ItemPedido itemPedido = new ItemPedido(qtde, prProduto, produto);

                //adicionar o item ao pedido
                pedido.AddItem(itemPedido);
            }

            Console.WriteLine("\n-----PEDIDO RELATÓRIO--------");
            Console.WriteLine(pedido);  
        }
    }
}
