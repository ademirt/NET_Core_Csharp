using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.ManagerProduto.Entities
{
    class Usado : Produto
    {
        public DateTime DataFabricacao { get; set; }

        public Usado()
        {
        }

        public Usado(string nome, double preco, DateTime dataFabricacao) : base(nome, preco)
        {
            DataFabricacao = dataFabricacao;
        }

        ///
        public override string PrecoTag()
        {
            return base.PrecoTag()
                    + " (usado) $" + Preco
                    + " (Data de fabricação: " + DataFabricacao.ToString("d/MM/yyyy") + ")"
                    ;
        }        
    }
}
