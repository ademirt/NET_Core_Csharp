namespace Csharp.Projeto.Imposto_DesignPatterns
{
    public class Orcamento
    {
        public double Valor { get; private set; }

        //construtor
        public Orcamento(double valor)
        {
            Valor = valor;
        }
    }
}
