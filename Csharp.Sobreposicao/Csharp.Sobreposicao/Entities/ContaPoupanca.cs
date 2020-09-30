namespace Csharp.Sobreposicao.Entities
{
    class ContaPoupanca : Conta
    {
        public double Juros { get; set; }

        public ContaPoupanca()
        {
        }

        public ContaPoupanca(int numero, string titular, double saldo , double juros)
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
