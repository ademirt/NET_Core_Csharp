namespace Csharp.ManagerProduto.Entities
{
    class Importado : Produto
    {
        public double TaxaAlfandega { get; set; }

        public Importado()
        {
        }

        public Importado(string nome, double preco, double taxaAlfandega) : base(nome ,preco)
        {
            TaxaAlfandega = taxaAlfandega;
        }

        ///
        public override string PrecoTag()
        {
            return base.PrecoTag() 
                   + " $" + Preco
                   + " (Taxa alfandega: $"+TaxaAlfandega+")"
                   ;
        }
    }
}
