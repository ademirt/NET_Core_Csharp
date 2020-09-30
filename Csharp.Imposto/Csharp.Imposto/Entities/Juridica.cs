using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Imposto.Entities
{
    class Juridica : Pessoa
    {
        //properties
        public int  QtdFuncionarios { get; set; }


        //contrutores
        public Juridica()
        {
        }
        public Juridica(string nome, double renda, int qtdFuncionarios) : base(nome,renda)
        {
            Nome = nome;
            RendaAnual = renda;
            QtdFuncionarios = qtdFuncionarios;
        }

        //método
        public override double CalcImposto()
        {
            return QtdFuncionarios <= 10 ? RendaAnual * 16 / 100 : RendaAnual * 14 / 100;
        }
    }
}
