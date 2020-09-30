namespace Csharp.Imposto.Entities
{
    class Fisica : Pessoa
    {
        public double VlrGastosSaude { get; set; }

        //construtores
        public Fisica()
        {
        }

        public Fisica(string nome, double renda, double vlrSaude) : base(nome,renda)
        {
            Nome = nome;
            RendaAnual = renda;
            VlrGastosSaude = vlrSaude;
        }

        //método
        public override double CalcImposto()
        {
            double rendaCalc = RendaAnual < 20000.0 ? RendaAnual * 15 / 100 : RendaAnual * 25 / 100;
            rendaCalc -= VlrGastosSaude * 50 / 100;

            return rendaCalc;
        }
    }
}
