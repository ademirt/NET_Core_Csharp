using System;

namespace Csharp.Projeto.Imposto_DesignPatterns
{
    class CalculadorImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            double valor = imposto.Calcula(orcamento);
            Console.WriteLine(valor);
        }
    }
}
