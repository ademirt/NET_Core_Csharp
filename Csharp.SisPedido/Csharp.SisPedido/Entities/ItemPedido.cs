using System.Globalization;

namespace Csharp.SisPedido.Entities
{
    class ItemPedido
    {
        public int Qtde { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; }

        //construtores
        public ItemPedido()
        {
        }

        public ItemPedido(int qtde, double preco, Produto produto)
        {
            Qtde = qtde;
            Preco = preco;
            Produto = produto;
        }

        //método
        public double SubTotal()
        {
            return Qtde * Preco;
        }

        public override string ToString()
        {
            return Produto.Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantidade: "
                + Qtde
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
