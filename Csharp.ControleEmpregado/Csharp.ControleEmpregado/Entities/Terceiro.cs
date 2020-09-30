namespace Csharp.ControleEmpregado.Entities
{
    class Terceiro : Funcionario
    {
        //atributos
        public double Despesa { get; set; }

        //construtor
        public Terceiro()
        {
        }

        public Terceiro(string nome, int horas, double valorHora, double despesa) : base(nome,horas,valorHora)
        {
            Despesa = despesa;
        }

        //método
        public override double Pagamento()
        {
            //pagamento + adicional 110%
            return base.Pagamento() +  Despesa *  110 / 100;
        }
    }
}
