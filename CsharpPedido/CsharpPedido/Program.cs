using System;
using CsharpPedido.Entities;
using CsharpPedido.Entities.Enums;

namespace CsharpPedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido
            {
                Id = 15151,
                DataStatus = DateTime.Now,
                Status = PedidoStatus.PagamentoPendente
            };

            Console.WriteLine(pedido);

            string txt = PedidoStatus.PagamentoPendente.ToString();
            Console.WriteLine(txt);

            PedidoStatus os = Enum.Parse<PedidoStatus>("Entregue");
            Console.WriteLine(os);
        }
    }
}
