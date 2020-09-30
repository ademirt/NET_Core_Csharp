namespace Csharp.Imposto.Entities
{
    abstract class Pessoa
    {
        //properties
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        //construtores
        protected Pessoa()
        {
        }
        protected Pessoa(string nome, double renda)
        {
            Nome = nome;
            RendaAnual = renda;
        }

        //método abastrato
        public abstract double CalcImposto();
    }
}
