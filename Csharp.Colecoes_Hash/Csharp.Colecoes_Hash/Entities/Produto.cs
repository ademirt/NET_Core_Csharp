namespace Csharp.Colecoes_Hash.Entities
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override int GetHashCode()
        {
            return Nome.GetHashCode() + Preco.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Produto))
            {
                return false;
            }
            Produto o = obj as Produto;
            return Nome.Equals(o.Nome) && Preco.Equals(o.Preco);
        }

    }
}