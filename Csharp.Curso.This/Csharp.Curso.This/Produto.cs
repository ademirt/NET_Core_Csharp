﻿using System.Globalization;

namespace Csharp.Curso.This
{
    class Produto
    {
        //atributos
        public string Nome;
        public double Preco;
        public int Qtde;

        //construtores
        public Produto()
        {
            Qtde = 0;
        }

        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int qtde)  
        {
            Nome = nome;
            Preco = preco;
            Qtde = qtde;
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