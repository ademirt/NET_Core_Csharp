namespace Csharp.SisPedido.Entities
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }


        //construtores
        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
