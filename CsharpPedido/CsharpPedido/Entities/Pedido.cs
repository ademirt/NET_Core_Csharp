using CsharpPedido.Entities.Enums;
using System;

namespace CsharpPedido.Entities
{
    class Pedido
    {
        public int Id { get; set; }
        public DateTime DataStatus { get; set; }
        public PedidoStatus Status { get; set; }

        public override string ToString()
        {
            return Id + ", " + DataStatus + ", " + Status;
        }
    }
}
