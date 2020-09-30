using System;


namespace Csharp.Generics_Restricao.Entities
{
    public class Produto : IComparable
    {
        public string Nome { get; set; }
        public double Preco { get; set; }


        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return Nome.PadRight(10,'.') + ", $" + Preco.ToString("F2");
        }

        public int CompareTo(object obj)
        {   
            if (!(obj is Produto))
            {
                throw new ArgumentException("Erro de comparação: argumento não é Produto!");
            }

            Produto p = obj as Produto;
            return Preco.CompareTo(p.Preco);
        }
    }
}