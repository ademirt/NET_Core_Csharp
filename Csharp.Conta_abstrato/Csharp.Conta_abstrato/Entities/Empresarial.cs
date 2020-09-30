namespace Csharp.Conta_abstrato.Entities
{
    class Empresarial : Conta
    {
        public double LimiteEmprestimo { get; set; }

        public Empresarial()
        {
        }

        public Empresarial(int numero, string titular, double saldo, double limiteEmprestimo)
            : base(numero, titular, saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestimo(double valor)
        {
            if (valor <= LimiteEmprestimo)
            {
                Saldo += valor;
            }
        }
    }
}
