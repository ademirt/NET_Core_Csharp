
namespace Csharp.Projeto.Imposto_DesignPatterns
{
    class Icms : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}
