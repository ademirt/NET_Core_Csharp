namespace Csharp.Conta_abstrato.Entities
{
    class Poupanca : Conta
    {
        public double Juros { get; set; }

        public Poupanca()
        {
        }

        public Poupanca(int numero, string titular, double saldo, double juros)
            : base(numero, titular, saldo)
        {
            Juros = juros;
        }

        //método
        public void AtualizarSaldo()
        {
            Saldo += Saldo * Juros;
        }

        public override void Sacar(double valor)
        {
            base.Sacar(valor);
            Saldo -= 2.0;
        }
    }
}
