using Csharp.SisPedido.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.SisPedido.Entities
{
    class Pedido
    {
        public Cliente Cliente { get; set; }
        public DateTime DtPedido { get; set; }
        public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();
        public PedidoStatus Status { get; set; }
        public Cliente ClientePedido { get; set; }


        //Construtor
        public Pedido()
        { 
        }
        public Pedido(PedidoStatus status, DateTime dtpedido, Cliente cliente)
        {
            Status = status;
            DtPedido = dtpedido;
            ClientePedido = cliente;
        }

        //métodos

        public void AddItem(ItemPedido itemPedido)
        {
            Itens.Add(itemPedido);
        }

        public void RmvItem(ItemPedido itemPedido)
        {
            Itens.Remove(itemPedido);
        }

        public double Total()
        {
            double total = 0;

            foreach (ItemPedido item in Itens)
            {
                total += item.Preco * item.Qtde;
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Pedido data: " + DtPedido.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Pedido status: " + Status);
            sb.AppendLine("Cliente: " + ClientePedido.ToString());
            sb.AppendLine("-- itens do pedido:");
            foreach (ItemPedido item in Itens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("---Total Pedido: " + Total());

            return sb.ToString();
        }
    }
}
