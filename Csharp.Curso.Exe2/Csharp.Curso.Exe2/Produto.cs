using System.Globalization;

namespace Csharp.Curso.Exe2
{
    class Produto
    {
        //atributos
        public string Nome;
        public double Preco;
        public int Qtde;

        //constructor
        public Produto() 
        {
            Preco = 0.0;
            Qtde = 0;
        }

        //métodos
        public double ValorEstoque()
        {
            return Preco * Qtde;
        }

        public void AdicionaProduto(int _qtd) 
        {
            Qtde += _qtd;
        }
        public void RemoveProduto(int _qtd) 
        {
            Qtde -= _qtd;
        }

        //sobreposição do método ToString...
        public override string ToString()
        {
            return Nome + ", $ "
                        + Preco.ToString("F2", CultureInfo.InvariantCulture)
                        + ", "
                        + Qtde
                        + " unidades / Total: $ "
                        + ValorEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}