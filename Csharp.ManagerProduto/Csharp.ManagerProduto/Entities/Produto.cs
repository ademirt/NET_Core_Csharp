namespace Csharp.ManagerProduto.Entities
{
    class Produto
    {
        //Properties...........
        public string Nome { get; set; }
        public double Preco { get; set; }

        //construtores.......
        public Produto()
        {
        }
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }


        //Métodos.........
        public virtual string PrecoTag()
        {
            return Nome + " $" + Preco;
        }
    }
}
