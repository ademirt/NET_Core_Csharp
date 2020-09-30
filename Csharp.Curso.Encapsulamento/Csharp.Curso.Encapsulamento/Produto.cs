using System.Globalization;

namespace Csharp.Curso.Encapsulamento
{
    class Produto
    {
        //ATRIBUTO
        private string _nome;
        private double _preco { get; set; }
        private int _qtde { get; set; }

        //CONSTRUCTOR
        public Produto()
        {
            _qtde = 0;
        }

        //Construtor com sobrecarga...
        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            _preco = preco;
        }

        //PROPERTIES
       /* public string _nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 0)
                {
                    _nome = value;
                }
            }
        }*/

        //MÉTODOS
        public double ValorEstoque()
        {
            return _preco * _qtde;
        }
        public void AdicionaProduto(int qtde)
        {
            _qtde += qtde;
        }
        public void RemoveProduto(int qtde)
        {
            _qtde -= qtde;
        }

        //SOBREPOSIÇÃO MÉTODO
        public override string ToString()
        {
            return _nome + ", $ "
                        + _preco.ToString("F2", CultureInfo.InvariantCulture)
                        + ", "
                        + _qtde
                        + " unidades / Total: $ "
                        + ValorEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}