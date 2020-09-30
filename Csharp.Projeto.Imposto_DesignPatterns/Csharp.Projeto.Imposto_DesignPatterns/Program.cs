using System;

namespace Csharp.Projeto.Imposto_DesignPatterns
{
    class Program
    {
        static void Main()
        {
            //interface Imposto
            IImposto iss = new Iss();
            IImposto icms = new Icms();

            Orcamento orcamento = new Orcamento(500.00);

            CalculadorImpostos calcimposto = new CalculadorImpostos();

            calcimposto.RealizaCalculo(orcamento, iss);
            calcimposto.RealizaCalculo(orcamento, icms);
        }
    }
}
