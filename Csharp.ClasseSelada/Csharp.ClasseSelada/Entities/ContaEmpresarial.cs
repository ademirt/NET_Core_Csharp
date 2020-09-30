namespace Csharp.ClasseSelada.Entities
{
    class ContaEmpresarial : Conta
    {
        public double LimiteEmprestimo { get; set; }

        public ContaEmpresarial()
        {
        }

        public ContaEmpresarial(int numero, string titular, double saldo, double limiteEmprestimo) 
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
